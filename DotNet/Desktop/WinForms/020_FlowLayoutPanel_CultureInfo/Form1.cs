using System.Globalization;
using System.IO;

namespace _020_FlowLayoutPanel_CultureInfo
{
    public partial class Form1 : Form
    {
        CultureInfo cultureInfo = CultureInfo.GetCultureInfo("ar-MA"); // language-region                                                         
        OpenFileDialog file = new OpenFileDialog();
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }
        private void _SetOpenFileDialog()
        {  
            file.Title = "Select Image";
            file.Multiselect = true;
            file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        }
        private void _SetCulturesIntoComboBox()
        {
            CultureInfo[] AllC = CultureInfo.GetCultures(CultureTypes.AllCultures);

            foreach (CultureInfo c in AllC)
            {
                cbCultures.Items.Add(c);
            }
            cbCultures.DisplayMember = "EnglishName";
        }
        private void _SetData()
        {
            // Formatting
            lblTime.Text = "Time : " + DateTime.Now.ToString("T", cultureInfo);
            lblDate.Text = DateTime.Now.ToString("D", cultureInfo);


            // Culture Name
            lblName.Text = "Name : " + cultureInfo.Name; // unique culture identifier
            lblEnglishName.Text = "English Name : " + cultureInfo.EnglishName; // CultureName-Region
            lblNativeName.Text = "Native Name : " + cultureInfo.NativeName; // CultureName-Region
            lblCultureName.Text = "Culture Name :" + cultureInfo.DisplayName; // user-friendly name
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _SetCulturesIntoComboBox();

            foreach (CultureInfo c in cbCultures.Items)
            {
                if (c.Name == "ar-MA")
                {
                    cbCultures.SelectedItem = c;
                    break;
                }
            }

            _SetData();
            _SetOpenFileDialog();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            lblTime.Text = "Time : " + DateTime.Now.ToString("T", cultureInfo);
        }
        private void btnFormatNumbers_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtNumbers.Text))
            {
                double num = Convert.ToDouble(txtNumbers.Text);
                txtNumbers.Text = num.ToString("N", cultureInfo);
            }
        }
        private void cbCultures_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbCultures.SelectedItem != null)
            {
                cultureInfo = (CultureInfo)cbCultures.SelectedItem;
                _SetData();
            }
        }
        private void btnAddImage_Click(object sender, EventArgs e)
        {
            if (file.ShowDialog() == DialogResult.OK)
            {
                //if (pb1.Image == null)
                //    pb1.Image = Image.FromFile(file.FileName);
                //else if (pb2.Image == null)
                //    pb2.Image = Image.FromFile(file.FileName);
                //else if (pb3.Image == null)
                //    pb3.Image = Image.FromFile(file.FileName);
                //else if (pb4.Image == null)
                //    pb4.Image = Image.FromFile(file.FileName);
                //else if (pb5.Image == null)
                //    pb5.Image = Image.FromFile(file.FileName);
                //else if (pb6.Image == null)
                //    pb6.Image = Image.FromFile(file.FileName);
                //else if (pb7.Image == null)
                //    pb7.Image = Image.FromFile(file.FileName);
                //else if (pb8.Image == null)
                //    pb8.Image = Image.FromFile(file.FileName);
                //else if (pb9.Image == null)
                //    pb9.Image = Image.FromFile(file.FileName);
                //else if (pb10.Image == null)
                //    pb10.Image = Image.FromFile(file.FileName);
                //else if (pb11.Image == null)
                //    pb11.Image = Image.FromFile(file.FileName);
                //else if (pb12.Image == null)
                //    pb12.Image = Image.FromFile(file.FileName);
                //else if (pb13.Image == null)
                //    pb13.Image = Image.FromFile(file.FileName);
                //else if (pb14.Image == null)
                //    pb14.Image = Image.FromFile(file.FileName);
                //else
                //    return;

                foreach(string fileName in file.FileNames)
                {
                    if (count == 14)
                    {
                        MessageBox.Show("Your galarry is full!");
                        return;
                    }

                    foreach (Control ctrl in FLPanel.Controls)
                    {
                        if (ctrl is PictureBox pic && pic.Image == null)
                        {
                            pic.Image = Image.FromFile(fileName);
                            count++;
                            break;

                        }
                    }
                }   
                
            }   
        }
        private void btnClearGallary_Click(object sender, EventArgs e)
        {
            foreach(Control ctrl in FLPanel.Controls)
            {
                if(ctrl is PictureBox pb)
                {
                    pb.Image?.Dispose();
                    pb.Image = null;
                }    
            }
            count = 0;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
