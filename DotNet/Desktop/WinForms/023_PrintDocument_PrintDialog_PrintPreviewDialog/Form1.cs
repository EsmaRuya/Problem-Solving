using System.Drawing.Printing;

namespace _023_PrintDocument_PrintDialog_PrintPreviewDialog
{
    public partial class Form1 : Form
    {
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
            // Font font = new Font("Tahoma", 12, FontStyle.Regular);
            Font titleFont = new Font("tahoma", 18, FontStyle.Bold);
            Font txtFont = txtContent.Font;

            string title = "Mini Notepad";
            string txt = txtContent.Text;
            string date = DateTime.Now.ToShortDateString();

            SizeF size = e.Graphics.MeasureString(date, txtContent.Font);
            float xDate = e.MarginBounds.Right - size.Width;
            float yPageNumber = e.MarginBounds.Bottom;

            

             e.Graphics.DrawString(date, txtFont, Brushes.Black, xDate,30);
            e.Graphics.DrawString(title, titleFont, Brushes.Black, 50, 60);
            e.Graphics.DrawString(txt, txtFont, Brushes.Black, 50,130);
          e.Graphics.DrawString("1", txtFont, Brushes.Black, 50, yPageNumber);
            
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
