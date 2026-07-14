namespace _017_ImageList
{
    public partial class frmMain : Form
    {
        private Form? _CurrentForm;
        public frmMain()
        {
            InitializeComponent();
        }

        private void tvForms_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Form? frm = null;
            string strForm = tvForms.SelectedNode.Text.ToLower();

            if (strForm == "home") frm = new frmHome();
            else if (strForm == "people")  frm = new frmPeople(); 
            else if (strForm == "users") frm = new frmUsers();
            else if (strForm == "settings")  frm = new frmSettings();  
            else if (strForm == "data") frm = new frmData();
            else Application.Exit();

            frm.MdiParent = this;
            frm.Dock = DockStyle.Fill;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.AutoScroll = true;

            if (_CurrentForm?.GetType() == frm.GetType()) return;
           
            _CurrentForm?.Close();  // if (_CurrentForm != null)  _CurrentForm.Close();

            frm.Show();
            _CurrentForm = frm;

        }
    }
}
