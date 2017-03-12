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


namespace ZTEHostlessDashboard
{
    public partial class Monitor : Form
    {
        DashboardAPI dash;
        Ping pinger = new Ping();
        BackgroundWorker worker_GetStaticDeviceInfo = new BackgroundWorker();
        bool quick_connect_ok;
        int pooling_interval;

        public Monitor()
        {
            InitializeComponent();
            worker_GetStaticDeviceInfo.DoWork += new DoWorkEventHandler(worker_StaticDeviceInfo_DoWork);
            worker_GetStaticDeviceInfo.RunWorkerCompleted += new RunWorkerCompletedEventHandler(worker_StaticDeviceInfo_RunWorkerCompleted);
            pingDashboardAddress();
            //stupid StatusStrip SizingGrip bugfix
            statusStrip.Padding = new Padding(statusStrip.Padding.Left,
            statusStrip.Padding.Top, statusStrip.Padding.Left, statusStrip.Padding.Bottom);
        }

        private void backgroundWorker_AJAXFetch_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                dynamic response = dash.GetResponse();
                if (response == null || backgroundWorker_AJAXFetch.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                backgroundWorker_AJAXFetch.ReportProgress((int)response.signalbar, response);
                Thread.Sleep(pooling_interval);
            }
        }

        private void Monitor_Load(object sender, EventArgs e)
        {
            tb_dashboardAddress.Text = Properties.Settings.Default.dashboard_addr;
            pooling_interval = Properties.Settings.Default.pooling_interval;
        }

        private void worker_StaticDeviceInfo_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            dynamic o = e.Result;
            if (o == null)
            {
                return;
            }
            tb_State.Text = o.modem_main_state;
            toolStripStatusLabel_Model.Text = o.model_name;
            tb_IMEI.Text = o.imei;
            tb_HWVer.Text = o.hardware_version;
            tb_FWVer.Text = o.wa_inner_version;
            tb_SWVer.Text = o.web_version;
            switchMonitorButtons();
            backgroundWorker_AJAXFetch.RunWorkerAsync();
            toolStripStatusLabel.Text = "Connected";
        }

        private void worker_StaticDeviceInfo_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = dash.GetStaticDeviceInfo();
        }

        private void backgroundWorker_AJAXFetch_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            signalBar.Value = e.ProgressPercentage * 20;
            dynamic o = e.UserState;
            //Device Information GroupBox
            tb_State.Text = o.modem_main_state;
            tb_IMSI.Text = o.sim_imsi;
            // Network GroupBox
            tb_OpName.Text = o.network_provider;
            tb_MCC.Text = o.rmcc;
            tb_MNC.Text = o.rmnc;
            tb_LAC.Text = o.lac_code;
            tb_CellID.Text = o.cell_id;
            tb_NetSelect.Text = o.net_select;
            tb_NetType.Text = o.network_type;
            tb_NetDomainSpec.Text = o.domain_stat;
            tb_PPPState.Text = o.ppp_status;
            tb_Roam.Text = o.simcard_roam;
            //Signal GroupBox
            tb_RSSI.Text = o.rssi;
            tb_RSCP.Text = o.rscp;
            tb_ECIO.Text = o.ecio;
            tb_CSQ.Text = o.wan_csq;
            tb_ActiveBand.Text = o.wan_active_band;
            tb_LTEBand.Text = o.lte_band;
            tb_LTEPCI.Text = o.lte_pci;
            tb_LTERSRP.Text = o.lte_rsrp;
            tb_LTERSSI.Text = o.lte_rssi;
            tb_LTERSRQ.Text = o.lte_rsrq;
            tb_LTESNR.Text = o.lte_snr;
            //WAN
            tb_APN.Text = o.wan_apn;
            tb_IPAddress.Text = o.wan_ipaddr;
            tb_DNS1.Text = o.prefer_dns_auto;
            tb_DNS2.Text = o.standby_dns_auto;
            tb_TxRate.Text = Helpers.StrFormatNetSpeed((string)o.realtime_tx_thrpt);
            tb_RxRate.Text = Helpers.StrFormatNetSpeed((string)o.realtime_rx_thrpt);
        }

        private void Monitor_FormClosing(object sender, FormClosingEventArgs e)
        {
            cancelAPIFetchWorker();
        }

        private void emptyValue()
        {
            foreach (Control gb in this.Controls) {
                if (gb is GroupBox)
                {
                    foreach (Control control in gb.Controls)
                    {
                        if (control is TextBox)
                            control.Text = null;
                        if (control is ProgressBar)
                            ((ProgressBar)control).Value = 0;
                    }
                }
            }
        }

        private void btn_StartMonitor_Click(object sender, EventArgs e)
        {
            dash = new DashboardAPI(tb_dashboardAddress.Text);
            worker_GetStaticDeviceInfo.RunWorkerAsync();
        }

        private void btn_StopMonitor_Click(object sender, EventArgs e)
        {
            cancelAPIFetchWorker();
        }

        private void cancelAPIFetchWorker()
        {
            if (backgroundWorker_AJAXFetch.IsBusy)
            {
                backgroundWorker_AJAXFetch.CancelAsync();
            }
        }

        private void backgroundWorker_AJAXFetch_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            toolStripStatusLabel.Text = "Standby";
            switchMonitorButtons();
            emptyValue();
        }

        private void switchMonitorButtons()
        {
            bool startmonitor_visible = btn_StartMonitor.Visible;
            btn_StartMonitor.Visible = !startmonitor_visible;
            toolStripStatusLabel_Model.Visible = tb_dashboardAddress.ReadOnly = btn_StopMonitor.Visible = startmonitor_visible;
        }

        private void tb_dashboardAddress_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.dashboard_addr = ((TextBox)sender).Text;
            Properties.Settings.Default.Save();
        }

        private void Monitor_Shown(object sender, EventArgs e)
        {
            if (quick_connect_ok)
                btn_StartMonitor.PerformClick();
        }

        private void pingDashboardAddress()
        {
            try
            {
                var reply = pinger.Send(Properties.Settings.Default.dashboard_addr, 1000);
                if (reply.Status == IPStatus.Success)
                    quick_connect_ok = true;
            }
            catch (PingException)
            {
                quick_connect_ok = false;
            }
            
        }

    }
}
