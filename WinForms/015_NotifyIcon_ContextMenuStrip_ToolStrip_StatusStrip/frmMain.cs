using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;

namespace _015_NotifyIcon_ContextMenuStrip_ToolStrip_StatusStrip
{
    public partial class frmMain : Form
    {
        string[] _Files = null;
        TextBox txtContent = new TextBox();
        PictureBox picContent = new PictureBox();

        private void _HidePages()
        {
            pHomePage.Visible = false;
            txtContent.Visible = false;
            picContent.Visible = false;
        }
        private void _InitializeTextBox()
        {
            txtContent.Multiline = true;
            txtContent.BorderStyle = BorderStyle.None;
            txtContent.AllowDrop = true;
            txtContent.Dock = DockStyle.Fill;

            txtContent.DragEnter += txtContent_DragEnter;
            txtContent.DragDrop += txtContent_DragDrop;

            panelContent.Controls.Add(txtContent);
        }
        private void _InitializePictureBox()
        {
            picContent.BorderStyle = BorderStyle.None;
            picContent.AllowDrop = true;
            picContent.Dock = DockStyle.Fill;
            picContent.SizeMode = PictureBoxSizeMode.StretchImage;

            picContent.DragEnter += picContent_DragEnter;
            picContent.DragDrop += picContent_DragDrop;

            panelContent.Controls.Add(picContent);
        }
       private bool IsValidTextFile()
        {
            // later
            return false;
        }
        private bool IsValidImageFile()
        {
            // later
            return false;
        }
        private bool IsValidSoundFile()
        {
            // later
            return false;
        }
        public frmMain()
        {
            InitializeComponent();

            _InitializeTextBox();
            _InitializePictureBox();     
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Buttons_Click(object sender, EventArgs e)
        {
            if (sender == tsBtnHome)
            {
                pHomePage.Visible = true;
                txtContent.Visible = false;
                picContent.Visible = false;
                stLblPage.Text = "Home Page";
                tsLblHints.Text = "";
            }
            else if (sender == tsBtnTxtFile)
            {
                _HidePages();
                txtContent.Visible = true;
                stLblPage.Text = tsBtnTxtFile.Text;
                tsLblHints.Text = "Drag drop a text file to view!";    
            }
            else if (sender == tsBtnImageFiles)
            {
                _HidePages();
                picContent.Visible = true;
                stLblPage.Text = tsBtnImageFiles.Text;
                tsLblHints.Text = "Drag drop an image file to view!";    
            }
            else if (sender == tsBtnSoundFiles)
            {
                _HidePages();
                stLblPage.Text = tsBtnSoundFiles.Text;
                tsLblHints.Text = "Drag drop a sound file to view!";
            }
            else
                stLblPage.Text = "";
        }
        private void txtContent_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
                return;

            _Files = (string[])e.Data.GetData(DataFormats.FileDrop);
            if (Path.GetExtension(_Files[0]).ToLower() == ".txt" && _Files.Length == 1)
            {
                e.Effect = DragDropEffects.All;
            }
        }
        private void txtContent_DragDrop(object sender, DragEventArgs e)
        {
            FileInfo file = new FileInfo(_Files[0]);
            txtContent.Text = File.ReadAllText(_Files[0]);
            stLblFileInfo.Text = $" Name : {file.Name}  | Size : {file.Length} bytes";
        }
        private void picContent_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
                return;

            _Files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string strEx = Path.GetExtension(_Files[0]).ToLower();
            if ((strEx == ".jpg" || strEx == ".png") && _Files.Length == 1)
            {
                e.Effect = DragDropEffects.All;
            }
        }
        private void picContent_DragDrop(object sender, DragEventArgs e)
        {
            FileInfo file = new FileInfo(_Files[0]);
            picContent.Image = Image.FromFile(_Files[0]);
            stLblFileInfo.Text = $" Name : {file.Name}  | Size : {file.Length} bytes";
        }
        private void linkTextFiles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Buttons_Click(tsBtnTxtFile, EventArgs.Empty);
            tsBtnTxtFile.PerformClick();
        }
        private void linkImageFiles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Buttons_Click(tsBtnImageFiles, EventArgs.Empty);
            tsBtnImageFiles.PerformClick();
        }
        private void linkSoundFiles_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Buttons_Click(tsBtnSoundFiles, EventArgs.Empty);
            tsBtnSoundFiles.PerformClick();
        }
    }
}
