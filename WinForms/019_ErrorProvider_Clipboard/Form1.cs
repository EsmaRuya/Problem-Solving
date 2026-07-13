namespace _019_ErrorProvider_Clipboard
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtContent.Text))
                Clipboard.SetText(txtContent.Text);
        }

        private void btnCut_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtContent.Text))
            {
                Clipboard.SetText(txtContent.Text);
                txtContent.Clear();
            }
        }

        private void btnPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
                txtContent.Text = Clipboard.GetText();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtContent.Clear();
        }

        private void btnClearClipBpard_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            txtContent.Clear();
        }

        private void txtContent_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContent.Text))
            {
                ep.SetError(txtContent, "Field is empty!");
                //  e.Cancel = true;
            }
            else
            {
                ep.SetError(txtContent, "");
            }
        }

        private void btnCopyimg_Click(object sender, EventArgs e)
        {
            if (pbImage.Image != null)
                Clipboard.SetImage(pbImage.Image);
        }

        private void btnCutimg_Click(object sender, EventArgs e)
        {
            if (pbImage.Image != null)
            {
                Clipboard.SetImage(pbImage.Image);
                pbImage.Image = null;
            }

        }

        private void btnPasteimg_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
                pbImage.Image = Clipboard.GetImage();
        }

        private void btnClearimg_Click(object sender, EventArgs e)
        {
            pbImage.Image = null;
        }

        private void btnClearClipboardimg_Click(object sender, EventArgs e)
        {
            Clipboard.Clear();
            pbImage.Image = null;
        }
    }
}
