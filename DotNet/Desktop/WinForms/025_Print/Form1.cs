namespace _025_Print
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string txtBody = txtContent.Text;
            Font txtFont = new Font("Tahoma", 20, FontStyle.Bold);

            // 1 - Print a page (with margins for Wrapping text)
            /*
            e.Graphics.DrawString(txtBody,
                                   txtFont,
                                   Brushes.Red,
                                   e.MarginBounds);
            */

            // 2 - Alignment text
            /*
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            e.Graphics.DrawString(txtBody,
                                   txtFont,
                                   Brushes.Red,
                                   e.MarginBounds,
                                   stringFormat);
            */

            // 3 - Measure string 
            /*
            txtFont = new Font("arial", 12, FontStyle.Regular);
            SizeF txtSize = e.Graphics.MeasureString(txtBody, txtFont);
            MessageBox.Show($"Width : {txtSize.Width} \n" +
                            $"Height : {txtSize.Height}");
            */

            // 4 - Print images
            /*
            Image img = Image.FromFile("myPic.png");
            e.Graphics.DrawImage(img,
                                 100, 100,
                                 400, 400);
            */

            // 5 - Print Text & Image 
            /* 
            Image img = Image.FromFile("myPic.png");
            int x = 100,
               y = 100,
               textWidth = 400,
               textHeight = 700,
               imageWidth = 200,
               imageHeight = 200,
               spacing = 20;
               Rectangle rect = new Rectangle(x, y, textWidth, textHeight);
               SizeF txtSize = e.Graphics.MeasureString(txtBody, txtFont, rect.Size);

              // [Text]  [Image]
              e.Graphics.DrawString(txtBody, txtFont,
                                    Brushes.Violet,
                                    rect);
              e.Graphics.DrawImage(img,
                                   x + txtSize.Width + spacing,
                                   y,
                                   imageWidth, imageHeight);

              // [Image] [Text]  
              rect = new Rectangle(x + imageWidth + spacing, 
                                  y, 
                                  textWidth,
                                  textHeight);
              txtSize = e.Graphics.MeasureString(txtBody, txtFont, rect.Size);

              e.Graphics.DrawImage(img,
                                   x,
                                   y,
                                   imageWidth, imageHeight);
              e.Graphics.DrawString(txtBody, txtFont,
                                    Brushes.Violet,
                                    rect);

               // [Image]
              // [Text]  
              rect = new Rectangle(x,
                                  y + imageHeight + spacing,
                                  e.MarginBounds.Width + 50,
                                  e.MarginBounds.Height);
              txtSize = e.Graphics.MeasureString(txtBody, txtFont, rect.Size);

              e.Graphics.DrawImage(img,
                                   x,
                                   y,
                                   imageWidth, imageHeight);

              e.Graphics.DrawString(txtBody, txtFont,
                                    Brushes.Violet,
                                    rect);

               // [Text] 
               // [Image]
               rect = new Rectangle(x,
                                    y,
                                    e.MarginBounds.Width + 50,
                                    e.MarginBounds.Height);
               txtSize = e.Graphics.MeasureString(txtBody, txtFont, rect.Size);

               e.Graphics.DrawString(txtBody, txtFont,
                                     Brushes.Violet,
                                     rect);
               e.Graphics.DrawImage(img,
                                    x,
                                    y + txtSize.Height + spacing,
                                    imageWidth,
                                    imageHeight);
          */

            // 6 - PageBounds vs MarginBounds
            /*
            MessageBox.Show("Margin : " + e.MarginBounds.ToString()); // x = 100 , y = 100 , width = 627 , height = 969
            MessageBox.Show("Page : " + e.PageBounds.ToString()); // // x = 0 , y = 0 , width = 827 , height = 1169
            */

            // 7 - Headers & Footers
            /*
            string header = "Header", footer = "Footer";
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            Font headerFont = new Font("Tahoma", 36, FontStyle.Bold | FontStyle.Italic);
            SizeF headerSize = e.Graphics.MeasureString(header, headerFont);
            SizeF footerSize = e.Graphics.MeasureString(footer, headerFont);
            Rectangle rect = new Rectangle(e.MarginBounds.Left,
                                           e.MarginBounds.Top + (int)headerSize.Height + 20,
                                           e.MarginBounds.Width,
                                           e.MarginBounds.Height - (int)headerSize.Height - 20);

            e.Graphics.DrawString(header,
                                  headerFont,
                                  Brushes.Red,
                                  e.MarginBounds,
                                  stringFormat);

            e.Graphics.DrawString(txtBody,
                                   txtFont,
                                   Brushes.Maroon,
                                   rect);

            int xFooter = (int) (e.MarginBounds.Left + ((e.MarginBounds.Width - headerSize.Width) / 2)); // to center footer

            e.Graphics.DrawString(footer,
                                  headerFont,
                                  Brushes.Blue,
                                  xFooter,
                                  e.MarginBounds.Bottom);
            */
        
            // 8 - 
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContent.Text))
            {
                MessageBox.Show("No Text to print!");
                return;
            }

            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }
    }
}
