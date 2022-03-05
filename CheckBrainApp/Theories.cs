using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBrainApp
{
    public class Theories
    {
        static string pathstr = CheckBrainApp.Properties.Settings.Default.Theory1;
        public static List<string> TheoryPaths = pathstr.Split(';').ToList();
    }
}
