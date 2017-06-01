using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.IO;
using System.Windows.Forms;

namespace ZTEHostlessDashboard.ModemAPI
{
    abstract class API_Post : API_Base
    {
        protected string[] post_data
        {
            get
            {
                return form_data.Select(x => EscapeData(x.Key, x.Value)).ToArray();
            }
        }
        readonly string _url_suffix = "/goform/goform_set_cmd_process";

        protected Dictionary<string, string> form_data = new Dictionary<string, string>();

        public API_Post()
        {
            dashboard_addr = Properties.Settings.Default.dashboard_addr;
            base_url = _url_protocol + dashboard_addr + _url_suffix;
            referer = _url_protocol + dashboard_addr + _referer;
        }

        protected override object Process(string url)
        {
            HttpWebRequest request;
            HttpWebResponse response;
            Stream dataStream;
            string result;
            dynamic obj;

            try
            {
                request = (HttpWebRequest)WebRequest.Create(url);
                request.Timeout = Properties.Settings.Default.long_operation_timeout;
                request.Referer = referer;
                request.Method = "POST";
                string postData = EncodePostData();
                byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = byteArray.Length;
                dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();
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
                throw new API_Error(x.Message, x.GetType().ToString());
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

        private string EncodePostData()
        {
            var urlencoded_string = String.Join("&",post_data);
            return urlencoded_string;
        }

        private string EscapeData(string key, string value)
        {
            return Uri.EscapeDataString(key) + "=" + Uri.EscapeDataString(value);
        }

        public override object Execute()
        {
            try
            {
                return Process(base_url);
            }
            catch (API_Error x)
            {
                throw x;
            }
        }
    }
}
