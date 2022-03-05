using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CipherApplication.Controls
{
    public partial class FilesList : UserControl
    {
        private string fileName;
        private string weight;
        private Image icon;

        public string FileName { get => fileName; set => fileName = value; }
        public string Weight { get => weight; set => weight = value; }
        public Image Icon { get => icon; set => icon = value; }

        public FilesList()
        {
            InitializeComponent();
        }

    }
}
