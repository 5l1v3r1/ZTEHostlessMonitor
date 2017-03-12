using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;

namespace ZTEHostlessDashboard
{
    static class Helpers
    {
        [DllImport("Shlwapi.dll", CharSet = CharSet.Auto)]
        public static extern long StrFormatByteSize(
                long fileSize
                , [MarshalAs(UnmanagedType.LPTStr)] StringBuilder buffer
                , int bufferSize);


        /// <summary>
        /// Converts a numeric value into a string that represents the number expressed as a size value in bytes, kilobytes, megabytes, or gigabytes, depending on the size.
        /// </summary>
        /// <param name="filelength">The numeric value to be converted.</param>
        /// <returns>the converted string</returns>
        public static string StrFormatByteSize(long filesize)
        {
            StringBuilder sb = new StringBuilder(11);
            StrFormatByteSize(filesize, sb, sb.Capacity);
            return sb.ToString();
        }

        public static string StrFormatNetSpeed(string rate_str)
        {
            decimal rate;
            Decimal.TryParse(rate_str, out rate);
            var ordinals = new[] { "", "K", "M", "G", "T", "P", "E" };
            var ordinal = 0;
            while (rate > 1000)
            {
                rate /= 1000;
                ordinal++;
            }
            return String.Format("{0} {1}B/s",
                Math.Round(rate, 2, MidpointRounding.AwayFromZero),
                ordinals[ordinal]);
        }
    }
}
