using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ZTEHostlessDashboard
{
    class API_Error : Exception
    {
        public string ClassName { get; set; }

        public API_Error(string message) : base(message) { }

        public API_Error(string message, string class_name) : base(message)
        {
            this.ClassName = class_name;
        }

    }
}
