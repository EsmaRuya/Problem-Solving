using _022_Draw.Properties;
using System.ComponentModel;

namespace _022_Draw
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDrawLine_Click(object sender, EventArgs e)
        {
            Point p1 = new Point(100, 50);
            Point p2 = new Point(300, 50);

            this.CreateGraphics().DrawLine(Pens.Red, p1, p2);
        }
        private void btnDrawShapes_Click(object sender, EventArgs e)
        {
            // Traingle
            this.CreateGraphics().DrawLine(Pens.Blue, 200, 100, 300, 200);
            this.CreateGraphics().DrawLine(Pens.Blue, 100, 200, 300, 200);
            this.CreateGraphics().DrawLine(Pens.Blue, 200, 100, 100, 200);

            // Square
            this.CreateGraphics().DrawLine(Pens.Blue, 100, 250, 300, 250);
            this.CreateGraphics().DrawLine(Pens.Blue, 100, 400, 300, 400);
            this.CreateGraphics().DrawLine(Pens.Blue, 100, 250, 100, 400);
            this.CreateGraphics().DrawLine(Pens.Blue, 300, 250, 300, 400);
        }
        private void btnDrawZ_Click(object sender, EventArgs e)
        {
            // Lettre Z
            Point p1 = new Point(350, 50);
            Point p2 = new Point(500, 50);
            Point p3 = new Point(500, 50);
            Point p4 = new Point(350, 200);
            Point p5 = new Point(350, 200);
            Point p6 = new Point(500, 200);

            Point[] allPoints = { p1, p2, p3, p4, p5, p6 };

            this.CreateGraphics().DrawLines(Pens.Brown, allPoints);
        }
        private void btnDrawRectangle_Click(object sender, EventArgs e)
        {
            this.CreateGraphics().DrawRectangle(Pens.Violet, 350, 250, 150, 80);

            this.CreateGraphics().DrawRectangle(Pens.Green, 350, 350, 150, 50);
        }
        private void btnDrawTable_Click(object sender, EventArgs e)
        {
            Rectangle rec1 = new Rectangle(550, 50, 250, 30);
            Rectangle rec2 = new Rectangle(550, 50, 50, 200);
            Rectangle rec3 = new Rectangle(600, 50, 50, 180);
            Rectangle rec4 = new Rectangle(650, 50, 50, 180);
            Rectangle rec5 = new Rectangle(700, 50, 50, 180);
            Rectangle rec6 = new Rectangle(750, 50, 50, 180);
            Rectangle rec7 = new Rectangle(600, 230, 200, 20);

            Rectangle[] allRec = { rec1, rec2, rec3, rec4, rec5, rec6, rec7 };

            this.CreateGraphics().DrawRectangles(Pens.Pink, allRec);

        }
        private void btnDrawEllipses_Click(object sender, EventArgs e)
        {
            this.CreateGraphics().DrawEllipse(Pens.Brown, 100, 420, 300, 300);
            this.CreateGraphics().DrawEllipse(Pens.YellowGreen, 120, 440, 260, 260);
            this.CreateGraphics().DrawEllipse(Pens.Red, 140, 460, 220, 220);
        }
        private void btnDrawCylinder_Click(object sender, EventArgs e)
        {
            this.CreateGraphics().DrawEllipse(Pens.Black, 580, 280, 200, 100);

            this.CreateGraphics().DrawLine(Pens.Black, 580, 322, 580, 600);
            this.CreateGraphics().DrawLine(Pens.Black, 780, 322, 780, 600);
            this.CreateGraphics().DrawLine(Pens.Black, 580, 600, 780, 600);
        }
        private void btnDrawPie_Click(object sender, EventArgs e)
        {
            this.CreateGraphics().DrawPie(Pens.Gray, 850, 50, 200, 200, 0, 90);
        }
        private void nud_ValueChanged(object sender, EventArgs e)
        {
            this.CreateGraphics().DrawPie(Pens.Gray, 850, 300, 200, 200, 0, (float)nud.Value);
        }
        private void btnDrawPolygon_Click(object sender, EventArgs e)
        {
            // Points should be in order
            Point p1 = new Point(850, 590);
            Point p2 = new Point(900, 550);
            Point p3 = new Point(900, 570);
            Point p4 = new Point(1000, 570);
            Point p5 = new Point(1000, 610);
            Point p6 = new Point(900, 610);
            Point p7 = new Point(900, 630);
            Point[] allPoint = { p1, p2, p3, p4, p5, p6, p7 };

            this.CreateGraphics().DrawPolygon(Pens.DeepPink, allPoint);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.CreateGraphics().Clear(Color.White);
            lblCount.Visible = false;
        }
        private void btnDrawString_Click(object sender, EventArgs e)
        {
            string str = textString.Text;
            Font font = new Font("Tahoma", 24, FontStyle.Bold);
            Point p = new Point(450, 620);

            this.CreateGraphics().DrawString(str, font, Brushes.Red, p);
        }
        private void btnDrawImage_Click(object sender, EventArgs e)
        {
            Image img = Resources.Esma_Rüya;
            Point p = new Point(50, 20);
            this.CreateGraphics().DrawImage(img, p);
        }
        private void btnFillShapes_Click(object sender, EventArgs e)
        {
            this.CreateGraphics().Clear(Color.White);

            // Rec with border
            this.CreateGraphics().DrawRectangle(Pens.Red, 99, 50, 301, 201);
            this.CreateGraphics().FillRectangle(Brushes.Pink, 100, 51, 300, 200);

            // Rec without border
            this.CreateGraphics().FillRectangle(Brushes.Purple, 100, 270, 300, 200);

            // Pie
            this.CreateGraphics().FillPie(Brushes.YellowGreen, 150, 500, 200, 200, 10, 320);

            // Circle
            this.CreateGraphics().FillPie(Brushes.Blue, 500, 350, 200, 200, 0, 360);

            // Polygon
            Point p1 = new Point(450, 200);
            Point p2 = new Point(550, 100);
            Point p3 = new Point(550, 150);
            Point p4 = new Point(700, 150);
            Point p5 = new Point(700, 250);
            Point p6 = new Point(550, 250);
            Point p7 = new Point(550, 300);
            Point[] allPoint = { p1, p2, p3, p4, p5, p6, p7 };
            this.CreateGraphics().FillPolygon(Brushes.LightBlue, allPoint);
        }

        Label lblCount = new Label();
        Point p = new Point(800, 315);

        private void btnLoad_Click(object sender, EventArgs e)
        {
            double percentage;
            lblCount.Visible = true;
            lblCount.Text = "0";

            this.CreateGraphics().Clear(Color.White);

            this.CreateGraphics().DrawRectangle(Pens.Blue, 500, 300, 600, 50);
            this.CreateGraphics().FillRectangle(Brushes.LightBlue, 501, 301, 599, 49);

            for (int i = 0; i < 600; i++)
            {
                percentage = (i / 600.0) * 100;
                lblCount.Text = $"{Math.Round(percentage)}%";
                lblCount.Update();

                for (int j = 0; j < 100; j++)
                {
                    this.CreateGraphics().FillRectangle(Brushes.Blue, 501, 301, i, 49);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblCount.Visible = false;
            lblCount.Text = "0";
            lblCount.BackColor = Color.LightBlue;
            lblCount.ForeColor = Color.Black;
            lblCount.Font = new Font("Tahoma", 12, FontStyle.Bold);
            lblCount.Location = p;
            lblCount.Width = 60;

            this.Controls.Add(lblCount);
        }
    }
}
