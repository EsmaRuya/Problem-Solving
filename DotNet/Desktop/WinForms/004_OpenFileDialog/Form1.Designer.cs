namespace _004_OpenFileDialog
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
            label3 = new Label();
            label4 = new Label();
            txtBox_Path = new TextBox();
            txtBox_FileName = new TextBox();
            txtBox_FileExtension = new TextBox();
            btnChooseFile = new Button();
            btnClose = new Button();
            ofd = new OpenFileDialog();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(293, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(137, 21);
            label1.TabIndex = 0;
            label1.Text = "Open File Dialog";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(65, 76);
            label2.Name = "label2";
            label2.Size = new Size(47, 21);
            label2.TabIndex = 1;
            label2.Text = "Path :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(65, 134);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 2;
            label3.Text = "File Name :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(65, 192);
            label4.Name = "label4";
            label4.Size = new Size(111, 21);
            label4.TabIndex = 3;
            label4.Text = "File Extension :";
            // 
            // txtBox_Path
            // 
            txtBox_Path.Location = new Point(183, 68);
            txtBox_Path.Name = "txtBox_Path";
            txtBox_Path.ReadOnly = true;
            txtBox_Path.Size = new Size(452, 29);
            txtBox_Path.TabIndex = 4;
            // 
            // txtBox_FileName
            // 
            txtBox_FileName.Location = new Point(183, 126);
            txtBox_FileName.Name = "txtBox_FileName";
            txtBox_FileName.ReadOnly = true;
            txtBox_FileName.Size = new Size(452, 29);
            txtBox_FileName.TabIndex = 5;
            // 
            // txtBox_FileExtension
            // 
            txtBox_FileExtension.Location = new Point(183, 184);
            txtBox_FileExtension.Name = "txtBox_FileExtension";
            txtBox_FileExtension.ReadOnly = true;
            txtBox_FileExtension.Size = new Size(452, 29);
            txtBox_FileExtension.TabIndex = 6;
            // 
            // btnChooseFile
            // 
            btnChooseFile.BackColor = Color.FromArgb(255, 192, 128);
            btnChooseFile.FlatStyle = FlatStyle.Flat;
            btnChooseFile.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnChooseFile.ForeColor = Color.FromArgb(255, 128, 0);
            btnChooseFile.Location = new Point(327, 253);
            btnChooseFile.Name = "btnChooseFile";
            btnChooseFile.Size = new Size(151, 44);
            btnChooseFile.TabIndex = 1;
            btnChooseFile.Text = "Choose File";
            btnChooseFile.UseVisualStyleBackColor = false;
            btnChooseFile.Click += btnChooseFile_Click;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.FromArgb(255, 192, 128);
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClose.ForeColor = Color.FromArgb(255, 128, 0);
            btnClose.Location = new Point(484, 253);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(151, 44);
            btnClose.TabIndex = 8;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(739, 339);
            Controls.Add(btnClose);
            Controls.Add(btnChooseFile);
            Controls.Add(txtBox_FileExtension);
            Controls.Add(txtBox_FileName);
            Controls.Add(txtBox_Path);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "OpenFileDialog";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtBox_Path;
        private TextBox txtBox_FileName;
        private TextBox txtBox_FileExtension;
        private Button btnChooseFile;
        private Button btnClose;
        private OpenFileDialog ofd;
    }
}
