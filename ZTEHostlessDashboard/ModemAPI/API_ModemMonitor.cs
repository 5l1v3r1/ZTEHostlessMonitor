using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZTEHostlessDashboard.ModemAPI
{
    class API_ModemMonitor : API_Get
    {

        public API_ModemMonitor() : base() {
            cmd_requests = new[] { "signalbar", "sim_imsi", "modem_main_state", "net_select", 
                    "network_type", "domain_stat", "network_provider", "spn_name_data",
                    "ppp_status", "mdm_mcc", "mdm_mnc", "lac_code","cell_id","lte_pci",
                    "lte_band","lte_rsrp","lte_rsrq","lte_rssi","lte_snr","rssi","rscp",
                    "ecio", "wan_csq","wan_active_band","wan_apn", "wan_ipaddr", 
                    "realtime_tx_thrpt", "realtime_rx_thrpt","prefer_dns_auto","standby_dns_auto",
                    "prefer_dns_manual","standby_dns_manual","simcard_roam", "sms_unread_num",
                    "realtime_tx_bytes", "realtime_rx_bytes", "rmcc", "rmnc", "realtime_time",
                    "monthly_time"
                        };
        }
    }
}
