using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CipherApplication
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            pathTextBox.Text = Properties.Settings.Default.ArchivePath;
            extractTextBox.Text = Properties.Settings.Default.ExtractPath;
        }

        private void setButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = ".zip|*.zip";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pathTextBox.Text = dialog.FileName;
            }

        }

        private void applyChangesButton_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private void SaveChanges()
        {
            try
            {
                if (Properties.Settings.Default.ArchivePath != pathTextBox.Text)
                {
                    Properties.Settings.Default.ArchivePath = pathTextBox.Text;
                }
                if (Properties.Settings.Default.ExtractPath != extractTextBox.Text)
                {
                    Properties.Settings.Default.ExtractPath = extractTextBox.Text;
                }
                Properties.Settings.Default.Save();
                MessageBox.Show("Changes saved successfully!");
            }
            catch (Exception exc)
            {

                MessageBox.Show(exc.Message);
            }
        }

        private void cancelAndExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveAndExitButton_Click(object sender, EventArgs e)
        {
            SaveChanges();
            this.Close();
        }

        private void setExtractPathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                extractTextBox.Text = dialog.SelectedPath;
            }
        }
    }
}
