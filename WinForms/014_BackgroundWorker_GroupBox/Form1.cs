using System.ComponentModel;
using System.IO;

namespace _014_BackgroundWorker_GroupBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void _CopyData(string Source, string Destination, DoWorkEventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader(Source);
                StreamWriter sw = new StreamWriter(Destination);
                string? strLine;
                int progress = 0, count = 0;
                int lineCount = File.ReadLines(Source).Count();
                do
                {
                    if (bgWorker.CancellationPending)
                    {
                        e.Cancel = true;
                        break;
                    }

                    strLine = sr.ReadLine();

                    if (strLine != null)
                    {
                        sw.WriteLine(strLine);
                        count++;

                        progress = (int)((double)count / lineCount * 100);
                        bgWorker.ReportProgress(progress);
                    }    
                } while (strLine != null);

                sw.Close();
                sr.Close();  
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btnBrwoserS_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Title = "Select the source file";
                openFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    txtSourceFile.Text = openFile.FileName;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btnBrwoserD_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog fileDes = new SaveFileDialog();
                fileDes.Title = "Select the destination file";
                fileDes.FileName = "Untiteled.txt";
                fileDes.Filter = "Txt Files|*.txt";
                fileDes.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                if (fileDes.ShowDialog() == DialogResult.OK)
                {
                    txtDestination.Text = fileDes.FileName;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btnCopy_Click(object sender, EventArgs e)
        {
            bgWorker.RunWorkerAsync();
            lblStatus.Text = "Copying...";
        }
        private void bgWorker_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtDestination.Text) && !string.IsNullOrWhiteSpace(txtSourceFile.Text))
                _CopyData(txtSourceFile.Text, txtDestination.Text, e);
            else
                MessageBox.Show("Enter Source File & Destination File!");
        }
        private void bgWorker_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            pb.Value = e.ProgressPercentage;
            lblProgress.Text = pb.Value.ToString();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            bgWorker.CancelAsync();
        }
        private void bgWorker_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                lblStatus.Text = "Copying was cancelled.";
                MessageBox.Show("The copy operation was cancelled.", "Cancelled");
            }
            else if (e.Error != null)
            {
                lblStatus.Text = "An error occurred.";
                MessageBox.Show(e.Error.Message, "Error");
            }
            else
            {
                lblStatus.Text = "Done...";
                MessageBox.Show("Copying file is done successfully!", "Done");
            }
        }
        private void btnExist_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
