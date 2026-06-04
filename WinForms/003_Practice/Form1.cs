using System.IO;
using System.Linq.Expressions;

namespace _003_Practice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool _isPersonIdExist(string ID)
        {
            StreamReader sr = new StreamReader("Data.txt");
            string strLine;
            while ((strLine = sr.ReadLine()) != null)
            {
                string[] arrLine = strLine.Split(';');
                if (arrLine[0] == ID)
                {
                    sr.Close();
                    return true;
                }
            }
            sr.Close();
            return false;
            //  if (strLine.Contains(txtBox_ID.Text + ";"))
            // return true;
        }

        private string[] _GetPersonData(string ID)
        {
            StreamReader sr = new StreamReader("Data.txt");
            string strLine;
            string[] arrLine;

            while ((strLine = sr.ReadLine()) != null)
            {
                arrLine = strLine.Split(';');
                if (arrLine[0] == ID)
                {
                    sr.Close();
                    return arrLine;
                }
            }
            sr.Close();
            return null;
        }
        private string _GetAllData()
        {
            // return File.ReadAllText("Data.txt");

            StreamReader sr = new StreamReader("Data.txt");
            string strData = sr.ReadToEnd();
            sr.Close();
            return strData;
        }

        private void _EmptyAllTextBoxes()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                    c.Text = "";
            }
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBox_ID.Text.Trim() == "" || txtBox_Name.Text.Trim() == "" || txtBox_Address.Text.Trim() == "")
                {
                    MessageBox.Show("Fields are emty! Enter all data.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (_isPersonIdExist(txtBox_ID.Text))
                {
                    MessageBox.Show("This ID is exist, please try new one!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    StreamWriter sw = new StreamWriter("Data.txt", true);

                    string strPersonData = txtBox_ID.Text + ";" +
                                 txtBox_Name.Text + ";" +
                                 txtBox_Address.Text;

                    sw.WriteLine(strPersonData);
                    sw.Close();

                    MessageBox.Show("Person is added successfully", "Add person", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtBox_ID.Focus();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtBox_ID.Text.Trim() != "")
                {
                    string[] arrData = _GetPersonData(txtBox_ID.Text);
                    if (arrData != null)
                    {
                        txtBox_ID.Text = arrData[0];
                        txtBox_Name.Text = arrData[1];
                        txtBox_Address.Text = arrData[2];
                    }
                    else
                    {
                        MessageBox.Show("This person ID doesn't exist!", "Not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // _EmptyAllTextBoxes();
                        txtBox_ID.Focus();
                        txtBox_ID.SelectAll();
                        txtBox_Name.Text = "";
                        txtBox_Address.Text = "";
                    }

                }
                else
                {
                    MessageBox.Show("Please enter ID to search for the person!", " lack of info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtBox_ID.Focus();
                    txtBox_ID.SelectAll();
                    txtBox_Name.Text = "";
                    txtBox_Address.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            TextBox txtBox = new TextBox();

            frm.StartPosition = FormStartPosition.CenterScreen;
            frm.Font = new Font(this.Font.Name,18);
            frm.Icon = this.Icon;
            frm.Size = this.Size * 2;
            frm.Text = "All data";

            txtBox.Multiline = true;
            txtBox.Dock = DockStyle.Fill;

            frm.Controls.Add(txtBox);
            try
            {
                txtBox.Text = _GetAllData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            frm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
           // this.Close();
            Application.Exit();
        }
    }
}
