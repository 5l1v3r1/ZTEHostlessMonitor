using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZTEHostlessDashboard.ModemAPI
{
    class API_CDC : API_Post
    {
        public API_CDC() : base() { }

        public object disconnect()
        {
            form_data.Add("isTest", "false");
            form_data.Add("notCallback", "true");
            form_data.Add("goformId", "DISCONNECT_NETWORK");
            return Execute();
        }

        public object connect()
        {
            form_data.Add("isTest", "false");
            form_data.Add("notCallback", "true");
            form_data.Add("goformId", "CONNECT_NETWORK");
            return Execute();
        }

    }
}
