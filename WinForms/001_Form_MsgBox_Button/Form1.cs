using System.Windows.Forms;

namespace _001_Form_MsgBox_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDeleteFile_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the file?", "Delete File", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(result == DialogResult.Yes)
                MessageBox.Show("File deleted successfully", "Deleted");
            else
                MessageBox.Show("Operation canceled", "Not deleted");
            
        }
    }
}
