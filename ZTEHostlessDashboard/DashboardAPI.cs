using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Windows.Forms;

namespace ZTEHostlessDashboard
{
    class DashboardAPI
    {
        private string base_url { get; set; }
        private string referer { get; set; }
        readonly string _url_protocol = "http://";
        readonly string _url_suffix = "/goform/goform_get_cmd_process?multi_data=1&cmd=";
        readonly string[] cmd_initial = {  "model_name", "imei", "web_version", 
                                                      "modem_main_state","wa_inner_version", 
                                                      "hardware_version"
                                                   };
        readonly string[] cmd = { "signalbar", "sim_imsi", "modem_main_state", "net_select",
                                   "network_type", "domain_stat", "network_provider", "ppp_status",
                                   "rmcc", "rmnc", "lac_code","cell_id","lte_pci","lte_band",
                                   "lte_rsrp","lte_rsrq","lte_rssi","lte_snr","rssi","rscp","ecio",
                                   "wan_csq","wan_active_band","wan_apn", "wan_ipaddr",
                                   "realtime_tx_thrpt", "realtime_rx_thrpt","prefer_dns_auto",
                                   "standby_dns_auto", "simcard_roam", "unread_sms"
                                };
        readonly string _referer = "/index.html";

        public DashboardAPI(string dashboard_addr)
        {
            base_url = _url_protocol + dashboard_addr + _url_suffix;
            referer = _url_protocol + dashboard_addr + _referer;
        }

        public object GetStaticDeviceInfo()
        {
            return JSON2Object(prepareURL(cmd_initial));
        }

        public object GetResponse()
        {
            return JSON2Object(prepareURL(cmd));
        }

        private object JSON2Object(string url)
        {
            HttpWebRequest request;
            HttpWebResponse response;
            string result;
            dynamic obj;

            request = (HttpWebRequest)WebRequest.Create(url);
            request.Timeout = 3000;
            request.Referer = referer;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException x)
            {
                showError(x.Message);
                return null;
            }
            
            result = ResponseStream2String(response.GetResponseStream());
            
            try 
	        {	        
		        obj = JObject.Parse(result);
	        }
	        catch (JsonException x)
	        {
		        showError(x.Message);
                return null;
	        }
            return obj;
        }

        private string prepareURL(string[] cmds)
        {
            string url = base_url + String.Join(",", cmds);
            return url;
            
        }

        private static void showError(string error_message)
        {
            MessageBox.Show(error_message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
        }

        public string ResponseStream2String(Stream s)
        {
            StreamReader reader = new StreamReader(s);
            string result = reader.ReadToEnd();
            return result;           
        }
    }
}
