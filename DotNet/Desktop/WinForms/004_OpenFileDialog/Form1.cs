using System.Xml.XPath;

namespace _004_OpenFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChooseFile_Click(object sender, EventArgs e)
        {
            ofd.Title = "Open File";
            // ofd.InitialDirectory = "C:\\";
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            // ofd.Multiselect = true;
            ofd.Filter = "Images | *.png; *.jpg; *.jpeg";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtBox_Path.Text = ofd.FileName;
                txtBox_FileName.Text = Path.GetFileName(ofd.FileName);
                txtBox_FileExtension.Text = Path.GetExtension(ofd.FileName);

                MessageBox.Show("File selected successfully.");   
            }
            else
            {
                txtBox_Path.Text = "";
                txtBox_FileName.Text = "";
                txtBox_FileExtension.Text = "";

                MessageBox.Show("No file selected.");
            }
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
    }
}
