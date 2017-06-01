using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.NetworkInformation;
using System.Net;
using ZTEHostlessDashboard.ModemAPI;
using System.Resources;


namespace ZTEHostlessDashboard
{
    public partial class Monitor : Form
    {
        bool device_connected;
        bool modem_connected;
        bool pending_address_change;
        ApplicationSettings settings_container;

        delegate void UpdateControlTextMethodInvoker(dynamic c, string text);

        public Monitor()
        {
            InitializeComponent();
            //stupid StatusStrip SizingGrip bugfix
            statusStrip.Padding = new Padding(statusStrip.Padding.Left,
            statusStrip.Padding.Top, statusStrip.Padding.Left, statusStrip.Padding.Bottom);
        }

        private void Monitor_Shown(object sender, EventArgs e)
        {
            settings_container = ApplicationSettings.Load();
            tb_dashboardAddress.Text = settings_container.dashboard_addr;
            numericUpDown_PoolingInterval.Value = settings_container.pooling_interval;
            checkBox_AlwaysOnTop.Checked = this.TopMost = settings_container.always_on_top;
            button_Save.Enabled = false;
            toolStripStatusLabel.Text = "Standby";
            runPinger();
        }

        private void Monitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            stopWorker(backgroundWorker_DevicePinger);
            stopWorker(backgroundWorker_AJAXFetch);
        }

        private void backgroundWorker_DevicePinger_DoWork(object sender, DoWorkEventArgs e)
        {
            var pinger = new Ping();

            toolStripStatusLabel.Text = "Contacting " + settings_container.dashboard_addr;
            Thread.Sleep(ApplicationSettings.Settings.cooldown_interval);
            while (!device_connected)
            {
                if (backgroundWorker_DevicePinger.CancellationPending) { e.Cancel = true; return; }
                try
                {
                    var reply = pinger.Send(settings_container.dashboard_addr,
                        settings_container.pooling_interval);

                    switch (reply.Status)
                    {
                        case IPStatus.TimedOut:
                            break;
                        case IPStatus.Success:
                            device_connected = true;
                            break;
                        default:
                            toolStripStatusLabel.Text = "Error : " + Helper.String.SplitCamelCase(reply.Status.ToString());
                            break;
                    }
                }
                catch (PingException p)
                {
                    toolStripStatusLabel.Text = "Error : " + p.Message;
                }
                Thread.Sleep(settings_container.pooling_interval);
            }
        }

        private void backgroundWorker_DevicePinger_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            worker_GetStaticDeviceInfo.RunWorkerAsync();
        }

        private void worker_StaticDeviceInfo_DoWork(object sender, DoWorkEventArgs e)
        {
            var api = new API_InitialInformation();
            dynamic initial_info;
            Invoke(new UpdateControlTextMethodInvoker(UpdateControlText), toolStripStatusLabel, "Gathering initial info...");
            Thread.Sleep(ApplicationSettings.Settings.cooldown_interval);
            
            initial_info = api.Execute();
            e.Result = initial_info;
        }

        private void worker_StaticDeviceInfo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                toolStripStatusLabel.Text = "Error : " + e.Error.Message;
                return;
            }

            dynamic o = e.Result;
            toolStripStatusLabel_Model.Text = Helper.String.EmptyToAlt(o.model_name, "Unknown");
            tb_IMEI.Text = o.imei;
            tb_HWVer.Text = o.hardware_version;
            tb_FWVer.Text = o.wa_inner_version;
            tb_SWVer.Text = o.web_version;

            Invoke(new UpdateControlTextMethodInvoker(UpdateControlText), toolStripStatusLabel, "Initial info gathered");
            backgroundWorker_AJAXFetch.RunWorkerAsync();
        }

        private void backgroundWorker_AJAXFetch_DoWork(object sender, DoWorkEventArgs e)
        {
            var monitor = new API_ModemMonitor();
            dynamic response;
            
            Invoke(new UpdateControlTextMethodInvoker(UpdateControlText), toolStripStatusLabel, "Fetching information...");
            Thread.Sleep(ApplicationSettings.Settings.cooldown_interval);
            while (device_connected)
            {
                if (backgroundWorker_AJAXFetch.CancellationPending) { e.Cancel = true; return; }
                response = monitor.Execute();
                backgroundWorker_AJAXFetch.ReportProgress((int)response.signalbar, response);
                Thread.Sleep(settings_container.pooling_interval);
            }
        }        

        private void backgroundWorker_AJAXFetch_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            dynamic o = e.UserState;
            Int64 current_total, sms_unread_num;
            toolStripStatusLabel.Text = "Ready";
            signalBar.Value = e.ProgressPercentage * 20;

            Int64.TryParse(o.sms_unread_num.ToString(), out sms_unread_num);
            Int64.TryParse(o.realtime_tx_bytes.ToString(), out current_total);
            // Parse integers
            try
            {
                current_total += Convert.ToInt64(o.realtime_rx_bytes);
            }
            catch (Exception) { }

            //Device Information GroupBox
            tb_State.Text = Helper.String.EmptyToNA(o.modem_main_state);
            tb_IMSI.Text = Helper.String.EmptyToNA(o.sim_imsi);
            // Network GroupBox
            label_OpName.Text = 
                tb_OpName.Text = Helper.String.EmptyToAlt(o.spn_name_data, o.network_provider, Helper.String.HexToUTF8(o.spn_name_data));
            tb_MCC.Text = Helper.String.EmptyToAlt(o.mdm_mcc, o.rmcc);
            tb_MNC.Text = Helper.String.EmptyToAlt(o.mdm_mnc, o.rmnc);
            tb_LAC.Text = Helper.String.EmptyToNA(o.lac_code);
            tb_CellID.Text = Helper.String.EmptyToNA(o.cell_id);
            tb_NetSelect.Text = Helper.String.GetStringFromResource(o.net_select);
            label_NetType.Text = 
                tb_NetType.Text = Helper.String.GetStringFromResource(o.network_type);
            tb_NetDomainSpec.Text = Helper.String.GetStringFromResource(o.domain_stat);
            label_PPPStatus.Text = 
                tb_PPPState.Text = Helper.String.GetStringFromResource(o.ppp_status);
            tb_Roam.Text = Helper.String.EmptyToNA(o.simcard_roam);
            //Signal GroupBox
            tb_RSSI.Text = Helper.String.EmptyToNA(o.rssi);
            tb_RSCP.Text = Helper.String.EmptyToNA(o.rscp);
            tb_ECIO.Text = Helper.String.EmptyToNA(o.ecio);
            tb_CSQ.Text = Helper.String.EmptyToNA(o.wan_csq);
            tb_ActiveBand.Text = Helper.String.EmptyToNA(o.wan_active_band);
            tb_LTEBand.Text = Helper.String.EmptyToNA(o.lte_band);
            tb_LTEPCI.Text = Helper.String.EmptyToNA(o.lte_pci);
            tb_LTERSRP.Text = Helper.String.EmptyToNA(o.lte_rsrp);
            tb_LTERSSI.Text = Helper.String.EmptyToNA(o.lte_rssi);
            tb_LTERSRQ.Text = Helper.String.EmptyToNA(o.lte_rsrq);
            tb_LTESNR.Text = Helper.String.EmptyToNA(o.lte_snr);
            // Dashboard
            var signal_strength = (o.network_type == "LTE" ? o.lte_rsrp : o.rscp);
            pictureBox_signalbar.Image = (Image)Helper.ResourceManager.GetObject("_" + e.ProgressPercentage);
            label_SignalStrength.Text = Helper.String.EmptyToAlt(signal_strength, "No Signal", signal_strength + " dBm");
            label_UnreadSMS.Text = sms_unread_num.ToString();
            pictureBox_SMSIcon.Visible = 
                label_UnreadSMS.Visible = (sms_unread_num > 0);
            //WAN
            tb_APN.Text = o.wan_apn;
            if (o.ppp_status == "ppp_connected")
            {
                modem_connected = true;
                button_CDC.Text = "Disconnect";
                tb_IPAddress.Text = o.wan_ipaddr;
                //tb_DNS1.Text = Helpers.IsEmpty(o.prefer_dns_auto) ? o.prefer_dns_manual : o.prefer_dns_auto;
                //tb_DNS2.Text = Helpers.IsEmpty(o.standby_dns_auto) ? o.standby_dns_manual : o.standby_dns_auto;
                tb_DNS1.Text = Helper.String.EmptyToAlt(o.prefer_dns_auto, o.prefer_dns_manual);
                tb_DNS2.Text = Helper.String.EmptyToAlt(o.standby_dns_auto, o.standby_dns_manual);
                label_TxRate.Text = tb_TxRate.Text = Helper.DataRate.FormatNetSpeed(o.realtime_tx_thrpt.ToString());
                label_RxRate.Text = tb_RxRate.Text = Helper.DataRate.FormatNetSpeed(o.realtime_rx_thrpt.ToString());
                label_CurrentTotal.Text = Helper.DataRate.FormatByteSize(current_total.ToString());
                label_CurrentDuration.Text = Helper.Time.SecondsToHMD(o.realtime_time);
                label_CurrentTx.Text = Helper.DataRate.FormatByteSize(o.realtime_tx_bytes.ToString());
                label_CurrentRx.Text = Helper.DataRate.FormatByteSize(o.realtime_rx_bytes.ToString());
            }
            else
            {
                modem_connected = false;
                button_CDC.Text = "Connect";
                EmptyControlText(tb_IPAddress, tb_DNS1, tb_DNS2, label_TxRate, tb_TxRate, 
                label_RxRate, tb_RxRate, label_CurrentTx, label_CurrentRx, label_CurrentTotal, 
                label_CurrentDuration);
            }

            panel_Connected.Visible = true;
            button_CDC.Enabled = true;
        }

        private void backgroundWorker_AJAXFetch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                toolStripStatusLabel.Text = "Error : " + e.Error.Message;
            }
            ClearTextBoxes();
            panel_Connected.Visible = false;
            toolStripStatusLabel_Model.Text = "No Device";
            runPinger();
        }

        private void backgroundWorker_ModemCDC_DoWork(object sender, DoWorkEventArgs e)
        {
            var api_cdc = new API_CDC();
            dynamic o;
            if (modem_connected)
	        {
		        Invoke(new UpdateControlTextMethodInvoker(UpdateControlText), button_CDC, "Disconnecting");
                o = api_cdc.disconnect();
	        } else {
                Invoke(new UpdateControlTextMethodInvoker(UpdateControlText), button_CDC, "Connecting");
                o = api_cdc.connect();
            }
            e.Result = o;
        }

        private void backgroundWorker_ModemCDC_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dynamic o = e.Result;
            if (e.Error != null)
            {
                MessageBox.Show(e.Error.Message, e.Error.Source, MessageBoxButtons.OK, 
                    MessageBoxIcon.Error);
            }
            if (o.result.ToString() == "failure")
            {
                MessageBox.Show("Action failed", this.Text,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1);
            }
        }

        private void tb_dashboardAddress_TextChanged(object sender, EventArgs e)
        {
            var c = (TextBox)sender;
            pending_address_change = (settings_container.dashboard_addr == settings_container.dashboard_addr);
            settings_container.dashboard_addr = c.Text;
            button_Save.Enabled = true;
        }

        private void checkBox_AlwaysOnTop_CheckedChanged(object sender, EventArgs e)
        {
            var c = (CheckBox)sender;
            settings_container.always_on_top = this.TopMost = c.Checked;
            button_Save.Enabled = true;
        }

        private void numericUpDown_PoolingInterval_ValueChanged(object sender, EventArgs e)
        {
            var c = (NumericUpDown)sender;
            settings_container.pooling_interval = Convert.ToInt32(c.Value);
            button_Save.Enabled = true;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            var save = new Action(() => {
                settings_container.Save();
                MessageBox.Show("Settings saved.", this.Text, 
                    MessageBoxButtons.OK, MessageBoxIcon.Information, 
                    MessageBoxDefaultButton.Button1);
                if (pending_address_change)
                {
                    stopWorker(backgroundWorker_AJAXFetch);
                    if (!backgroundWorker_AJAXFetch.IsBusy)
                        runPinger();
                    pending_address_change = false;
                }
                    
            });

            if (InvokeRequired)
            {
                Invoke(save);
                return;
            }
            save();
        }

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
                {
                    foreach (Control control in controls)
                    {
                        if (control == tabPage_AppSettings) continue;
                        if (control is TextBox)
                            control.Text = null;
                        else if (control is ProgressBar)
                            ((ProgressBar)control).Value = 0;
                        else
                            func(control.Controls);
                    }
                };

            func(tabControl_Monitor.Controls);
        }

        private void runPinger()
        {
            device_connected = false;
            backgroundWorker_DevicePinger.RunWorkerAsync();
        }

        private void stopWorker(BackgroundWorker bw)
        {
            if (bw.IsBusy)
            {
                bw.CancelAsync();
            }
        }

        private void button_CDC_Click(object sender, EventArgs e)
        {
            button_CDC.Enabled = false;
            backgroundWorker_ModemCDC.RunWorkerAsync();
        }

        private void UpdateControlText(dynamic c, string text)
        {
            c.Text = text;
        }

        private void EmptyControlText(params dynamic[] list)
        {
            foreach (var param in list)
	        {
                param.Text = "N/A";
	        }
        }

    }
}
