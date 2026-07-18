using System.Drawing.Drawing2D;

namespace _024_GraphicsClass2
{
    public partial class Form1 : Form
    {
        struct Employees
        {
            public string Name;
            public double Salary;
            public double Percentage;
            public int PieDegree;
        };

        public Form1()
        {
            InitializeComponent();
        }

        // Employess' Pie Chart 
        private double _GetTotalSalary(Employees[] employees)
        {
            double totaleSalary = 0;
            for (int i = 0; i < employees.Length; i++)
            {
                totaleSalary += employees[i].Salary;
            }
            return totaleSalary;
        }
        private double[] _GetPercentage(Employees[] employees)
        {
            double[] percentage = new double[4];
            double totaleSalary = _GetTotalSalary(employees);

            for (int i = 0; i < employees.Length; i++)
            {
                percentage[i] = Math.Round((employees[i].Salary / totaleSalary) * 100);
            }

            return percentage;
        }
        private int[] _GetPieDegree(Employees[] employees)
        {
            int[] pieDegree = new int[4];

            for (int i = 0; i < employees.Length; i++)
            {
                pieDegree[i] = (int)Math.Round(((employees[i].Percentage * 360) / 100));
            }

            return pieDegree;
        }
        private void _DrawPieChart(Employees[] employees)
        {
            this.CreateGraphics().FillPie(Brushes.DarkCyan, 100, 50, 400, 400, 0, employees[0].PieDegree);
            this.CreateGraphics().FillPie(Brushes.DarkOrange, 100, 50, 400, 400, employees[0].PieDegree, employees[1].PieDegree);
            this.CreateGraphics().FillPie(Brushes.DarkSeaGreen, 100, 50, 400, 400, employees[0].PieDegree + employees[1].PieDegree, employees[2].PieDegree);
            this.CreateGraphics().FillPie(Brushes.DarkViolet, 100, 50, 400, 400, employees[0].PieDegree + employees[1].PieDegree + employees[2].PieDegree, employees[3].PieDegree);
        }
        private Employees[] _GetEmployeesInfo()
        {
            Employees[] employees = new Employees[4];

            employees[0].Name = "Esma";
            employees[0].Salary = 25000;

            employees[1].Name = "Aicha";
            employees[1].Salary = 19000;

            employees[2].Name = "Mahammad";
            employees[2].Salary = 25000;

            employees[3].Name = "Ahmad";
            employees[3].Salary = 10000;


            double[] percentage = _GetPercentage(employees);
            employees[0].Percentage = percentage[0];
            employees[1].Percentage = percentage[1];
            employees[2].Percentage = percentage[2];
            employees[3].Percentage = percentage[3];


            int[] pieDegree = _GetPieDegree(employees);
            employees[0].PieDegree = pieDegree[0];
            employees[1].PieDegree = pieDegree[1];
            employees[2].PieDegree = pieDegree[2];
            employees[3].PieDegree = pieDegree[3];

            return employees;
        }
        private void btnEmployeesChart_Click(object sender, EventArgs e)
        {
            Employees[] employees = _GetEmployeesInfo();

            _DrawPieChart(employees);
        }

        // Fradient Fill Shapes
        private void _DrawGradientFillShapes()
        {
            Graphics g = this.CreateGraphics();

            Point startPoint = new Point(600, 0); 
            Point endPoint = new Point(1100, 0); 
            LinearGradientBrush gb1 = new LinearGradientBrush(startPoint, endPoint, Color.Blue, Color.LightBlue);
            g.FillRectangle(gb1, 600, 30, 500, 200);


            Point startPoint2 = new Point(0, 30);
            Point endPoint2 = new Point(0, 460);
            LinearGradientBrush gb2 = new LinearGradientBrush(startPoint2, endPoint2, Color.DarkGreen, Color.LightYellow);
            g.FillRectangle(gb2, 600, 240, 500, 200);

            //LinearGradientMode mode = LinearGradientMode.Vertical;
            //Rectangle rect = new Rectangle(600, 240, 400, 200);
            //LinearGradientBrush gb3 = new LinearGradientBrush(rect, Color.Green, Color.LightGreen, mode);
            //g.FillRectangle(gb3, 600, 240, 400, 200);
        }
        private void btnGradientShapes_Click(object sender, EventArgs e)
        {
            _DrawGradientFillShapes();
        }

        // Clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.CreateGraphics().Clear(Color.White);
        }

        // Exit
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
