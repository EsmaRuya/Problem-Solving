namespace _014_BackgroundWorker_GroupBox
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
            label1 = new Label();
            label2 = new Label();
            txtSourceFile = new TextBox();
            btnBrwoserS = new Button();
            btnBrwoserD = new Button();
            txtDestination = new TextBox();
            label3 = new Label();
            label4 = new Label();
            pb = new ProgressBar();
            lblProgress = new Label();
            label5 = new Label();
            lblStatus = new Label();
            btnCopy = new Button();
            btnCancel = new Button();
            bgWorker = new System.ComponentModel.BackgroundWorker();
            panel = new Panel();
            btnExist = new Button();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 16F);
            label1.Location = new Point(269, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(175, 32);
            label1.TabIndex = 0;
            label1.Text = "Text File Copier";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 93);
            label2.Name = "label2";
            label2.Size = new Size(89, 21);
            label2.TabIndex = 1;
            label2.Text = "Source File:";
            // 
            // txtSourceFile
            // 
            txtSourceFile.Location = new Point(129, 89);
            txtSourceFile.Name = "txtSourceFile";
            txtSourceFile.Size = new Size(421, 29);
            txtSourceFile.TabIndex = 2;
            // 
            // btnBrwoserS
            // 
            btnBrwoserS.Location = new Point(577, 89);
            btnBrwoserS.Name = "btnBrwoserS";
            btnBrwoserS.Size = new Size(123, 29);
            btnBrwoserS.TabIndex = 3;
            btnBrwoserS.Text = "Brwoser";
            btnBrwoserS.UseVisualStyleBackColor = true;
            btnBrwoserS.Click += btnBrwoserS_Click;
            // 
            // btnBrwoserD
            // 
            btnBrwoserD.Location = new Point(577, 132);
            btnBrwoserD.Name = "btnBrwoserD";
            btnBrwoserD.Size = new Size(123, 29);
            btnBrwoserD.TabIndex = 6;
            btnBrwoserD.Text = "Brwoser";
            btnBrwoserD.UseVisualStyleBackColor = true;
            btnBrwoserD.Click += btnBrwoserD_Click;
            // 
            // txtDestination
            // 
            txtDestination.Location = new Point(129, 132);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(421, 29);
            txtDestination.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 136);
            label3.Name = "label3";
            label3.Size = new Size(92, 21);
            label3.TabIndex = 4;
            label3.Text = "Destination:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(14, 180);
            label4.Name = "label4";
            label4.Size = new Size(74, 21);
            label4.TabIndex = 7;
            label4.Text = "Progress:";
            // 
            // pb
            // 
            pb.Location = new Point(129, 176);
            pb.Name = "pb";
            pb.Size = new Size(421, 29);
            pb.Step = 1;
            pb.TabIndex = 8;
            // 
            // lblProgress
            // 
            lblProgress.AutoSize = true;
            lblProgress.Location = new Point(622, 180);
            lblProgress.Name = "lblProgress";
            lblProgress.Size = new Size(32, 21);
            lblProgress.TabIndex = 9;
            lblProgress.Text = "0%";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(14, 222);
            label5.Name = "label5";
            label5.Size = new Size(55, 21);
            label5.TabIndex = 10;
            label5.Text = "Status:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(129, 222);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(64, 21);
            lblStatus.TabIndex = 11;
            lblStatus.Text = "######";
            // 
            // btnCopy
            // 
            btnCopy.Location = new Point(129, 275);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(196, 31);
            btnCopy.TabIndex = 12;
            btnCopy.Text = "Start Copy";
            btnCopy.UseVisualStyleBackColor = true;
            btnCopy.Click += btnCopy_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(354, 275);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(196, 31);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // bgWorker
            // 
            bgWorker.WorkerReportsProgress = true;
            bgWorker.DoWork += bgWorker_DoWork;
            bgWorker.ProgressChanged += bgWorker_ProgressChanged;
            bgWorker.RunWorkerCompleted += bgWorker_RunWorkerCompleted;
            // 
            // panel
            // 
            panel.Anchor = AnchorStyles.None;
            panel.Controls.Add(btnExist);
            panel.Controls.Add(txtSourceFile);
            panel.Controls.Add(btnCancel);
            panel.Controls.Add(label1);
            panel.Controls.Add(btnCopy);
            panel.Controls.Add(label2);
            panel.Controls.Add(lblStatus);
            panel.Controls.Add(btnBrwoserS);
            panel.Controls.Add(label5);
            panel.Controls.Add(label3);
            panel.Controls.Add(lblProgress);
            panel.Controls.Add(txtDestination);
            panel.Controls.Add(pb);
            panel.Controls.Add(btnBrwoserD);
            panel.Controls.Add(label4);
            panel.Location = new Point(0, -2);
            panel.Name = "panel";
            panel.Size = new Size(754, 389);
            panel.TabIndex = 14;
            // 
            // btnExist
            // 
            btnExist.Location = new Point(129, 318);
            btnExist.Name = "btnExist";
            btnExist.Size = new Size(421, 31);
            btnExist.TabIndex = 14;
            btnExist.Text = "Exist";
            btnExist.UseVisualStyleBackColor = true;
            btnExist.Click += btnExist_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(755, 385);
            Controls.Add(panel);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "File Copier";
            panel.ResumeLayout(false);
            panel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtSourceFile;
        private Button btnBrwoserS;
        private Button btnBrwoserD;
        private TextBox txtDestination;
        private Label label3;
        private Label label4;
        private ProgressBar pb;
        private Label lblProgress;
        private Label label5;
        private Label lblStatus;
        private Button btnCopy;
        private Button btnCancel;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private Panel panel;
        private Button btnExist;
    }
}
