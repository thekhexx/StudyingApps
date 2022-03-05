using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBrainApp
{
    public static class TimeToTest
    {
        private static DateTime time = new DateTime();

        public static void AddToTime(int seconds)
        {
            DateTime time1 = new DateTime();

            time = time1.AddSeconds(seconds);
        }

        public static DateTime Time { get => time; set => time = value; }
    }
}
