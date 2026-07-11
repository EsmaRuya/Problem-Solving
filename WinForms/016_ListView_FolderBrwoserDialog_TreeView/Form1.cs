using System.IO;

namespace _016_ListView_FolderBrwoserDialog_TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrwoser_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            

            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                lvShowData.Items.Clear();
                string[] data;

                if (rbFiles.Checked)
                {
                    data = Directory.GetFiles(folderBrowserDialog.SelectedPath);

                    foreach (string dataItem in data)
                    {
                        lvShowData.Items.Add(Path.GetFileName(dataItem)).SubItems.Add(dataItem);
                    }
                }
                else
                {
                    data = Directory.GetDirectories(folderBrowserDialog.SelectedPath);

                    foreach (string dataItem in data)
                    {
                        lvShowData.Items.Add(Path.GetFileName(dataItem)).SubItems.Add(dataItem);
                    }
                }
            }
        }
    }
}
