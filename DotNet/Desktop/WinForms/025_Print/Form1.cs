namespace _025_Print
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int currentChar = 0, pageNumber = 1;
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

            // 8 - Types of MeasureString
            /*
            SizeF s1 = e.Graphics.MeasureString(txtBody, txtFont); // Retrieve size of the text with no layout width (one line)
            
            SizeF s2 =  e.Graphics.MeasureString(txtBody, txtFont, e.MarginBounds.Width); // Retrieve size of the text in a layout (rectangle - wraps if needed)
            
            SizeF s3 =  e.Graphics.MeasureString(txtBody, txtFont, e.MarginBounds.Width, StringFormat.GenericDefault); // same as 2, it'll change if text formatting is changed
            StringFormat sf = new StringFormat();
           sf.Alignment = StringAlignment.Center;
            sf.FormatFlags = StringFormatFlags.NoWrap;
            SizeF s3_1 =  e.Graphics.MeasureString(txtBody, txtFont, e.MarginBounds.Width, sf); // Retrieve size of the text using the specified StringFormat

            Rectangle rect = new Rectangle(e.MarginBounds.Left,e.MarginBounds.Top, e.MarginBounds.Width, e.MarginBounds.Height);
            int charFitted = 0, linesFitted = 0;
            SizeF s4 = e.Graphics.MeasureString(txtBody, txtFont, rect.Size, StringFormat.GenericDefault, out charFitted, out linesFitted); // Retrieve size of the text inside the given rectangleSize & How many characters/lines fit in that area

            MessageBox.Show($"s1 : {s1}\n" +
                            $"s2 : {s2}\n" +
                            $"s3 : {s3}\n" +
                            $"s3_1 : {s3_1}\n" +
                            $"s4 : {s4}\nchar : {charFitted} - lines : {linesFitted}");

           e.Graphics.DrawString(txtBody,txtFont,Brushes.Black, rect, sf);
           */

            
            // 9 - Print many pages
            
            string header = "Header";
            Font headerFont = new Font("Tahoma", 36, FontStyle.Bold | FontStyle.Italic);
            SizeF headerSize = e.Graphics.MeasureString(header, headerFont);
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            e.Graphics.DrawString(header,
                                  headerFont,
                                  Brushes.Red,
                                  e.MarginBounds,
                                  stringFormat);



            Rectangle rect = new Rectangle(e.MarginBounds.Left,
                                           e.MarginBounds.Top + (int)headerSize.Height,
                                           e.MarginBounds.Width,
                                           e.MarginBounds.Height - (int)headerSize.Height);
            int charactersFitted = 0, linesFitted = 0;
            string textPage = "", remainingText = "";
            remainingText = txtBody.Substring(currentChar); // retrieve a text begins with currentChar
            e.Graphics.MeasureString(remainingText, txtFont, rect.Size, StringFormat.GenericDefault, out charactersFitted, out linesFitted); // retrieve characters + lines Fitted
            textPage = remainingText.Substring(0, charactersFitted);
            currentChar += charactersFitted;
            e.Graphics.DrawString(textPage, txtFont, Brushes.Maroon, rect);

           
            string footer = pageNumber++.ToString();
            Font footerFont = new Font("Tahoma", 12, FontStyle.Bold);
            SizeF footerSize = e.Graphics.MeasureString(footer, footerFont);
            e.Graphics.DrawString(footer,
                                  footerFont,
                                  Brushes.Blue,
                                  e.MarginBounds.Right - 50,
                                  e.MarginBounds.Bottom + 30);


            if (currentChar < txtBody.Length)
                e.HasMorePages = true;
            else
            {
                e.HasMorePages = false;
                currentChar = 0;
                pageNumber = 1;
            }
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
