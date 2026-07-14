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
                treeView.Nodes.Clear();

                string[] files = Directory.GetFiles(folderBrowserDialog.SelectedPath);
                string[] folders = Directory.GetDirectories(folderBrowserDialog.SelectedPath);

                foreach (string folder in folders)
                {
                    TreeNode node = treeView.Nodes.Add(Path.GetFileName(folder));

                     files = Directory.GetFiles(folder);

                    foreach (string file in files)
                    {
                        node.Nodes.Add(Path.GetFileName(file));
                    }
                }   

                if (rbFiles.Checked)
                {
                    foreach (string file in files)
                    {
                        lvShowData.Items.Add(Path.GetFileName(file)).SubItems.Add(file);
                     //   treeView.Nodes.Add(Path.GetFileName(file));
                    }
                }
                else
                {
                    foreach (string folder in folders)
                    {
                        lvShowData.Items.Add(Path.GetFileName(folder)).SubItems.Add(folder);
                       // treeView.Nodes.Add(Path.GetFileName(folder));
                    }
                }
            }
        }
    }
}
