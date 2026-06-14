namespace _008_DeleteControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDeleteControls_Click(object sender, EventArgs e)
        {
            // this.Controls[2].Dispose();

            //if (this.Controls["txtName"] != null)
            //    this.Controls["txtName"].Dispose();
            
            //int counter = this.Controls.Count;
            //while (counter > 0)
            //{
            //    counter--;
            //    this.Controls[counter].Dispose();
            //}

            int counter = this.Controls.Count;
            for (int i =0; i < counter-1; i++) // -1 to let the title showed
            {
                this.Controls[0].Dispose();
            }
        }
    }
}
