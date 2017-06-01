using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace ZTEHostlessDashboard.ModemAPI
{
    public abstract class API_Get : API_Base
    {
        readonly string _url_suffix = "/goform/goform_get_cmd_process?multi_data=1&cmd=";
        
        protected string[] cmd_requests;   
        protected string[] cmd
        {
            get { return cmd_requests; }
        }

        public API_Get()
        {
            dashboard_addr = Properties.Settings.Default.dashboard_addr;
            base_url = _url_protocol + dashboard_addr + _url_suffix;
            referer = _url_protocol + dashboard_addr + _referer;
        }

        protected override object Process(string url)
        {
            HttpWebRequest request;
            HttpWebResponse response;
            dynamic obj;
            string result;

            try
            {
                request = (HttpWebRequest)WebRequest.Create(url);
                request.Timeout = Properties.Settings.Default.operation_timeout;
                request.Referer = referer;
            }
            catch (UriFormatException x)
            {
                throw new API_Error(x.Message, x.GetType().ToString());
            }

            try
            {
                response = (HttpWebResponse)request.GetResponse();
            }
            catch (WebException x)
            {
                throw new API_Error(x.Message,x.GetType().ToString());
            }
            
            result = Helper.String.StreamToString(response.GetResponseStream());
            
            try 
	        {	        
		        obj = JObject.Parse(result);
	        }
	        catch (JsonException x)
	        {
                throw new API_Error(x.Message, x.GetType().ToString());
	        }

            return obj;
        }

        protected string PrepareURL(string[] cmds)
        {
            string url = base_url + String.Join(",", cmds);
            return url;
        }

        public override object Execute()
        {
            var cmd_url = PrepareURL(cmd);
            try
            {
                return Process(cmd_url);
            }
            catch (API_Error x)
            {
                throw x;
            }
        }
    }
}
