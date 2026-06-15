namespace _009_Timer_NumericUpDown_TrackBar_Color
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tbA = new TrackBar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbR = new TrackBar();
            label4 = new Label();
            tbB = new TrackBar();
            label5 = new Label();
            tbG = new TrackBar();
            txtA = new TextBox();
            label6 = new Label();
            label7 = new Label();
            txtR = new TextBox();
            label8 = new Label();
            txtG = new TextBox();
            label9 = new Label();
            txtB = new TextBox();
            btnSetColor = new Button();
            btnExit = new Button();
            toolTip1 = new ToolTip(components);
            ((System.ComponentModel.ISupportInitialize)tbA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbR).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbG).BeginInit();
            SuspendLayout();
            // 
            // tbA
            // 
            tbA.Enabled = false;
            tbA.Location = new Point(85, 143);
            tbA.Margin = new Padding(4);
            tbA.Maximum = 255;
            tbA.Name = "tbA";
            tbA.Size = new Size(575, 45);
            tbA.TabIndex = 0;
            tbA.TickStyle = TickStyle.Both;
            tbA.Value = 255;
            tbA.Scroll += tb_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(208, 9);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(292, 37);
            label1.TabIndex = 1;
            label1.Text = "Change Background Color";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label2.Location = new Point(49, 150);
            label2.Name = "label2";
            label2.Size = new Size(40, 30);
            label2.TabIndex = 2;
            label2.Text = "A :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label3.Location = new Point(49, 202);
            label3.Name = "label3";
            label3.Size = new Size(39, 30);
            label3.TabIndex = 4;
            label3.Text = "R :";
            // 
            // tbR
            // 
            tbR.Location = new Point(85, 195);
            tbR.Margin = new Padding(4);
            tbR.Maximum = 255;
            tbR.Name = "tbR";
            tbR.Size = new Size(575, 45);
            tbR.TabIndex = 3;
            tbR.TickStyle = TickStyle.Both;
            tbR.Scroll += tb_Scroll;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label4.Location = new Point(49, 301);
            label4.Name = "label4";
            label4.Size = new Size(38, 30);
            label4.TabIndex = 8;
            label4.Text = "B :";
            // 
            // tbB
            // 
            tbB.Location = new Point(85, 294);
            tbB.Margin = new Padding(4);
            tbB.Maximum = 255;
            tbB.Name = "tbB";
            tbB.Size = new Size(575, 45);
            tbB.TabIndex = 7;
            tbB.TickStyle = TickStyle.Both;
            tbB.Scroll += tb_Scroll;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label5.Location = new Point(49, 251);
            label5.Name = "label5";
            label5.Size = new Size(40, 30);
            label5.TabIndex = 6;
            label5.Text = "G :";
            // 
            // tbG
            // 
            tbG.Location = new Point(85, 244);
            tbG.Margin = new Padding(4);
            tbG.Maximum = 255;
            tbG.Name = "tbG";
            tbG.Size = new Size(575, 45);
            tbG.TabIndex = 5;
            tbG.TickStyle = TickStyle.Both;
            tbG.Scroll += tb_Scroll;
            // 
            // txtA
            // 
            txtA.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtA.Location = new Point(101, 73);
            txtA.Name = "txtA";
            txtA.ReadOnly = true;
            txtA.Size = new Size(59, 39);
            txtA.TabIndex = 9;
            txtA.Text = "255";
            txtA.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(53, 76);
            label6.Name = "label6";
            label6.Size = new Size(45, 32);
            label6.TabIndex = 10;
            label6.Text = "A :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(160, 76);
            label7.Name = "label7";
            label7.Size = new Size(44, 32);
            label7.TabIndex = 12;
            label7.Text = "R :";
            // 
            // txtR
            // 
            txtR.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtR.Location = new Point(208, 73);
            txtR.Name = "txtR";
            txtR.ReadOnly = true;
            txtR.Size = new Size(59, 39);
            txtR.TabIndex = 11;
            txtR.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(270, 76);
            label8.Name = "label8";
            label8.Size = new Size(45, 32);
            label8.TabIndex = 14;
            label8.Text = "G :";
            // 
            // txtG
            // 
            txtG.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtG.Location = new Point(318, 73);
            txtG.Name = "txtG";
            txtG.ReadOnly = true;
            txtG.Size = new Size(59, 39);
            txtG.TabIndex = 13;
            txtG.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(380, 76);
            label9.Name = "label9";
            label9.Size = new Size(43, 32);
            label9.TabIndex = 16;
            label9.Text = "B :";
            // 
            // txtB
            // 
            txtB.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtB.Location = new Point(428, 73);
            txtB.Name = "txtB";
            txtB.ReadOnly = true;
            txtB.Size = new Size(59, 39);
            txtB.TabIndex = 15;
            txtB.TextAlign = HorizontalAlignment.Center;
            // 
            // btnSetColor
            // 
            btnSetColor.BackColor = Color.DodgerBlue;
            btnSetColor.FlatStyle = FlatStyle.Flat;
            btnSetColor.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSetColor.ForeColor = Color.White;
            btnSetColor.Location = new Point(538, 26);
            btnSetColor.Name = "btnSetColor";
            btnSetColor.Size = new Size(122, 40);
            btnSetColor.TabIndex = 17;
            btnSetColor.Text = "Set Color";
            btnSetColor.UseVisualStyleBackColor = false;
            btnSetColor.Click += btnSetColor_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.DodgerBlue;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(538, 76);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(122, 40);
            btnExit.TabIndex = 18;
            btnExit.Text = "Exit";
            toolTip1.SetToolTip(btnExit, "Back to Timer");
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // toolTip1
            // 
            toolTip1.AutomaticDelay = 1000;
            toolTip1.AutoPopDelay = 100;
            toolTip1.InitialDelay = 1000;
            toolTip1.ReshowDelay = 200;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(715, 365);
            Controls.Add(btnExit);
            Controls.Add(btnSetColor);
            Controls.Add(label9);
            Controls.Add(txtB);
            Controls.Add(label8);
            Controls.Add(txtG);
            Controls.Add(label7);
            Controls.Add(txtR);
            Controls.Add(label6);
            Controls.Add(txtA);
            Controls.Add(label4);
            Controls.Add(tbB);
            Controls.Add(label5);
            Controls.Add(tbG);
            Controls.Add(label3);
            Controls.Add(tbR);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbA);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form2";
            Text = "Change Background Color";
            ((System.ComponentModel.ISupportInitialize)tbA).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbR).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbB).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbG).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar tbA;
        private Label label1;
        private Label label2;
        private Label label3;
        private TrackBar tbR;
        private Label label4;
        private TrackBar tbB;
        private Label label5;
        private TrackBar tbG;
        private TextBox txtA;
        private Label label6;
        private Label label7;
        private TextBox txtR;
        private Label label8;
        private TextBox txtG;
        private Label label9;
        private TextBox txtB;
        private Button btnSetColor;
        private Button btnExit;
        private ToolTip toolTip1;
    }
}