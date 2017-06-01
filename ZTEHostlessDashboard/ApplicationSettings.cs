using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZTEHostlessDashboard
{
    class ApplicationSettings
    {
        public string dashboard_addr { get; set; }
        public int pooling_interval { get; set; }
        public bool always_on_top { get; set; }
        public static Properties.Settings Settings = Properties.Settings.Default;

        public static ApplicationSettings Load()
        {
            return new ApplicationSettings()
            {
                dashboard_addr = Settings.dashboard_addr,
                pooling_interval = Settings.pooling_interval,
                always_on_top = Settings.always_on_top
            };

        }

        public void Save()
        {
            Settings.dashboard_addr = this.dashboard_addr;
            Settings.pooling_interval = this.pooling_interval;
            Settings.always_on_top = this.always_on_top;
            Settings.Save();
        }
    }
}
