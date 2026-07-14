namespace _010_ColorDialog_MonthCalendar_WebBrowser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            toolStrip1 = new ToolStrip();
            tsBtnBack = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsBtnForward = new ToolStripButton();
            tsTxtURL = new ToolStripTextBox();
            tsBtnSearch = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            tsBtnRefresh = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            tsBtnHome = new ToolStripButton();
            toolStripSeparator4 = new ToolStripSeparator();
            tsBtnCalendar = new ToolStripButton();
            linkChangeBackgroundColor = new LinkLabel();
            webView2 = new Microsoft.Web.WebView2.WinForms.WebView2();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)webView2).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.AutoSize = false;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsBtnBack, toolStripSeparator1, tsBtnForward, tsTxtURL, tsBtnSearch, toolStripSeparator3, tsBtnRefresh, toolStripSeparator2, tsBtnHome, toolStripSeparator4, tsBtnCalendar });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(953, 50);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsBtnBack
            // 
            tsBtnBack.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsBtnBack.Image = (Image)resources.GetObject("tsBtnBack.Image");
            tsBtnBack.ImageScaling = ToolStripItemImageScaling.None;
            tsBtnBack.ImageTransparentColor = Color.Magenta;
            tsBtnBack.Name = "tsBtnBack";
            tsBtnBack.Size = new Size(36, 47);
            tsBtnBack.Text = "Back";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 50);
            // 
            // tsBtnForward
            // 
            tsBtnForward.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsBtnForward.Image = Properties.Resources.forward_32;
            tsBtnForward.ImageScaling = ToolStripItemImageScaling.None;
            tsBtnForward.ImageTransparentColor = Color.Magenta;
            tsBtnForward.Name = "tsBtnForward";
            tsBtnForward.Size = new Size(36, 47);
            tsBtnForward.Text = "Forward";
            // 
            // tsTxtURL
            // 
            tsTxtURL.BorderStyle = BorderStyle.FixedSingle;
            tsTxtURL.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            tsTxtURL.ForeColor = SystemColors.MenuHighlight;
            tsTxtURL.Name = "tsTxtURL";
            tsTxtURL.Size = new Size(500, 50);
            // 
            // tsBtnSearch
            // 
            tsBtnSearch.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsBtnSearch.Image = Properties.Resources.zoom_32;
            tsBtnSearch.ImageScaling = ToolStripItemImageScaling.None;
            tsBtnSearch.ImageTransparentColor = Color.Magenta;
            tsBtnSearch.Name = "tsBtnSearch";
            tsBtnSearch.Size = new Size(36, 47);
            tsBtnSearch.Text = "Search";
            tsBtnSearch.Click += tsBtnSearch_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 50);
            // 
            // tsBtnRefresh
            // 
            tsBtnRefresh.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsBtnRefresh.Image = Properties.Resources.refresh2_32;
            tsBtnRefresh.ImageScaling = ToolStripItemImageScaling.None;
            tsBtnRefresh.ImageTransparentColor = Color.Magenta;
            tsBtnRefresh.Name = "tsBtnRefresh";
            tsBtnRefresh.Size = new Size(36, 47);
            tsBtnRefresh.Text = "Refresh";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 50);
            // 
            // tsBtnHome
            // 
            tsBtnHome.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsBtnHome.Image = Properties.Resources.home_32;
            tsBtnHome.ImageScaling = ToolStripItemImageScaling.None;
            tsBtnHome.ImageTransparentColor = Color.Magenta;
            tsBtnHome.Name = "tsBtnHome";
            tsBtnHome.Size = new Size(36, 47);
            tsBtnHome.Text = "Home";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(6, 50);
            // 
            // tsBtnCalendar
            // 
            tsBtnCalendar.DisplayStyle = ToolStripItemDisplayStyle.Image;
            tsBtnCalendar.Image = Properties.Resources.calendar_32;
            tsBtnCalendar.ImageScaling = ToolStripItemImageScaling.None;
            tsBtnCalendar.ImageTransparentColor = Color.Magenta;
            tsBtnCalendar.Name = "tsBtnCalendar";
            tsBtnCalendar.Size = new Size(36, 47);
            tsBtnCalendar.Text = "Calendar";
            // 
            // linkChangeBackgroundColor
            // 
            linkChangeBackgroundColor.AutoSize = true;
            linkChangeBackgroundColor.Dock = DockStyle.Bottom;
            linkChangeBackgroundColor.ForeColor = Color.DodgerBlue;
            linkChangeBackgroundColor.LinkColor = Color.Blue;
            linkChangeBackgroundColor.Location = new Point(0, 461);
            linkChangeBackgroundColor.Name = "linkChangeBackgroundColor";
            linkChangeBackgroundColor.Size = new Size(209, 21);
            linkChangeBackgroundColor.TabIndex = 0;
            linkChangeBackgroundColor.TabStop = true;
            linkChangeBackgroundColor.Text = "Change Background Color";
            linkChangeBackgroundColor.LinkClicked += linkChangeBackgroundColor_LinkClicked;
            // 
            // webView2
            // 
            webView2.AllowExternalDrop = true;
            webView2.CreationProperties = null;
            webView2.DefaultBackgroundColor = Color.White;
            webView2.Dock = DockStyle.Fill;
            webView2.Location = new Point(0, 50);
            webView2.Name = "webView2";
            webView2.Size = new Size(953, 411);
            webView2.TabIndex = 3;
            webView2.ZoomFactor = 1D;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(953, 482);
            Controls.Add(webView2);
            Controls.Add(linkChangeBackgroundColor);
            Controls.Add(toolStrip1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "G-Browser";
            WindowState = FormWindowState.Maximized;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)webView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ToolStrip toolStrip1;
        private ToolStripButton tsBtnBack;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton tsBtnForward;
        private ToolStripTextBox tsTxtURL;
        private ToolStripButton tsBtnSearch;
        private ToolStripButton tsBtnRefresh;
        private ToolStripButton tsBtnHome;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripSeparator toolStripSeparator2;
        private LinkLabel linkChangeBackgroundColor;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripButton tsBtnCalendar;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView2;
    }
}
