namespace _015_NotifyIcon_ContextMenuStrip_ToolStrip_StatusStrip
{
    partial class frmMain
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
            toolStrip1 = new ToolStrip();
            tsBtnHome = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            tsBtnTxtFile = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsBtnImageFiles = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsBtnSoundFiles = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            tsLblHints = new ToolStripLabel();
            statusStrip1 = new StatusStrip();
            stLblPage = new ToolStripStatusLabel();
            stLblFileInfo = new ToolStripStatusLabel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            exitToolStripMenuItem = new ToolStripMenuItem();
            panelContent = new Panel();
            pHomePage = new Panel();
            linkSoundFiles = new LinkLabel();
            linkImageFiles = new LinkLabel();
            linkTextFiles = new LinkLabel();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            panelContent.SuspendLayout();
            pHomePage.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsBtnHome, toolStripSeparator4, tsBtnTxtFile, toolStripSeparator1, tsBtnImageFiles, toolStripSeparator2, tsBtnSoundFiles, toolStripSeparator3, tsLblHints });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1009, 54);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnHome
            // 
            tsBtnHome.Image = Properties.Resources.home2_32;
            tsBtnHome.ImageScaling = ToolStripItemImageScaling.None;
            tsBtnHome.ImageTransparentColor = Color.Magenta;
            tsBtnHome.Name = "tsBtnHome";
            tsBtnHome.Size = new Size(44, 51);
            tsBtnHome.Tag = "1";
            tsBtnHome.Text = "Home";
            tsBtnHome.TextImageRelation = TextImageRelation.ImageAboveText;
            tsBtnHome.Click += Buttons_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 54);
            // 
            // tsBtnTxtFile
            // 
            tsBtnTxtFile.Image = Properties.Resources.document_32;
            tsBtnTxtFile.ImageScaling = ToolStripItemImageScaling.None;
            tsBtnTxtFile.ImageTransparentColor = Color.Magenta;
            tsBtnTxtFile.Name = "tsBtnTxtFile";
            tsBtnTxtFile.Size = new Size(58, 51);
            tsBtnTxtFile.Tag = "2";
            tsBtnTxtFile.Text = "Text Files";
            tsBtnTxtFile.TextImageRelation = TextImageRelation.ImageAboveText;
            tsBtnTxtFile.Click += Buttons_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 54);
            // 
            // tsBtnImageFiles
            // 
            tsBtnImageFiles.Image = Properties.Resources.image_32;
            tsBtnImageFiles.ImageScaling = ToolStripItemImageScaling.None;
            tsBtnImageFiles.ImageTransparentColor = Color.Magenta;
            tsBtnImageFiles.Name = "tsBtnImageFiles";
            tsBtnImageFiles.Size = new Size(70, 51);
            tsBtnImageFiles.Tag = "3";
            tsBtnImageFiles.Text = "Image Files";
            tsBtnImageFiles.TextImageRelation = TextImageRelation.ImageAboveText;
            tsBtnImageFiles.Click += Buttons_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 54);
            // 
            // tsBtnSoundFiles
            // 
            tsBtnSoundFiles.Image = Properties.Resources.sound_32r;
            tsBtnSoundFiles.ImageScaling = ToolStripItemImageScaling.None;
            tsBtnSoundFiles.ImageTransparentColor = Color.Magenta;
            tsBtnSoundFiles.Name = "tsBtnSoundFiles";
            tsBtnSoundFiles.Size = new Size(71, 51);
            tsBtnSoundFiles.Tag = "4";
            tsBtnSoundFiles.Text = "Sound Files";
            tsBtnSoundFiles.TextImageRelation = TextImageRelation.ImageAboveText;
            tsBtnSoundFiles.Click += Buttons_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 54);
            // 
            // tsLblHints
            // 
            tsLblHints.ForeColor = Color.Red;
            tsLblHints.Name = "tsLblHints";
            tsLblHints.Size = new Size(0, 51);
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { stLblPage, stLblFileInfo });
            statusStrip1.Location = new Point(0, 482);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1009, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // stLblPage
            // 
            stLblPage.Name = "stLblPage";
            stLblPage.Size = new Size(135, 17);
            stLblPage.Text = "Welcome to DropViewer";
            // 
            // stLblFileInfo
            // 
            stLblFileInfo.Name = "stLblFileInfo";
            stLblFileInfo.Size = new Size(0, 17);
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(94, 26);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(93, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(pHomePage);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 54);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1009, 428);
            panelContent.TabIndex = 3;
            // 
            // pHomePage
            // 
            pHomePage.Controls.Add(panel1);
            pHomePage.Dock = DockStyle.Fill;
            pHomePage.Location = new Point(0, 0);
            pHomePage.Name = "pHomePage";
            pHomePage.Size = new Size(1009, 428);
            pHomePage.TabIndex = 0;
            // 
            // linkSoundFiles
            // 
            linkSoundFiles.AutoSize = true;
            linkSoundFiles.Location = new Point(239, 154);
            linkSoundFiles.Name = "linkSoundFiles";
            linkSoundFiles.Size = new Size(90, 21);
            linkSoundFiles.TabIndex = 4;
            linkSoundFiles.TabStop = true;
            linkSoundFiles.Text = "Sound Files";
            linkSoundFiles.LinkClicked += linkSoundFiles_LinkClicked;
            // 
            // linkImageFiles
            // 
            linkImageFiles.AutoSize = true;
            linkImageFiles.Location = new Point(132, 154);
            linkImageFiles.Name = "linkImageFiles";
            linkImageFiles.Size = new Size(88, 21);
            linkImageFiles.TabIndex = 3;
            linkImageFiles.TabStop = true;
            linkImageFiles.Text = "Image Files";
            linkImageFiles.LinkClicked += linkImageFiles_LinkClicked;
            // 
            // linkTextFiles
            // 
            linkTextFiles.AutoSize = true;
            linkTextFiles.Location = new Point(25, 154);
            linkTextFiles.Name = "linkTextFiles";
            linkTextFiles.Size = new Size(71, 21);
            linkTextFiles.TabIndex = 2;
            linkTextFiles.TabStop = true;
            linkTextFiles.Text = "Text Files";
            linkTextFiles.LinkClicked += linkTextFiles_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(114, 71);
            label2.Name = "label2";
            label2.Size = new Size(124, 21);
            label2.TabIndex = 1;
            label2.Text = "DropViewer info";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 16);
            label1.Name = "label1";
            label1.Size = new Size(313, 37);
            label1.TabIndex = 0;
            label1.Text = "Welcome to DropViewer";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(linkSoundFiles);
            panel1.Controls.Add(linkImageFiles);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(linkTextFiles);
            panel1.Location = new Point(328, 120);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 189);
            panel1.TabIndex = 5;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1009, 504);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(panelContent);
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Font = new Font("Segoe UI", 12F);
            IsMdiContainer = true;
            Margin = new Padding(4);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DropViewer";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            pHomePage.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsBtnTxtFile;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsBtnImageFiles;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsBtnSoundFiles;
        private ToolStripSeparator toolStripSeparator3;
        private StatusStrip statusStrip1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripStatusLabel stLblPage;
        private ToolStripStatusLabel stLblFileInfo;
        private Panel panelContent;
        private ToolStripButton tsBtnHome;
        private ToolStripSeparator toolStripSeparator4;
        private Panel pHomePage;
        private Label label1;
        private LinkLabel linkSoundFiles;
        private LinkLabel linkImageFiles;
        private LinkLabel linkTextFiles;
        private Label label2;
        private ToolStripLabel tsLblHints;
        private Panel panel1;
    }
}
