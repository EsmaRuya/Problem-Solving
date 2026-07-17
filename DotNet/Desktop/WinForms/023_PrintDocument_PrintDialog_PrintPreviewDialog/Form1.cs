using System.Drawing.Printing;

namespace _023_PrintDocument_PrintDialog_PrintPreviewDialog
{
    public partial class Form1 : Form
    {
        int _CurrentChar = 0;
        int _PageNumber = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void _SetDocumentToDialogs()
        {
            printDialog.Document = printDocument;
            printPreviewDialog.Document = printDocument;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            _SetDocumentToDialogs();
        }
        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font titleFont = new Font("tahoma", 18, FontStyle.Bold);
            Font txtFont = txtContent.Font;

            string title = "Mini Notepad";
            string txt = txtContent.Text;
            string date = DateTime.Now.ToShortDateString();

            // Header
            SizeF dateSize = e.Graphics.MeasureString(date, txtFont);
            float xDate = e.MarginBounds.Right - dateSize.Width;

            e.Graphics.DrawString(date, txtFont, Brushes.Black, xDate, 30);
            e.Graphics.DrawString(title, titleFont, Brushes.Black, 50, 60);

            // Body
            RectangleF rec = new RectangleF(e.MarginBounds.Left,
                                            e.MarginBounds.Top + 20,
                                            e.MarginBounds.Width,
                                            e.MarginBounds.Height);

            string remainingText = txt.Substring(_CurrentChar);
            int charactersFitted, linesFitted;

            e.Graphics.MeasureString(remainingText,
                                     txtFont,
                                     rec.Size,
                                     StringFormat.GenericDefault,
                                     out charactersFitted,
                                     out linesFitted);

            string pageText = remainingText.Substring(0,charactersFitted);

            e.Graphics.DrawString(pageText, txtFont, Brushes.Black, rec);

            // Footer
            string pageNumber = $"Page {_PageNumber}";
            SizeF PageNumsize = e.Graphics.MeasureString(pageNumber, txtFont);

            e.Graphics.DrawString(pageNumber,
                                  txtFont,
                                  Brushes.Black,
                                  e.MarginBounds.Right - PageNumsize.Width,
                                  e.MarginBounds.Bottom + 40);

            _CurrentChar += charactersFitted;

            if(_CurrentChar < txt.Length)
            {
                e.HasMorePages = true;
                _PageNumber++;
            }
            else
            {
                e.HasMorePages = false;
                _CurrentChar = 0;
                _PageNumber = 1;
            }
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContent.Text))
                MessageBox.Show("Nothing to print!", "Empty File!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            else if(printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
        private void btnPreview_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContent.Text))
                MessageBox.Show("Nothing to preview!", "Empty File!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
                printPreviewDialog.ShowDialog();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
