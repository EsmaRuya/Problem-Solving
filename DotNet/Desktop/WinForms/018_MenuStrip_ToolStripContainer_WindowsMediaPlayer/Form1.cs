using System.IO;

namespace _018_MenuStrip_ToolStripContainer_WindowsMediaPlayer
{
    public partial class Form1 : Form
    {
      //  WMPLib.WindowsMediaPlayer wmp = new WMPLib.WindowsMediaPlayer();

        public Form1()
        {
            InitializeComponent();
        }
        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Title = "Selet File";
            file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);

            if (file.ShowDialog() == DialogResult.OK)
            {
                txtMediaPath.Text = file.FileName;
                //wmp.URL = txtMediaPath.Text;
                //wmp.settings.autoStart = false;
                axWMP.settings.autoStart = false;
                axWMP.URL = txtMediaPath.Text;
            }
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
           // wmp.controls.play();
            axWMP.Ctlcontrols.play();
        }
        private void btnPause_Click(object sender, EventArgs e)
        {
            // wmp.controls.pause();
            axWMP.Ctlcontrols.pause();
        }
        private void btnStop_Click(object sender, EventArgs e)
        {
            // wmp.controls.stop();
            axWMP.Ctlcontrols.stop();
        }
        private void btnPlayInLoop_Click(object sender, EventArgs e)
        {
            // wmp.settings.setMode("loop", true);
            axWMP.settings.setMode("loop", true);
        }

    }
}
