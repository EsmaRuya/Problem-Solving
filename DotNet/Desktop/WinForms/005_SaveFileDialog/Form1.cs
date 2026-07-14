namespace _005_SaveFileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save Notes";
            sfd.Filter = "Text Files (*.txt)|*.txt";
            sfd.FileName = txtBox_FileName.Text;
            sfd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if(sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, txtNotes.Text); 
                MessageBox.Show("File will be saved to: \n" + sfd.FileName, "Save Notes");
                txtNotes.Text = "";
            }
            else
            {
                MessageBox.Show("Save operation canceled.");
            }
        }
    }
}
