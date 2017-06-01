using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZTEHostlessDashboard.ModemAPI
{
    class API_InitialInformation : API_Get
    {
        
        public API_InitialInformation() : base()
        {
            cmd_requests = new[] { "model_name", "imei", "web_version", "modem_main_state", 
            "wa_inner_version", "hardware_version" };
        }

    }
}
