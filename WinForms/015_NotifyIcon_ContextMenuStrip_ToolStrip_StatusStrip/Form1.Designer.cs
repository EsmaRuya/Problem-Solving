namespace _015_NotifyIcon_ContextMenuStrip_ToolStrip_StatusStrip
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
            toolStrip1 = new ToolStrip();
            tsBtnTxtFile = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsBtnImageFiles = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsBtnSoundFiles = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            statusStrip1 = new StatusStrip();
            stLblStatus = new ToolStripStatusLabel();
            contextMenuStrip1 = new ContextMenuStrip(components);
            exitToolStripMenuItem = new ToolStripMenuItem();
            toolStrip1.SuspendLayout();
            statusStrip1.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsBtnTxtFile, toolStripSeparator1, tsBtnImageFiles, toolStripSeparator2, tsBtnSoundFiles, toolStripSeparator3 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(1009, 54);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnTxtFile
            // 
            tsBtnTxtFile.Image = Properties.Resources.document_32;
            tsBtnTxtFile.ImageScaling = ToolStripItemImageScaling.None;
            tsBtnTxtFile.ImageTransparentColor = Color.Magenta;
            tsBtnTxtFile.Name = "tsBtnTxtFile";
            tsBtnTxtFile.Size = new Size(58, 51);
            tsBtnTxtFile.Text = "Text Files";
            tsBtnTxtFile.TextImageRelation = TextImageRelation.ImageAboveText;
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
            tsBtnImageFiles.Text = "Image Files";
            tsBtnImageFiles.TextImageRelation = TextImageRelation.ImageAboveText;
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
            tsBtnSoundFiles.Text = "Sound Files";
            tsBtnSoundFiles.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 54);
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { stLblStatus });
            statusStrip1.Location = new Point(0, 482);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1009, 22);
            statusStrip1.TabIndex = 1;
            statusStrip1.Text = "statusStrip1";
            // 
            // stLblStatus
            // 
            stLblStatus.Name = "stLblStatus";
            stLblStatus.Size = new Size(39, 17);
            stLblStatus.Text = "Status";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { exitToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 48);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1009, 504);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(statusStrip1);
            Controls.Add(toolStrip1);
            Font = new Font("Segoe UI", 12F);
            IsMdiContainer = true;
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DropViewer";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
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
        private ToolStripStatusLabel stLblStatus;
        private ToolStripMenuItem exitToolStripMenuItem;
    }
}
