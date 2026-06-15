namespace _009_Timer_NumericUpDown_TrackBar_Color
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            txtExerciceName = new TextBox();
            label3 = new Label();
            cbDifficulty = new ComboBox();
            nudDurationInMin = new NumericUpDown();
            label4 = new Label();
            timer = new System.Windows.Forms.Timer(components);
            lblCounterDown = new Label();
            btnStart = new Button();
            btnStop = new Button();
            btnCancel = new Button();
            linkChangeBgColor = new LinkLabel();
            label5 = new Label();
            nudDurationInSec = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudDurationInMin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDurationInSec).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Gabriola", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(142, 9);
            label1.Name = "label1";
            label1.Size = new Size(237, 50);
            label1.TabIndex = 0;
            label1.Text = "Workout Session Timer";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 73);
            label2.Name = "label2";
            label2.Size = new Size(118, 21);
            label2.TabIndex = 1;
            label2.Text = "Exercise Name :";
            // 
            // txtExerciceName
            // 
            txtExerciceName.Location = new Point(148, 69);
            txtExerciceName.Name = "txtExerciceName";
            txtExerciceName.Size = new Size(340, 29);
            txtExerciceName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 114);
            label3.Name = "label3";
            label3.Size = new Size(79, 21);
            label3.TabIndex = 3;
            label3.Text = "Difficulty :";
            // 
            // cbDifficulty
            // 
            cbDifficulty.FormattingEnabled = true;
            cbDifficulty.Items.AddRange(new object[] { "Easy", "Medium", "Hard" });
            cbDifficulty.Location = new Point(148, 110);
            cbDifficulty.Name = "cbDifficulty";
            cbDifficulty.Size = new Size(121, 29);
            cbDifficulty.TabIndex = 4;
            // 
            // nudDurationInMin
            // 
            nudDurationInMin.Location = new Point(182, 151);
            nudDurationInMin.Name = "nudDurationInMin";
            nudDurationInMin.Size = new Size(58, 29);
            nudDurationInMin.TabIndex = 5;
            nudDurationInMin.Value = new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(24, 155);
            label4.Name = "label4";
            label4.Size = new Size(148, 21);
            label4.TabIndex = 6;
            label4.Text = "Duration (minutes) :";
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // lblCounterDown
            // 
            lblCounterDown.AutoSize = true;
            lblCounterDown.Font = new Font("Segoe UI", 40F);
            lblCounterDown.Location = new Point(142, 186);
            lblCounterDown.Name = "lblCounterDown";
            lblCounterDown.Size = new Size(228, 72);
            lblCounterDown.TabIndex = 7;
            lblCounterDown.Text = "00:00:00";
            // 
            // btnStart
            // 
            btnStart.Location = new Point(24, 268);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(228, 35);
            btnStart.TabIndex = 10;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnStop
            // 
            btnStop.Enabled = false;
            btnStop.Location = new Point(260, 268);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(228, 35);
            btnStop.TabIndex = 11;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(255, 192, 192);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = Color.Red;
            btnCancel.Location = new Point(24, 309);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(464, 33);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // linkChangeBgColor
            // 
            linkChangeBgColor.AutoSize = true;
            linkChangeBgColor.LinkColor = Color.DodgerBlue;
            linkChangeBgColor.Location = new Point(152, 354);
            linkChangeBgColor.Name = "linkChangeBgColor";
            linkChangeBgColor.Size = new Size(192, 21);
            linkChangeBgColor.TabIndex = 13;
            linkChangeBgColor.TabStop = true;
            linkChangeBgColor.Text = "Change Background Color";
            linkChangeBgColor.LinkClicked += linkChangeBgColor_LinkClicked;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(246, 155);
            label5.Name = "label5";
            label5.Size = new Size(148, 21);
            label5.TabIndex = 15;
            label5.Text = "Duration (seconds) :";
            // 
            // nudDurationInSec
            // 
            nudDurationInSec.Location = new Point(404, 151);
            nudDurationInSec.Name = "nudDurationInSec";
            nudDurationInSec.Size = new Size(58, 29);
            nudDurationInSec.TabIndex = 14;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(531, 393);
            Controls.Add(label5);
            Controls.Add(nudDurationInSec);
            Controls.Add(linkChangeBgColor);
            Controls.Add(btnCancel);
            Controls.Add(btnStop);
            Controls.Add(btnStart);
            Controls.Add(lblCounterDown);
            Controls.Add(label4);
            Controls.Add(nudDurationInMin);
            Controls.Add(cbDifficulty);
            Controls.Add(label3);
            Controls.Add(txtExerciceName);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudDurationInMin).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDurationInSec).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtExerciceName;
        private Label label3;
        private ComboBox cbDifficulty;
        private NumericUpDown nudDurationInMin;
        private Label label4;
        private System.Windows.Forms.Timer timer;
        private Label lblCounterDown;
        private Button btnStart;
        private Button btnStop;
        private Button btnCancel;
        private LinkLabel linkChangeBgColor;
        private Label label5;
        private NumericUpDown nudDurationInSec;
    }
}
