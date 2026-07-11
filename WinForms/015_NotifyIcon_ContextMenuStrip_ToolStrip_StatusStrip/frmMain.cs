using System.Drawing.Drawing2D;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Windows.Forms;
using System.Media;

namespace _015_NotifyIcon_ContextMenuStrip_ToolStrip_StatusStrip
{
    public partial class frmMain : Form
    {
        SoundPlayer sp = new SoundPlayer();
        FileInfo _txtFile;
        FileInfo _ImgFile;
        FileInfo _SoundFile;
        string[] _Files = null;
        TextBox txtContent = new TextBox();
        PictureBox picContent = new PictureBox();
        Panel pnlSound = new Panel();
        Button btnStop = new Button();
        Button btnPlay = new Button();
        private void _HidePages()
        {
            pHomePage.Visible = false;
            txtContent.Visible = false;
            picContent.Visible = false;
            pnlSound.Visible = false;
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
        private void _InitializePanel()
        {
            pnlSound.AllowDrop = true;
            pnlSound.Dock = DockStyle.Fill;
            pnlSound.BorderStyle = BorderStyle.None;

            pnlSound.DragEnter += pnlSound_DragEnter;
            pnlSound.DragDrop += pnlSound_DragDrop;

            panelContent.Controls.Add(pnlSound);
        }
        private void _InitializeButton()
        {
            btnPlay.Text = "Play";
            btnPlay.Size = new Size(80, 40);
            btnPlay.Top = 10;
            btnPlay.Left = 10;
            btnPlay.BackColor = Color.LightGray;

            btnStop.Text = "Stop";
            btnStop.Size = new Size(80, 40);
            btnStop.Top = 60;
            btnStop.Left = 10;
            btnStop.BackColor = Color.LightGray;

            btnStop.Click += btnStop_Click;
            btnPlay.Click += btnPlay_Click;

            pnlSound.Controls.Add(btnStop);
            pnlSound.Controls.Add(btnPlay);
        }
       private void _UpdateFileInfo(FileInfo file)
        {
            if (file == null)
                stLblFileInfo.Text = "";
            else
                stLblFileInfo.Text = $" Name : {file.Name}  | Size : {file.Length} bytes";
        }
        private bool _IsValidTextFile()
        {
            // later
            return false;
        }
        private bool _IsValidImageFile()
        {
            // later
            return false;
        }
        private bool _IsValidSoundFile()
        {
            // later
            return false;
        }
        public frmMain()
        {
            InitializeComponent();

            _InitializeTextBox();
            _InitializePictureBox();
            _InitializePanel();
            _InitializeButton();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void closeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtContent.Clear();
            picContent.Image = null;
            stLblFileInfo.Text = "";
            _txtFile = null;
            _ImgFile = null;
            _SoundFile = null;
        }
        private void fileInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(stLblFileInfo.Text);

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
                stLblFileInfo.Text = "";
            }
            else if (sender == tsBtnTxtFile)
            {
                _HidePages();
                txtContent.Visible = true;
                stLblPage.Text = tsBtnTxtFile.Text;
                tsLblHints.Text = "Drag drop a text file to view!";
                _UpdateFileInfo(_txtFile);
            }
            else if (sender == tsBtnImageFiles)
            {
                _HidePages();
                picContent.Visible = true;
                stLblPage.Text = tsBtnImageFiles.Text;
                tsLblHints.Text = "Drag drop an image file to view!";
                _UpdateFileInfo(_ImgFile);
            }
            else if (sender == tsBtnSoundFiles)
            {
                _HidePages();
                pnlSound.Visible = true;
                stLblPage.Text = tsBtnSoundFiles.Text;
                tsLblHints.Text = "Drag drop a sound file to view!";
                _UpdateFileInfo(_SoundFile);
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
            _txtFile = new FileInfo(_Files[0]);
            txtContent.Text = File.ReadAllText(_Files[0]);
            stLblFileInfo.Text = $" Name : {_txtFile.Name}  | Size : {_txtFile.Length} bytes";
            closeFileToolStripMenuItem.Enabled = true;
            fileInfoToolStripMenuItem.Enabled = true;
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
            _ImgFile = new FileInfo(_Files[0]);
            picContent.Image = Image.FromFile(_Files[0]);
            stLblFileInfo.Text = $" Name : {_ImgFile.Name}  | Size : {_ImgFile.Length} bytes";
            closeFileToolStripMenuItem.Enabled = true;
            fileInfoToolStripMenuItem.Enabled = true;
        }
        private void pnlSound_DragEnter(object sender, DragEventArgs e)
        {
            if (!e.Data.GetDataPresent(DataFormats.FileDrop))
                return;

            _Files = (string[])e.Data.GetData(DataFormats.FileDrop);
            string strEx = Path.GetExtension(_Files[0]).ToLower();
            if ((strEx == ".wav") && _Files.Length == 1)
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void pnlSound_DragDrop(object sender, DragEventArgs e)
        {
            sp.Stop();
            sp.SoundLocation = _Files[0];
            sp.Play();

            _SoundFile = new FileInfo(_Files[0]);

            stLblFileInfo.Text = $" Name : {_SoundFile.Name}  | Size : {_SoundFile.Length} bytes";
            closeFileToolStripMenuItem.Enabled = true;
            fileInfoToolStripMenuItem.Enabled = true;
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            sp.Stop();
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            sp.Play();
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
