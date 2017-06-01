using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.IO;
using System.Resources;

namespace ZTEHostlessDashboard
{
    public static class Helper
    {
        static string[] ordinals = new[] { "", "K", "M", "G", "T", "P", "E" };
        public static ResourceManager ResourceManager = Properties.Resources.ResourceManager;

        public static class DataRate
        {
            public static string FormatByteSize(dynamic data)
            {
                decimal bytes;
                Decimal.TryParse(data, out bytes);
                var ordinal = 0;
                while (bytes > 1000)
                {
                    bytes /= 1000;
                    ordinal++;
                };
                return System.String.Format("{0} {1}B",
                    Math.Round(bytes, 2, MidpointRounding.AwayFromZero),
                    ordinals[ordinal]);
            }

            public static string FormatNetSpeed(dynamic rate_str)
            {
                decimal rate;
                Decimal.TryParse(rate_str, out rate);
                rate *= 8;
                var ordinal = 0;
                while (rate > 1000)
                {
                    rate /= 1000;
                    ordinal++;
                }
                return System.String.Format("{0} {1}b/s",
                    Math.Round(rate, 2, MidpointRounding.AwayFromZero),
                    ordinals[ordinal]);
            }   
        }

        public static class String
        {
            public static string SplitCamelCase(string str)
            {
                return Regex.Replace(
                    Regex.Replace(
                        str,
                        @"(\P{Ll})(\P{Ll}\p{Ll})",
                        "$1 $2"
                    ),
                    @"(\p{Ll})(\P{Ll})",
                    "$1 $2"
                );
            }
            public static string HexToUTF8(dynamic data)
            {
                var hex = Convert.ToString(data);
                byte[] raw = new byte[hex.Length / 4];
                for (int i = 0; i < raw.Length; i++)
                {
                    raw[i] = Convert.ToByte(hex.Substring(i * 4, 4), 16);
                }

                return System.Text.Encoding.UTF8.GetString(raw);
            }

            public static bool IsEmptyString(dynamic x)
            {
                return x.ToString() == "";
            }

            public static string StreamToString(Stream s)
            {
                StreamReader reader = new StreamReader(s);
                string result = reader.ReadToEnd();
                return result;
            }

            public static string GetStringFromResource(dynamic x)
            {
                var str = x.ToString();
                return ResourceManager.GetString(str) == null ? str : ResourceManager.GetString(str);
            }

            public static string EmptyToNA(dynamic str)
            {
                return IsEmptyString(str) ? "N/A" : str.ToString();
            }

            public static string EmptyToAlt(dynamic str, dynamic alt)
            {
                return IsEmptyString(str) ? alt.ToString() : str.ToString();
            }

            public static string EmptyToAlt(dynamic str, dynamic alt_empty, dynamic alt_not_empty)
            {
                return IsEmptyString(str) ? alt_empty.ToString() : alt_not_empty.ToString();
            }

        }

        public static class Time
        {
            public static string SecondsToHMD(dynamic x)
            {
                Int64 s;
                Int64.TryParse(x.ToString(), out s);
                TimeSpan ts = TimeSpan.FromSeconds(s);
                var h = (ts.Days * 24) + ts.Hours;
                return h.ToString("D2") + ts.ToString(@"\:mm\:ss");

            }
        }

    }
}
