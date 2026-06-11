namespace _006_Practice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            linkMoreInfo = new LinkLabel();
            btnRename = new Button();
            btnRecentFiles = new Button();
            btnMove = new Button();
            btnCopy = new Button();
            btnSave = new Button();
            btnOpen = new Button();
            panelInfo = new Panel();
            lblFileDate = new Label();
            label5 = new Label();
            lblFileInfo = new Label();
            label3 = new Label();
            lblFilePath = new Label();
            label1 = new Label();
            txtContent = new TextBox();
            panel1.SuspendLayout();
            panelInfo.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(linkMoreInfo);
            panel1.Controls.Add(btnRename);
            panel1.Controls.Add(btnRecentFiles);
            panel1.Controls.Add(btnMove);
            panel1.Controls.Add(btnCopy);
            panel1.Controls.Add(btnSave);
            panel1.Controls.Add(btnOpen);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(892, 98);
            panel1.TabIndex = 1;
            // 
            // linkMoreInfo
            // 
            linkMoreInfo.AutoSize = true;
            linkMoreInfo.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkMoreInfo.Location = new Point(592, 58);
            linkMoreInfo.Name = "linkMoreInfo";
            linkMoreInfo.Size = new Size(137, 17);
            linkMoreInfo.TabIndex = 6;
            linkMoreInfo.TabStop = true;
            linkMoreInfo.Text = "More Info About File";
            linkMoreInfo.Visible = false;
            linkMoreInfo.LinkClicked += linkMoreInfo_LinkClicked;
            // 
            // btnRename
            // 
            btnRename.BackColor = Color.White;
            btnRename.FlatStyle = FlatStyle.Flat;
            btnRename.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnRename.ForeColor = Color.Black;
            btnRename.Image = (Image)resources.GetObject("btnRename.Image");
            btnRename.ImageAlign = ContentAlignment.TopCenter;
            btnRename.Location = new Point(361, 13);
            btnRename.Name = "btnRename";
            btnRename.Size = new Size(79, 63);
            btnRename.TabIndex = 5;
            btnRename.Text = "Rename";
            btnRename.TextAlign = ContentAlignment.BottomCenter;
            btnRename.UseVisualStyleBackColor = false;
            btnRename.Click += btnRename_Click;
            // 
            // btnRecentFiles
            // 
            btnRecentFiles.BackColor = Color.White;
            btnRecentFiles.FlatStyle = FlatStyle.Flat;
            btnRecentFiles.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnRecentFiles.ForeColor = Color.Black;
            btnRecentFiles.Image = (Image)resources.GetObject("btnRecentFiles.Image");
            btnRecentFiles.ImageAlign = ContentAlignment.TopCenter;
            btnRecentFiles.Location = new Point(452, 13);
            btnRecentFiles.Name = "btnRecentFiles";
            btnRecentFiles.Size = new Size(89, 63);
            btnRecentFiles.TabIndex = 4;
            btnRecentFiles.Text = "Recent Files";
            btnRecentFiles.TextAlign = ContentAlignment.BottomCenter;
            btnRecentFiles.UseVisualStyleBackColor = false;
            btnRecentFiles.Click += btnRecentFiles_Click;
            // 
            // btnMove
            // 
            btnMove.BackColor = Color.White;
            btnMove.FlatStyle = FlatStyle.Flat;
            btnMove.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnMove.ForeColor = Color.Black;
            btnMove.Image = (Image)resources.GetObject("btnMove.Image");
            btnMove.ImageAlign = ContentAlignment.TopCenter;
            btnMove.Location = new Point(274, 13);
            btnMove.Name = "btnMove";
            btnMove.Size = new Size(75, 63);
            btnMove.TabIndex = 3;
            btnMove.Text = "Move";
            btnMove.TextAlign = ContentAlignment.BottomCenter;
            btnMove.UseVisualStyleBackColor = false;
            btnMove.Click += btnMove_Click;
            // 
            // btnCopy
            // 
            btnCopy.BackColor = Color.White;
            btnCopy.FlatStyle = FlatStyle.Flat;
            btnCopy.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnCopy.ForeColor = Color.Black;
            btnCopy.Image = (Image)resources.GetObject("btnCopy.Image");
            btnCopy.ImageAlign = ContentAlignment.TopCenter;
            btnCopy.Location = new Point(187, 13);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(75, 63);
            btnCopy.TabIndex = 2;
            btnCopy.Text = "Copy";
            btnCopy.TextAlign = ContentAlignment.BottomCenter;
            btnCopy.UseVisualStyleBackColor = false;
            btnCopy.Click += btnCopy_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnSave.ForeColor = Color.Black;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.TopCenter;
            btnSave.Location = new Point(100, 13);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 63);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.TextAlign = ContentAlignment.BottomCenter;
            btnSave.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnOpen
            // 
            btnOpen.BackColor = Color.White;
            btnOpen.FlatStyle = FlatStyle.Flat;
            btnOpen.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            btnOpen.ForeColor = Color.Black;
            btnOpen.Image = (Image)resources.GetObject("btnOpen.Image");
            btnOpen.ImageAlign = ContentAlignment.TopCenter;
            btnOpen.Location = new Point(13, 13);
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(75, 62);
            btnOpen.TabIndex = 0;
            btnOpen.Text = "Open";
            btnOpen.TextAlign = ContentAlignment.BottomCenter;
            btnOpen.UseVisualStyleBackColor = false;
            btnOpen.Click += btnOpen_Click;
            // 
            // panelInfo
            // 
            panelInfo.Controls.Add(lblFileDate);
            panelInfo.Controls.Add(label5);
            panelInfo.Controls.Add(lblFileInfo);
            panelInfo.Controls.Add(label3);
            panelInfo.Controls.Add(lblFilePath);
            panelInfo.Controls.Add(label1);
            panelInfo.Dock = DockStyle.Top;
            panelInfo.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelInfo.Location = new Point(0, 98);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(892, 40);
            panelInfo.TabIndex = 2;
            // 
            // lblFileDate
            // 
            lblFileDate.AutoSize = true;
            lblFileDate.ForeColor = Color.DodgerBlue;
            lblFileDate.Location = new Point(716, 9);
            lblFileDate.Name = "lblFileDate";
            lblFileDate.Size = new Size(0, 17);
            lblFileDate.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(649, 9);
            label5.Name = "label5";
            label5.Size = new Size(62, 17);
            label5.TabIndex = 4;
            label5.Text = "Created :";
            // 
            // lblFileInfo
            // 
            lblFileInfo.AutoSize = true;
            lblFileInfo.ForeColor = Color.DodgerBlue;
            lblFileInfo.Location = new Point(477, 9);
            lblFileInfo.Name = "lblFileInfo";
            lblFileInfo.Size = new Size(0, 17);
            lblFileInfo.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(405, 9);
            label3.Name = "label3";
            label3.Size = new Size(63, 17);
            label3.TabIndex = 2;
            label3.Text = "File Info :";
            // 
            // lblFilePath
            // 
            lblFilePath.AutoSize = true;
            lblFilePath.ForeColor = Color.DodgerBlue;
            lblFilePath.Location = new Point(87, 9);
            lblFilePath.Name = "lblFilePath";
            lblFilePath.Size = new Size(0, 17);
            lblFilePath.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 17);
            label1.TabIndex = 0;
            label1.Text = "File Path :";
            // 
            // txtContent
            // 
            txtContent.Dock = DockStyle.Fill;
            txtContent.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtContent.Location = new Point(0, 138);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(892, 258);
            txtContent.TabIndex = 3;
            txtContent.Visible = false;
            txtContent.TextChanged += txtContent_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(892, 396);
            Controls.Add(txtContent);
            Controls.Add(panelInfo);
            Controls.Add(panel1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "File Manager Lite";
            FormClosing += Form1_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelInfo.ResumeLayout(false);
            panelInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel1;
        private Button btnOpen;
        private Button btnRename;
        private Button btnRecentFiles;
        private Button btnMove;
        private Button btnCopy;
        private Button btnSave;
        private Panel panelInfo;
        private Label lblFileDate;
        private Label label5;
        private Label lblFileInfo;
        private Label label3;
        private Label lblFilePath;
        private Label label1;
        private TextBox txtContent;
        private LinkLabel linkMoreInfo;
    }
}
