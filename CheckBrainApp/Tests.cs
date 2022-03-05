using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckBrainApp
{
    public class Tests
    {
        static string pathstr = CheckBrainApp.Properties.Settings.Default.Test;
        public static List<string> TestPaths = pathstr.Split(';').ToList();
    }
}
