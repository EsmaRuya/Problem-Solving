namespace _022_Draw
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
            btnDrawLine = new Button();
            btnDrawShapes = new Button();
            btnDrawZ = new Button();
            panel1 = new Panel();
            nud = new NumericUpDown();
            btnDrawPie = new Button();
            btnDrawCylinder = new Button();
            btnDrawEllipses = new Button();
            btnDrawTable = new Button();
            btnDrawRectangle = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nud).BeginInit();
            SuspendLayout();
            // 
            // btnDrawLine
            // 
            btnDrawLine.Location = new Point(7, 4);
            btnDrawLine.Margin = new Padding(4);
            btnDrawLine.Name = "btnDrawLine";
            btnDrawLine.Size = new Size(96, 32);
            btnDrawLine.TabIndex = 0;
            btnDrawLine.Text = "Line";
            btnDrawLine.UseVisualStyleBackColor = true;
            btnDrawLine.Click += btnDrawLine_Click;
            // 
            // btnDrawShapes
            // 
            btnDrawShapes.Location = new Point(111, 4);
            btnDrawShapes.Margin = new Padding(4);
            btnDrawShapes.Name = "btnDrawShapes";
            btnDrawShapes.Size = new Size(96, 32);
            btnDrawShapes.TabIndex = 1;
            btnDrawShapes.Text = "Shapes";
            btnDrawShapes.UseVisualStyleBackColor = true;
            btnDrawShapes.Click += btnDrawShapes_Click;
            // 
            // btnDrawZ
            // 
            btnDrawZ.Location = new Point(215, 4);
            btnDrawZ.Margin = new Padding(4);
            btnDrawZ.Name = "btnDrawZ";
            btnDrawZ.Size = new Size(96, 32);
            btnDrawZ.TabIndex = 2;
            btnDrawZ.Text = "Z";
            btnDrawZ.UseVisualStyleBackColor = true;
            btnDrawZ.Click += btnDrawZ_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(nud);
            panel1.Controls.Add(btnDrawPie);
            panel1.Controls.Add(btnDrawCylinder);
            panel1.Controls.Add(btnDrawEllipses);
            panel1.Controls.Add(btnDrawTable);
            panel1.Controls.Add(btnDrawRectangle);
            panel1.Controls.Add(btnDrawZ);
            panel1.Controls.Add(btnDrawLine);
            panel1.Controls.Add(btnDrawShapes);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 502);
            panel1.Name = "panel1";
            panel1.Size = new Size(1023, 85);
            panel1.TabIndex = 3;
            // 
            // nud
            // 
            nud.Location = new Point(838, 6);
            nud.Maximum = new decimal(new int[] { 360, 0, 0, 0 });
            nud.Name = "nud";
            nud.Size = new Size(53, 29);
            nud.TabIndex = 4;
            nud.ValueChanged += nud_ValueChanged;
            // 
            // btnDrawPie
            // 
            btnDrawPie.Location = new Point(735, 4);
            btnDrawPie.Margin = new Padding(4);
            btnDrawPie.Name = "btnDrawPie";
            btnDrawPie.Size = new Size(96, 32);
            btnDrawPie.TabIndex = 7;
            btnDrawPie.Text = "Pie";
            btnDrawPie.UseVisualStyleBackColor = true;
            btnDrawPie.Click += btnDrawPie_Click;
            // 
            // btnDrawCylinder
            // 
            btnDrawCylinder.Location = new Point(631, 4);
            btnDrawCylinder.Margin = new Padding(4);
            btnDrawCylinder.Name = "btnDrawCylinder";
            btnDrawCylinder.Size = new Size(96, 32);
            btnDrawCylinder.TabIndex = 6;
            btnDrawCylinder.Text = "Cylinder";
            btnDrawCylinder.UseVisualStyleBackColor = true;
            btnDrawCylinder.Click += btnDrawCylinder_Click;
            // 
            // btnDrawEllipses
            // 
            btnDrawEllipses.Location = new Point(527, 4);
            btnDrawEllipses.Margin = new Padding(4);
            btnDrawEllipses.Name = "btnDrawEllipses";
            btnDrawEllipses.Size = new Size(96, 32);
            btnDrawEllipses.TabIndex = 5;
            btnDrawEllipses.Text = "Ellipses";
            btnDrawEllipses.UseVisualStyleBackColor = true;
            btnDrawEllipses.Click += btnDrawEllipses_Click;
            // 
            // btnDrawTable
            // 
            btnDrawTable.Location = new Point(423, 4);
            btnDrawTable.Margin = new Padding(4);
            btnDrawTable.Name = "btnDrawTable";
            btnDrawTable.Size = new Size(96, 32);
            btnDrawTable.TabIndex = 4;
            btnDrawTable.Text = "Table";
            btnDrawTable.UseVisualStyleBackColor = true;
            btnDrawTable.Click += btnDrawTable_Click;
            // 
            // btnDrawRectangle
            // 
            btnDrawRectangle.Location = new Point(319, 4);
            btnDrawRectangle.Margin = new Padding(4);
            btnDrawRectangle.Name = "btnDrawRectangle";
            btnDrawRectangle.Size = new Size(96, 32);
            btnDrawRectangle.TabIndex = 3;
            btnDrawRectangle.Text = "Rectangle";
            btnDrawRectangle.UseVisualStyleBackColor = true;
            btnDrawRectangle.Click += btnDrawRectangle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1023, 587);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)nud).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnDrawLine;
        private Button btnDrawShapes;
        private Button btnDrawZ;
        private Panel panel1;
        private Button btnDrawRectangle;
        private Button btnDrawTable;
        private Button btnDrawEllipses;
        private Button btnDrawCylinder;
        private Button btnDrawPie;
        private NumericUpDown nud;
    }
}
