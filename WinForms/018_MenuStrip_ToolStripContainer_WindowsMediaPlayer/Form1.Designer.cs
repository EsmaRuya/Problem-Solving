namespace _018_MenuStrip_ToolStripContainer_WindowsMediaPlayer
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
            toolStripContainer1 = new ToolStripContainer();
            axWMP = new AxWMPLib.AxWindowsMediaPlayer();
            btnSelectFile = new Button();
            txtMediaPath = new TextBox();
            label1 = new Label();
            btnPlayInLoop = new Button();
            btnStop = new Button();
            btnPause = new Button();
            btnPlay = new Button();
            msHeader = new MenuStrip();
            soundsToolStripMenuItem = new ToolStripMenuItem();
            videosToolStripMenuItem = new ToolStripMenuItem();
            toolStripContainer1.ContentPanel.SuspendLayout();
            toolStripContainer1.TopToolStripPanel.SuspendLayout();
            toolStripContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)axWMP).BeginInit();
            msHeader.SuspendLayout();
            SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            toolStripContainer1.ContentPanel.Controls.Add(axWMP);
            toolStripContainer1.ContentPanel.Controls.Add(btnSelectFile);
            toolStripContainer1.ContentPanel.Controls.Add(txtMediaPath);
            toolStripContainer1.ContentPanel.Controls.Add(label1);
            toolStripContainer1.ContentPanel.Controls.Add(btnPlayInLoop);
            toolStripContainer1.ContentPanel.Controls.Add(btnStop);
            toolStripContainer1.ContentPanel.Controls.Add(btnPause);
            toolStripContainer1.ContentPanel.Controls.Add(btnPlay);
            toolStripContainer1.ContentPanel.Margin = new Padding(5);
            toolStripContainer1.ContentPanel.Size = new Size(975, 573);
            toolStripContainer1.Dock = DockStyle.Fill;
            toolStripContainer1.Location = new Point(0, 0);
            toolStripContainer1.Margin = new Padding(5);
            toolStripContainer1.Name = "toolStripContainer1";
            toolStripContainer1.Size = new Size(975, 597);
            toolStripContainer1.TabIndex = 0;
            toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            toolStripContainer1.TopToolStripPanel.Controls.Add(msHeader);
            // 
            // axWMP
            // 
            axWMP.Enabled = true;
            axWMP.Location = new Point(95, 59);
            axWMP.Name = "axWMP";
            axWMP.OcxState = (AxHost.State)resources.GetObject("axWMP.OcxState");
            axWMP.Size = new Size(776, 431);
            axWMP.TabIndex = 7;
            // 
            // btnSelectFile
            // 
            btnSelectFile.BackColor = Color.FromArgb(128, 128, 255);
            btnSelectFile.FlatStyle = FlatStyle.Flat;
            btnSelectFile.Font = new Font("Segoe UI", 12F);
            btnSelectFile.ForeColor = Color.White;
            btnSelectFile.Location = new Point(798, 17);
            btnSelectFile.Name = "btnSelectFile";
            btnSelectFile.Size = new Size(120, 36);
            btnSelectFile.TabIndex = 6;
            btnSelectFile.Text = "Select File";
            btnSelectFile.UseVisualStyleBackColor = false;
            btnSelectFile.Click += btnSelectFile_Click;
            // 
            // txtMediaPath
            // 
            txtMediaPath.Location = new Point(161, 21);
            txtMediaPath.Name = "txtMediaPath";
            txtMediaPath.Size = new Size(631, 32);
            txtMediaPath.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 24);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 4;
            label1.Text = "Media Path:";
            // 
            // btnPlayInLoop
            // 
            btnPlayInLoop.BackColor = Color.FromArgb(128, 128, 255);
            btnPlayInLoop.FlatStyle = FlatStyle.Flat;
            btnPlayInLoop.Font = new Font("Segoe UI", 12F);
            btnPlayInLoop.ForeColor = Color.White;
            btnPlayInLoop.Location = new Point(710, 509);
            btnPlayInLoop.Name = "btnPlayInLoop";
            btnPlayInLoop.Size = new Size(214, 36);
            btnPlayInLoop.TabIndex = 3;
            btnPlayInLoop.Text = "Play in loop";
            btnPlayInLoop.UseVisualStyleBackColor = false;
            btnPlayInLoop.Click += btnPlayInLoop_Click;
            // 
            // btnStop
            // 
            btnStop.BackColor = Color.FromArgb(128, 128, 255);
            btnStop.FlatStyle = FlatStyle.Flat;
            btnStop.Font = new Font("Segoe UI", 12F);
            btnStop.ForeColor = Color.White;
            btnStop.Location = new Point(490, 509);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(214, 36);
            btnStop.TabIndex = 2;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = false;
            btnStop.Click += btnStop_Click;
            // 
            // btnPause
            // 
            btnPause.BackColor = Color.FromArgb(128, 128, 255);
            btnPause.FlatStyle = FlatStyle.Flat;
            btnPause.Font = new Font("Segoe UI", 12F);
            btnPause.ForeColor = Color.White;
            btnPause.Location = new Point(270, 509);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(214, 36);
            btnPause.TabIndex = 1;
            btnPause.Text = "Pause";
            btnPause.UseVisualStyleBackColor = false;
            btnPause.Click += btnPause_Click;
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.FromArgb(128, 128, 255);
            btnPlay.FlatStyle = FlatStyle.Flat;
            btnPlay.Font = new Font("Segoe UI", 12F);
            btnPlay.ForeColor = Color.White;
            btnPlay.Location = new Point(50, 509);
            btnPlay.Name = "btnPlay";
            btnPlay.Size = new Size(214, 36);
            btnPlay.TabIndex = 0;
            btnPlay.Text = "Play";
            btnPlay.UseVisualStyleBackColor = false;
            btnPlay.Click += btnPlay_Click;
            // 
            // msHeader
            // 
            msHeader.Dock = DockStyle.None;
            msHeader.Items.AddRange(new ToolStripItem[] { soundsToolStripMenuItem, videosToolStripMenuItem });
            msHeader.Location = new Point(0, 0);
            msHeader.Name = "msHeader";
            msHeader.Size = new Size(975, 24);
            msHeader.TabIndex = 0;
            msHeader.Text = "menuStrip1";
            // 
            // soundsToolStripMenuItem
            // 
            soundsToolStripMenuItem.Name = "soundsToolStripMenuItem";
            soundsToolStripMenuItem.Size = new Size(58, 20);
            soundsToolStripMenuItem.Text = "Sounds";
            // 
            // videosToolStripMenuItem
            // 
            videosToolStripMenuItem.Name = "videosToolStripMenuItem";
            videosToolStripMenuItem.Size = new Size(54, 20);
            videosToolStripMenuItem.Text = "Videos";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(975, 597);
            Controls.Add(toolStripContainer1);
            Font = new Font("Segoe UI", 14F);
            MainMenuStrip = msHeader;
            Margin = new Padding(5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Media Player";
            toolStripContainer1.ContentPanel.ResumeLayout(false);
            toolStripContainer1.ContentPanel.PerformLayout();
            toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            toolStripContainer1.TopToolStripPanel.PerformLayout();
            toolStripContainer1.ResumeLayout(false);
            toolStripContainer1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)axWMP).EndInit();
            msHeader.ResumeLayout(false);
            msHeader.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ToolStripContainer toolStripContainer1;
        private Button btnStop;
        private Button btnPause;
        private Button btnPlay;
        private MenuStrip msHeader;
        private ToolStripMenuItem soundsToolStripMenuItem;
        private ToolStripMenuItem videosToolStripMenuItem;
        private Button btnSelectFile;
        private TextBox txtMediaPath;
        private Label label1;
        private Button btnPlayInLoop;
        private AxWMPLib.AxWindowsMediaPlayer axWMP;
    }
}
