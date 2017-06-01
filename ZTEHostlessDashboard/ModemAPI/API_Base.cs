using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZTEHostlessDashboard.ModemAPI
{
    public abstract class API_Base
    {
        protected string base_url { get; set; }
        protected string referer { get; set; }
        protected string dashboard_addr;

        protected readonly string _url_protocol = "http://";
        protected readonly string _referer = "/index.html";
        protected abstract object Process(string url);
        public abstract object Execute();
    }
}
