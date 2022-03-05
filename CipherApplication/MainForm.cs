using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Text.RegularExpressions;
using System.Runtime.InteropServices;

namespace CipherApplication
{
    public partial class MainForm : Form
    {
        private String filepath;
        private String extension;
        private string IV;
        private string cipheredFile;
        string filename = "";
        string fileExtention = "";
        OpenFileDialog dialog = new OpenFileDialog();
        public MainForm()
        {
            InitializeComponent();
            filesListView.SmallImageList = iconList;
            
        }

       

        private void pickFileButtonOnClick(object sender, EventArgs e)
        {
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("File: " + dialog.FileName, "Confirm", MessageBoxButtons.YesNo);
                this.filepath = dialog.FileName;
                pickedFileLabel.Text = "File is picked: " + dialog.SafeFileName;
            }
        }

        private void saveFileButtonOnClick(object sender, EventArgs e)
        {
            //savefile
            SaveToZip();
            LoadFilesFromArchiveToList();


        }
        private bool CheckArchivePath()
        {
            if (String.IsNullOrEmpty(Properties.Settings.Default.ArchivePath))
            {
                if (MessageBox.Show("Archive path is empty. Do you want set path in settings?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes) ;
                {
                    OpenSettings();
                }
                return false;
            }
            return true;
        }

        private void SaveToZip()
        {
            Directory.CreateDirectory(Directory.GetCurrentDirectory() + "\\Ciphered\\");
            string cipheredPath = Directory.GetCurrentDirectory() + "\\Ciphered\\" + filename + fileExtention;
            File.WriteAllText(cipheredPath, cipheredFile);
            if (CheckArchivePath())
            {
                Zip.SaveFileToZip(cipheredPath, dialog.SafeFileName, Properties.Settings.Default.ArchivePath);
            }
            File.Delete(cipheredPath);
        }

        //enscrypt
        private void enscryptFile()
        {
            IV = ivBox.Text;
            String result = "";
            //cipher mode CFB
            byte[] modeResult = null;
            String mode = "CFB";
            //check input file
            if (dialog.FileName.Equals("dialog"))
            {
                MessageBox.Show("You must pick file at first", "Message", MessageBoxButtons.OK);
                return;
            }
            //validate key and IV
            Regex reg = new Regex("^[a-zA-Z0-9]*$");
            //key.length >= 8-byte
            if (keyBox.Text.Length < 8)
            {
                MessageBox.Show("Key size must be 64-bit", "Message", MessageBoxButtons.OK);
                return;
            }
            else if (!reg.IsMatch(keyBox.Text))
            {
                MessageBox.Show("Key must contain only digits or letters", "Message", MessageBoxButtons.OK);
                return;
            }
            else
            {
                if (IVCheckBox.Checked == false)
                {
                    IV = IVector.GetUniqueKey(keyBox.Text.Length);
                }
                //IV.length = key.length
                if ((IV.Length != keyBox.Text.Length))
                {
                    MessageBox.Show("Inicialization Vector must be equal key", "Message", MessageBoxButtons.OK);
                    return;
                }
                else if ((IV.Contains(".")))
                {
                    MessageBox.Show("IV must not contain \".\"", "Message", MessageBoxButtons.OK);
                    return;
                }
            }
            //read file content (plaintext)
            String dialogfilename = dialog.FileName;
            byte[] plain = System.IO.File.ReadAllBytes(dialogfilename);
            CFB cfb = new CFB(plain, null, keyBox.Text, IV);
            modeResult = cfb.encrypt();
            result = ByteArrayToString(modeResult);
            //set header
            filename = Path.GetFileNameWithoutExtension(filepath);
            fileExtention = Path.GetExtension(filepath);
            result += "." + IV + "." + filename + fileExtention + "." + mode + "." + (keyBox.Text.Length - (plain.Length % keyBox.Text.Length)).ToString();
            outputTextBox.Text = result;
            cipheredFile = result;

        }

        private void cipherButtonOnClick(object sender, EventArgs e)
        {
            if (dialog.FileName.Equals(""))
            {
                MessageBox.Show("File is not selected");
            }
            else if (String.IsNullOrEmpty(keyBox.Text))
            {
                MessageBox.Show("Key field is empty!");
            }
            else
            {
                enscryptFile();
                SaveToZip();
                LoadFilesFromArchiveToList();
            }
            
        }


        //dekripsi
        private void descryptFileButtonOnClick(object sender, EventArgs e)
        {
            //header variable
            String iv;
            int padding;
            byte[] content = new byte[1];
            String mode = "";

            //instead of keyBox.Text use this
            String newKey = keyBox.Text;

            //result for each mode
            byte[] modeResult = new byte[keyBox.Text.Length];

            //validate input file
            //if (dialog.FileName.Equals("dialog"))
            //{
            //    MessageBox.Show("You should pick up file at first", "Message", MessageBoxButtons.OK);
            //    return;
            //}

            //validasi kunci
            //key.length >= 8-byte
            if (keyBox.Text.Length < 8)
            {
                MessageBox.Show("Key size must be 64-bit", "Message", MessageBoxButtons.OK);
                return;
            }
            try
            {
                //read file content (cipher)
                Zip.ExtractFilesFromZip(filesListView.FocusedItem.Text, Properties.Settings.Default.ArchivePath, Directory.GetCurrentDirectory() + "\\Ciphered\\");
                String dialogfilename = Directory.GetCurrentDirectory() + "\\Ciphered\\" + filesListView.FocusedItem.Text;
                //String dialogfilename = dialog.FileName;
                String cipher = System.IO.File.ReadAllText(dialogfilename);
                string result = "";
                //no need for iv

                //get header
                String[] header = cipher.Split('.');
                if (header.Length != 6)
                {
                    MessageBox.Show("This file can't be descrypted", "Message", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    filepath = header[2];
                    iv = header[1];
                    mode = header[4];
                    padding = Int32.Parse(header[5]);
                    content = StringToByteArray(header[0]);
                    extension = header[3];

                    //validate key 
                    if (mode.Equals("CFB"))
                    {
                        //CFB mode
                        CFB cfb = new CFB(null, content, keyBox.Text, iv);
                        byte[] pbytes = cfb.decrypt();
                        outputTextBox.Text = ByteArrayToString(pbytes);

                        if (extension.Equals("txt"))
                        {
                            //show plaintext if using text extension
                            result += Environment.NewLine + Environment.NewLine + Encoding.ASCII.GetString(pbytes);
                            outputTextBox.Text += result;
                        }
                        else
                        {


                        }
                        SaveFileDialog dialogFile = new SaveFileDialog();
                        dialogFile.Filter = extension + "|*." + extension;
                        //savefile
                        if (MessageBox.Show("Do you want save it?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            if (dialogFile.ShowDialog() == DialogResult.OK)
                            {
                                System.IO.File.WriteAllBytes(dialogFile.FileName, pbytes);
                            }
                            MessageBox.Show(dialogFile.FileName);
                        }
                        File.Delete(Directory.GetCurrentDirectory() + "\\Ciphered\\" + filepath + "." + extension);
                    }
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
           
        }

        private String ByteArrayToString(byte[] b)
        {
            StringBuilder hex = new StringBuilder(b.Length * 2);
            foreach (byte a in b)
            {
                hex.AppendFormat("{0:x2}", a);
            }
            return hex.ToString();
        }

        private byte[] StringToByteArray(String hex)
        {
            int NumberChars = hex.Length;
            byte[] bytes = new byte[NumberChars / 2];
            for (int i = 0; i < NumberChars; i += 2)
                bytes[i / 2] = Convert.ToByte(hex.Substring(i, 2), 16);
            return bytes;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadFilesFromArchiveToList();
        }
        private void LoadFilesFromArchiveToList()
        {
            try
            {
                filesListView.Items.Clear();
                List<string> files = Zip.GetZipFiles(Properties.Settings.Default.ArchivePath);
                foreach (string file in files)
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = file;
                    string exstention = file.Remove(0, file.LastIndexOf("."));
                    switch (exstention)
                    {
                        case ".exe":
                            item.ImageIndex = 0;
                            break;
                        case ".png":
                            item.ImageIndex = 3;
                            break;
                        case ".jpg":
                            item.ImageIndex = 3;
                            break;
                        case ".gif":
                            item.ImageIndex = 3;
                            break;
                        case ".txt":
                            item.ImageIndex = 4;
                            break;
                        case ".mp3":
                            item.ImageIndex = 2;
                            break;
                        case ".mp4":
                            item.ImageIndex = 5;
                            break;
                        default:
                            item.ImageIndex = 0;
                            break;
                    }
                    filesListView.Items.Add(item);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hello! At first you must set path to execution folder and archive path!");
            }
           
        }

        

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            PostMessage(this.Handle, WM_SYSCOMMAND, DOMOVE, 0);
        }
        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool PostMessage(IntPtr hWnd, uint Msg, uint WParam, uint LParam);

        [DllImport("user32", CharSet = CharSet.Auto)]
        internal extern static bool ReleaseCapture();
        const uint WM_SYSCOMMAND = 0x0112;
        const uint DOMOVE = 0xF012;
        const uint DOSIZE = 0xF008;

        private void settingsButton_Click(object sender, EventArgs e)
        {
            OpenSettings();
        }

        private void OpenSettings()
        {
            Form form = new SettingsForm();
            form.ShowDialog();
        }

        private void IVCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (IVCheckBox.Checked == true)
            {
                ivBox.Enabled = true;
            }
            else
            {
                ivBox.Enabled = false;
            }
        }

        private void filesListView_ItemActivate(object sender, EventArgs e)
        {
        }

        private void filesListView_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void extractFileButton_Click(object sender, EventArgs e)
        {
            Zip.ExtractFilesFromZip(Properties.Settings.Default.ArchivePath, Properties.Settings.Default.ExtractPath);
        }

        private void filesListView_MouseClick(object sender, MouseEventArgs e)
        {
                if (e.Button == MouseButtons.Right)
                {
                    var focusedItem = filesListView.FocusedItem;
                    if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                    {
                        itemContextMenu.Show(Cursor.Position);
                    }
                }
            
        }
        private bool CheckExtractPath()
        {
            if (String.IsNullOrEmpty(Properties.Settings.Default.ExtractPath))
            {
                if (MessageBox.Show("Extracting directory is empty! Do you want set it?", "Message", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    OpenSettings();
                }
                return false;
            }
            return true;
        }

        private void extractCurrentFileButton_Click(object sender, EventArgs e)
        {
            if (CheckExtractPath())
            {
                Zip.ExtractFilesFromZip(filesListView.FocusedItem.Text, Properties.Settings.Default.ArchivePath, Properties.Settings.Default.ExtractPath);
            }
            
        }
    }
}
