using System.Diagnostics;
using System.IO;

namespace _012_ProcessClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool isProgramExist(string program)
        {
            return File.Exists(Path.Combine(Environment.SystemDirectory, program));
        }
        private void _OpenItem(string path)
        {
            try
            {
                if (!Directory.Exists(path) && !File.Exists(path) && !isProgramExist(path))
                {
                    MessageBox.Show($"This path : \"{path}\" isn't valid!");
                    return;
                }
                else
                {
                    Process.Start(new ProcessStartInfo
                    {
                        FileName = path,
                        UseShellExecute = true
                    });
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
          
        }

        private void btnOpenTestFolder_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, @"..\..\..\Test");
            _OpenItem(path);
        }

        private void btnOpenPicture_Click(object sender, EventArgs e)
        {

            string path = Path.Combine(Application.StartupPath, @"..\..\..\Test\EsmaRuya.png");
            _OpenItem(path);
        }

        private void btnOpenFilManagerApp_Click(object sender, EventArgs e)
        {
                string path = Path.Combine(Application.StartupPath, @"..\..\..\Test\FileManager.exe");
               _OpenItem(path); 
        }

        private void btnOpenPersonDataApp_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, @"..\..\..\Test\PersonData.exe");
            MessageBox.Show(path);
            _OpenItem(path); 
        }

        private void btnOpenBook_Click(object sender, EventArgs e)
        {

                string path = Path.Combine(Application.StartupPath, @"..\..\..\Test\Test.pdf");
                _OpenItem(path);
        }

        private void btnOpenTestFile_Click(object sender, EventArgs e)
        {
           
           string path = Path.Combine(Application.StartupPath, @"..\..\..\Test\Test.txt");
            _OpenItem(path);

        }
        private void btnOpenHTMLpage_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, @"..\..\..\Test\Test.html");
            _OpenItem(path);
        }

        private void btnOpenCalculator_Click(object sender, EventArgs e)
        {
            _OpenItem("calc.exe");
        }

        private void btnOpenCdrive_Click(object sender, EventArgs e)
        {
            _OpenItem(@"C:\");
        }

        private void brnBrowser_Click(object sender, EventArgs e)
        {
            try
            {
                string path = txtPath.Text;

                if (!Directory.Exists(path) && !File.Exists(path))
                {
                    MessageBox.Show($"This path : \"{path}\" isn't valid!");
                    return;
                }
                else
                    _OpenItem(path);

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
