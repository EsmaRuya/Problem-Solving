namespace _024_GraphicsClass2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEmployeesChart = new Button();
            btnGradientShapes = new Button();
            btnClear = new Button();
            btnExit = new Button();
            SuspendLayout();
            // 
            // btnEmployeesChart
            // 
            btnEmployeesChart.Location = new Point(9, 500);
            btnEmployeesChart.Name = "btnEmployeesChart";
            btnEmployeesChart.Size = new Size(281, 37);
            btnEmployeesChart.TabIndex = 0;
            btnEmployeesChart.Text = "Employee's Chart";
            btnEmployeesChart.UseVisualStyleBackColor = true;
            btnEmployeesChart.Click += btnEmployeesChart_Click;
            // 
            // btnGradientShapes
            // 
            btnGradientShapes.Location = new Point(295, 500);
            btnGradientShapes.Name = "btnGradientShapes";
            btnGradientShapes.Size = new Size(281, 37);
            btnGradientShapes.TabIndex = 1;
            btnGradientShapes.Text = "Gradient Shapes";
            btnGradientShapes.UseVisualStyleBackColor = true;
            btnGradientShapes.Click += btnGradientShapes_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(581, 500);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(281, 37);
            btnClear.TabIndex = 2;
            btnClear.Text = "Clear Screen";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(867, 500);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(281, 37);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1165, 569);
            Controls.Add(btnExit);
            Controls.Add(btnClear);
            Controls.Add(btnGradientShapes);
            Controls.Add(btnEmployeesChart);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Graphics";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEmployeesChart;
        private Button btnGradientShapes;
        private Button btnClear;
        private Button btnExit;
    }
}
