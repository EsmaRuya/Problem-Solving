namespace _013_Panel_TabControl_SplitContainer_RadioButton
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
            panelLeft = new Panel();
            panelLeftDown = new Panel();
            btnOrientation = new Button();
            btnMode = new Button();
            btnResize = new Button();
            btnDownload = new Button();
            panelTabs = new Panel();
            rdbJS = new RadioButton();
            rdbCSS = new RadioButton();
            rdbHTML = new RadioButton();
            label1 = new Label();
            sc = new SplitContainer();
            tabControl = new TabControl();
            tabPageHTML = new TabPage();
            txtHTML = new TextBox();
            tabPageCSS = new TabPage();
            txtCSS = new TextBox();
            tabPageJS = new TabPage();
            txtJS = new TextBox();
            panelBodyRight = new Panel();
            myWebView = new Microsoft.Web.WebView2.WinForms.WebView2();
            panelTopRight = new Panel();
            btnShowResult = new Button();
            panelLeft.SuspendLayout();
            panelLeftDown.SuspendLayout();
            panelTabs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)sc).BeginInit();
            sc.Panel1.SuspendLayout();
            sc.Panel2.SuspendLayout();
            sc.SuspendLayout();
            tabControl.SuspendLayout();
            tabPageHTML.SuspendLayout();
            tabPageCSS.SuspendLayout();
            tabPageJS.SuspendLayout();
            panelBodyRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)myWebView).BeginInit();
            panelTopRight.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(panelLeftDown);
            panelLeft.Controls.Add(panelTabs);
            panelLeft.Controls.Add(label1);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(135, 588);
            panelLeft.TabIndex = 0;
            // 
            // panelLeftDown
            // 
            panelLeftDown.Controls.Add(btnOrientation);
            panelLeftDown.Controls.Add(btnMode);
            panelLeftDown.Controls.Add(btnResize);
            panelLeftDown.Controls.Add(btnDownload);
            panelLeftDown.Dock = DockStyle.Bottom;
            panelLeftDown.Location = new Point(0, 461);
            panelLeftDown.Name = "panelLeftDown";
            panelLeftDown.Size = new Size(135, 127);
            panelLeftDown.TabIndex = 4;
            // 
            // btnOrientation
            // 
            btnOrientation.FlatStyle = FlatStyle.Flat;
            btnOrientation.Font = new Font("Segoe UI", 9F);
            btnOrientation.Location = new Point(11, 44);
            btnOrientation.Name = "btnOrientation";
            btnOrientation.Size = new Size(112, 25);
            btnOrientation.TabIndex = 3;
            btnOrientation.Text = "Horizontal";
            btnOrientation.UseVisualStyleBackColor = true;
            btnOrientation.Click += btnOrientation_Click;
            // 
            // btnMode
            // 
            btnMode.FlatAppearance.BorderColor = Color.Silver;
            btnMode.FlatStyle = FlatStyle.Flat;
            btnMode.Image = Properties.Resources.moon_32;
            btnMode.Location = new Point(10, 80);
            btnMode.Name = "btnMode";
            btnMode.Size = new Size(29, 30);
            btnMode.TabIndex = 1;
            btnMode.UseVisualStyleBackColor = true;
            btnMode.Click += btnMode_Click;
            // 
            // btnResize
            // 
            btnResize.FlatAppearance.BorderColor = Color.Silver;
            btnResize.FlatStyle = FlatStyle.Flat;
            btnResize.Image = Properties.Resources.resize_16;
            btnResize.Location = new Point(94, 80);
            btnResize.Name = "btnResize";
            btnResize.Size = new Size(29, 30);
            btnResize.TabIndex = 3;
            btnResize.UseVisualStyleBackColor = true;
            btnResize.Click += btnResize_Click;
            // 
            // btnDownload
            // 
            btnDownload.FlatAppearance.BorderColor = Color.Silver;
            btnDownload.FlatStyle = FlatStyle.Flat;
            btnDownload.Image = Properties.Resources.download_32;
            btnDownload.Location = new Point(53, 80);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(29, 30);
            btnDownload.TabIndex = 2;
            btnDownload.UseVisualStyleBackColor = true;
            btnDownload.Click += btnDownload_Click;
            // 
            // panelTabs
            // 
            panelTabs.Controls.Add(rdbJS);
            panelTabs.Controls.Add(rdbCSS);
            panelTabs.Controls.Add(rdbHTML);
            panelTabs.Location = new Point(22, 41);
            panelTabs.Name = "panelTabs";
            panelTabs.Size = new Size(91, 69);
            panelTabs.TabIndex = 1;
            // 
            // rdbJS
            // 
            rdbJS.AutoSize = true;
            rdbJS.Font = new Font("Segoe UI", 9F);
            rdbJS.Location = new Point(3, 42);
            rdbJS.Name = "rdbJS";
            rdbJS.Size = new Size(65, 19);
            rdbJS.TabIndex = 3;
            rdbJS.Text = "script.js";
            rdbJS.UseVisualStyleBackColor = true;
            rdbJS.CheckedChanged += rdbJS_CheckedChanged;
            // 
            // rdbCSS
            // 
            rdbCSS.AutoSize = true;
            rdbCSS.Font = new Font("Segoe UI", 9F);
            rdbCSS.Location = new Point(3, 23);
            rdbCSS.Name = "rdbCSS";
            rdbCSS.Size = new Size(68, 19);
            rdbCSS.TabIndex = 2;
            rdbCSS.Text = "style.css";
            rdbCSS.UseVisualStyleBackColor = true;
            rdbCSS.CheckedChanged += rdbCSS_CheckedChanged;
            // 
            // rdbHTML
            // 
            rdbHTML.AutoSize = true;
            rdbHTML.Checked = true;
            rdbHTML.Font = new Font("Segoe UI", 9F);
            rdbHTML.Location = new Point(3, 4);
            rdbHTML.Name = "rdbHTML";
            rdbHTML.Size = new Size(82, 19);
            rdbHTML.TabIndex = 1;
            rdbHTML.TabStop = true;
            rdbHTML.Text = "index.html";
            rdbHTML.UseVisualStyleBackColor = true;
            rdbHTML.CheckedChanged += rdbHTML_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(115, 15);
            label1.TabIndex = 1;
            label1.Text = "Online HTML Editor";
            // 
            // sc
            // 
            sc.BorderStyle = BorderStyle.FixedSingle;
            sc.Dock = DockStyle.Fill;
            sc.Location = new Point(135, 0);
            sc.Name = "sc";
            // 
            // sc.Panel1
            // 
            sc.Panel1.Controls.Add(tabControl);
            // 
            // sc.Panel2
            // 
            sc.Panel2.Controls.Add(panelBodyRight);
            sc.Panel2.Controls.Add(panelTopRight);
            sc.Size = new Size(942, 588);
            sc.SplitterDistance = 402;
            sc.SplitterWidth = 10;
            sc.TabIndex = 1;
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabPageHTML);
            tabControl.Controls.Add(tabPageCSS);
            tabControl.Controls.Add(tabPageJS);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(400, 586);
            tabControl.TabIndex = 0;
            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            // 
            // tabPageHTML
            // 
            tabPageHTML.Controls.Add(txtHTML);
            tabPageHTML.Location = new Point(4, 30);
            tabPageHTML.Name = "tabPageHTML";
            tabPageHTML.Padding = new Padding(3);
            tabPageHTML.Size = new Size(392, 552);
            tabPageHTML.TabIndex = 0;
            tabPageHTML.Text = "index.html";
            tabPageHTML.UseVisualStyleBackColor = true;
            // 
            // txtHTML
            // 
            txtHTML.Dock = DockStyle.Fill;
            txtHTML.Location = new Point(3, 3);
            txtHTML.Multiline = true;
            txtHTML.Name = "txtHTML";
            txtHTML.Size = new Size(386, 546);
            txtHTML.TabIndex = 0;
            // 
            // tabPageCSS
            // 
            tabPageCSS.Controls.Add(txtCSS);
            tabPageCSS.Location = new Point(4, 24);
            tabPageCSS.Name = "tabPageCSS";
            tabPageCSS.Padding = new Padding(3);
            tabPageCSS.Size = new Size(392, 558);
            tabPageCSS.TabIndex = 1;
            tabPageCSS.Text = "style.css";
            tabPageCSS.UseVisualStyleBackColor = true;
            // 
            // txtCSS
            // 
            txtCSS.Dock = DockStyle.Fill;
            txtCSS.Location = new Point(3, 3);
            txtCSS.Multiline = true;
            txtCSS.Name = "txtCSS";
            txtCSS.Size = new Size(386, 552);
            txtCSS.TabIndex = 0;
            // 
            // tabPageJS
            // 
            tabPageJS.Controls.Add(txtJS);
            tabPageJS.Location = new Point(4, 24);
            tabPageJS.Name = "tabPageJS";
            tabPageJS.Padding = new Padding(3);
            tabPageJS.Size = new Size(392, 558);
            tabPageJS.TabIndex = 2;
            tabPageJS.Text = "script.js";
            tabPageJS.UseVisualStyleBackColor = true;
            // 
            // txtJS
            // 
            txtJS.Dock = DockStyle.Fill;
            txtJS.Location = new Point(3, 3);
            txtJS.Multiline = true;
            txtJS.Name = "txtJS";
            txtJS.Size = new Size(386, 552);
            txtJS.TabIndex = 0;
            // 
            // panelBodyRight
            // 
            panelBodyRight.Controls.Add(myWebView);
            panelBodyRight.Dock = DockStyle.Fill;
            panelBodyRight.Location = new Point(0, 34);
            panelBodyRight.Name = "panelBodyRight";
            panelBodyRight.Size = new Size(528, 552);
            panelBodyRight.TabIndex = 4;
            // 
            // myWebView
            // 
            myWebView.AllowExternalDrop = true;
            myWebView.CreationProperties = null;
            myWebView.DefaultBackgroundColor = Color.White;
            myWebView.Dock = DockStyle.Fill;
            myWebView.Location = new Point(0, 0);
            myWebView.Name = "myWebView";
            myWebView.Size = new Size(528, 552);
            myWebView.TabIndex = 1;
            myWebView.ZoomFactor = 1D;
            // 
            // panelTopRight
            // 
            panelTopRight.Controls.Add(btnShowResult);
            panelTopRight.Dock = DockStyle.Top;
            panelTopRight.Location = new Point(0, 0);
            panelTopRight.Name = "panelTopRight";
            panelTopRight.Size = new Size(528, 34);
            panelTopRight.TabIndex = 3;
            // 
            // btnShowResult
            // 
            btnShowResult.FlatStyle = FlatStyle.Flat;
            btnShowResult.Font = new Font("Segoe UI", 9F);
            btnShowResult.Location = new Point(11, 5);
            btnShowResult.Name = "btnShowResult";
            btnShowResult.Size = new Size(129, 23);
            btnShowResult.TabIndex = 2;
            btnShowResult.Text = "Show Result";
            btnShowResult.UseVisualStyleBackColor = true;
            btnShowResult.Click += btnShowResult_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1077, 588);
            Controls.Add(sc);
            Controls.Add(panelLeft);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Online HTML Editor";
            Load += Form1_Load;
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panelLeftDown.ResumeLayout(false);
            panelTabs.ResumeLayout(false);
            panelTabs.PerformLayout();
            sc.Panel1.ResumeLayout(false);
            sc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)sc).EndInit();
            sc.ResumeLayout(false);
            tabControl.ResumeLayout(false);
            tabPageHTML.ResumeLayout(false);
            tabPageHTML.PerformLayout();
            tabPageCSS.ResumeLayout(false);
            tabPageCSS.PerformLayout();
            tabPageJS.ResumeLayout(false);
            tabPageJS.PerformLayout();
            panelBodyRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)myWebView).EndInit();
            panelTopRight.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private RadioButton rdbCSS;
        private RadioButton rdbHTML;
        private Label label1;
        private RadioButton rdbJS;
        private Panel panelTabs;
        private Button btnDownload;
        private Button btnMode;
        private Button btnResize;
        private Panel panelLeftDown;
        private SplitContainer sc;
        private TabControl tabControl;
        private TabPage tabPageHTML;
        private TabPage tabPageCSS;
        private TextBox txtHTML;
        private TextBox txtCSS;
        private TabPage tabPageJS;
        private TextBox txtJS;
        private Microsoft.Web.WebView2.WinForms.WebView2 myWebView;
        private Button btnShowResult;
        private Panel panelTopRight;
        private Panel panelBodyRight;
        private Button btnOrientation;
    }
}
