using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBrainApp.Forms
{
    public partial class SplashScreen : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
        (
        int nLeftRect,
        int nTopRect,
        int RightRect,
        int nBottomRect,
        int nWidthEllipse,
        int nHeightEllipse
        );
        public SplashScreen()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            progressBarLoading.Value = 0;
        }

        async void CheckFiles()
        {
            Task.Run(() => Existing());
        }

        void Existing()
        {
            try
            {
                bool flag = false;
                StringBuilder @string = new StringBuilder("Отсутствуют следущие файлы: \n");
                foreach (string item in Theories.TheoryPaths)
                {
                    bool exist = File.Exists(Environment.CurrentDirectory + @"\" + item);
                    if (!exist)
                    {
                        timerLoading.Stop();
                        @string.Append(item + "\n");
                        flag = true;

                    }
                }
                if (flag)
                {
                    @string.Append("Не гарантируется правильная работа программы. Хотите продолжить работу?");
                    throw new Exception(@string.ToString());
                }
                

            }
            catch (Exception ex)
            {

                if (MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.DialogResult = DialogResult.Abort;
                }

                Thread.Sleep(1);
            }
            
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            CheckFiles();

        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            progressBarLoading.Value++;
            lblPercent.Text = progressBarLoading.Value.ToString() + "%";

            if (progressBarLoading.Value == 100)
            {
                timerLoading.Enabled = false;
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
        }
    }
}
