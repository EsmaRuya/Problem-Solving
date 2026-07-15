namespace _021_Practice_Font
{
    public partial class Form1 : Form
    {
        Font font = new Font("Arial", 12, FontStyle.Regular);
        string _FontName = "";
        int _FontSize = 12;
        FontStyle _FontStyleBold = FontStyle.Regular;
        FontStyle _FontStyleUnderLine = FontStyle.Regular;
        FontStyle _FontStyleItalic = FontStyle.Regular;

        public Form1()
        {
            InitializeComponent();
        }
        private void _LoadFontsToComboBox()
        {
            cbFonts.Items.Clear();
            FontFamily[] fonts = FontFamily.Families;

            foreach (FontFamily f in fonts)
            {
                cbFonts.Items.Add(f.Name);
            }
            // cbFonts.DisplayMember = "Name";
        }
        private void _ChangeFont()
        {
            font = new Font(_FontName, _FontSize, _FontStyleBold | _FontStyleUnderLine | _FontStyleItalic);
            txtContent.Font = font;
        }
        private void _DefaultFont()
        {
            font = new Font("Arial", 12, FontStyle.Regular);
            txtContent.Font = font;

            nudFontSize.Value = 12;
            cbItalic.Checked = false;
            cbUnderLine.Checked = false;
            cbBold.Checked = false;
            lblFontName.Text = "Arial";

            foreach (string item in cbFonts.Items)
            {
                if (item == lblFontName.Text)
                {
                    cbFonts.SelectedItem = item;
                    break;
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblFontName.Text = "Arial";
            txtContent.ContextMenuStrip = cms;
            txtFileName.ContextMenuStrip = cms;
            cbFonts.ContextMenuStrip = cms;

            _LoadFontsToComboBox();

        }
        private void txtFileName_TextChanged(object sender, EventArgs e)
        {
            // Handle both if user type @ or if they paste a text contains @

            if (txtFileName.Text.Contains("@"))
                ep.SetError(txtFileName, "The file name shoudn't contain @ symbol");
            else
                ep.Clear();
        }
        private void txtFileName_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Prevents user to type @ but they can paste a text contains it

            //if (e.KeyChar == '@')
            //{
            //    e.Handled = true;
            //    ep.SetError(txtFileName, "The file name shoudn't contain @ symbol");
            //}
            //else
            //    ep.Clear();
        }
        private void txtFileName_KeyDown(object sender, KeyEventArgs e)
        {
            // Prevents user to paste a text contains @ but they can type it

            //if (Clipboard.GetText().Contains("@"))
            //{
            //    if (e.KeyCode == Keys.V && e.Control)
            //    {
            //        e.SuppressKeyPress = true;
            //        ep.SetError(txtFileName, "The file name shoudn't contain @ symbol");
            //    }
            //    else
            //        ep.Clear();
            //}
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContent.Text))
            {
                MessageBox.Show("File is empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Title = "Save file";
            saveFile.Filter = "Text Files | *.txt";
            saveFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            if (string.IsNullOrWhiteSpace(txtFileName.Text))
                saveFile.FileName = "Untiteled.txt";
            else
                saveFile.FileName = txtFileName.Text.Trim() + ".txt";

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                // Save Code
                MessageBox.Show("Saved");
            }

        }
        private void cbFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblFontName.Text = cbFonts.SelectedItem.ToString();
        }
        private void btnChangeFont_Click(object sender, EventArgs e)
        {
            _FontName = cbFonts.SelectedItem.ToString();
            _ChangeFont();
        }
        private void nudFontSize_ValueChanged(object sender, EventArgs e)
        {
            _FontSize = (int)nudFontSize.Value;
            _ChangeFont();
        }
        private void cbBold_CheckedChanged(object sender, EventArgs e)
        {
            if (cbBold.Checked)
            {
                _FontStyleBold = FontStyle.Bold;
                _ChangeFont();
            }
            else
            {
                _FontStyleBold = FontStyle.Regular;
                _ChangeFont();
            }
        }
        private void cbUnderLine_CheckedChanged(object sender, EventArgs e)
        {
            if (cbUnderLine.Checked)
            {
                _FontStyleUnderLine = FontStyle.Underline;
                _ChangeFont();
            }
            else
            {
                _FontStyleUnderLine = FontStyle.Regular;
                _ChangeFont();
            }
        }
        private void cbItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (cbItalic.Checked)
            {
                _FontStyleItalic = FontStyle.Italic;
                _ChangeFont();
            }
            else
            {
                _FontStyleItalic = FontStyle.Regular;
                _ChangeFont();
            }
        }
        private void btnDefault_Click(object sender, EventArgs e)
        {
            _DefaultFont();
        }
        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // later
        }
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // later
        }
        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // later
        }
        private void fontSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog f = new FontDialog();
            f.Font = txtContent.Font;

            if(f.ShowDialog() == DialogResult.OK)
            {
                _FontName = f.Font.Name;
                _FontSize = (int)f.Font.Size;
                _FontStyleBold = f.Font.Style;

                _ChangeFont();

                nudFontSize.Value = _FontSize;
                lblFontName.Text = _FontName;
                cbBold.Checked = f.Font.Style.HasFlag(FontStyle.Bold);
                cbItalic.Checked = f.Font.Style.HasFlag(FontStyle.Italic);
                cbUnderLine.Checked = f.Font.Style.HasFlag(FontStyle.Underline);
                cbFonts.SelectedItem = f.Font.Name;
            }
        }
    }
}
