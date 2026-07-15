namespace _021_Practice_Font
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
            txtFileName = new TextBox();
            btnSave = new Button();
            label2 = new Label();
            cbFonts = new ComboBox();
            label3 = new Label();
            lblFontName = new Label();
            nudFontSize = new NumericUpDown();
            label4 = new Label();
            cbBold = new CheckBox();
            cbItalic = new CheckBox();
            cbUnderLine = new CheckBox();
            txtContent = new TextBox();
            cms = new ContextMenuStrip(components);
            copyToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem = new ToolStripMenuItem();
            pasteToolStripMenuItem1 = new ToolStripMenuItem();
            fontSettingsToolStripMenuItem = new ToolStripMenuItem();
            ep = new ErrorProvider(components);
            btnChangeFont = new Button();
            btnDefault = new Button();
            ((System.ComponentModel.ISupportInitialize)nudFontSize).BeginInit();
            cms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ep).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(59, 21);
            label1.TabIndex = 0;
            label1.Text = "Name :";
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(77, 12);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(586, 29);
            txtFileName.TabIndex = 1;
            txtFileName.TextChanged += txtFileName_TextChanged;
            txtFileName.KeyDown += txtFileName_KeyDown;
            txtFileName.KeyPress += txtFileName_KeyPress;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(685, 12);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(164, 29);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 50);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 3;
            label2.Text = "Select Font :";
            // 
            // cbFonts
            // 
            cbFonts.FormattingEnabled = true;
            cbFonts.Location = new Point(111, 46);
            cbFonts.Name = "cbFonts";
            cbFonts.Size = new Size(552, 29);
            cbFonts.TabIndex = 4;
            cbFonts.SelectedIndexChanged += cbFonts_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 90);
            label3.Name = "label3";
            label3.Size = new Size(94, 21);
            label3.TabIndex = 5;
            label3.Text = "Font Name :";
            // 
            // lblFontName
            // 
            lblFontName.AutoSize = true;
            lblFontName.Location = new Point(106, 90);
            lblFontName.Name = "lblFontName";
            lblFontName.Size = new Size(190, 21);
            lblFontName.TabIndex = 6;
            lblFontName.Text = "------------------------------";
            // 
            // nudFontSize
            // 
            nudFontSize.Location = new Point(381, 86);
            nudFontSize.Minimum = new decimal(new int[] { 9, 0, 0, 0 });
            nudFontSize.Name = "nudFontSize";
            nudFontSize.Size = new Size(51, 29);
            nudFontSize.TabIndex = 7;
            nudFontSize.Value = new decimal(new int[] { 12, 0, 0, 0 });
            nudFontSize.ValueChanged += nudFontSize_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(332, 90);
            label4.Name = "label4";
            label4.Size = new Size(45, 21);
            label4.TabIndex = 8;
            label4.Text = "Size :";
            // 
            // cbBold
            // 
            cbBold.AutoSize = true;
            cbBold.Location = new Point(438, 88);
            cbBold.Name = "cbBold";
            cbBold.Size = new Size(60, 25);
            cbBold.TabIndex = 9;
            cbBold.Text = "Bold";
            cbBold.UseVisualStyleBackColor = true;
            cbBold.CheckedChanged += cbBold_CheckedChanged;
            // 
            // cbItalic
            // 
            cbItalic.AutoSize = true;
            cbItalic.Location = new Point(602, 88);
            cbItalic.Name = "cbItalic";
            cbItalic.Size = new Size(61, 25);
            cbItalic.TabIndex = 10;
            cbItalic.Text = "Italic";
            cbItalic.UseVisualStyleBackColor = true;
            cbItalic.CheckedChanged += cbItalic_CheckedChanged;
            // 
            // cbUnderLine
            // 
            cbUnderLine.AutoSize = true;
            cbUnderLine.Location = new Point(499, 88);
            cbUnderLine.Name = "cbUnderLine";
            cbUnderLine.Size = new Size(101, 25);
            cbUnderLine.TabIndex = 11;
            cbUnderLine.Text = "UnderLine";
            cbUnderLine.UseVisualStyleBackColor = true;
            cbUnderLine.CheckedChanged += cbUnderLine_CheckedChanged;
            // 
            // txtContent
            // 
            txtContent.ContextMenuStrip = cms;
            txtContent.Location = new Point(12, 131);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(837, 313);
            txtContent.TabIndex = 0;
            // 
            // cms
            // 
            cms.Items.AddRange(new ToolStripItem[] { copyToolStripMenuItem, pasteToolStripMenuItem, pasteToolStripMenuItem1, fontSettingsToolStripMenuItem });
            cms.Name = "cms";
            cms.Size = new Size(144, 92);
            // 
            // copyToolStripMenuItem
            // 
            copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            copyToolStripMenuItem.Size = new Size(143, 22);
            copyToolStripMenuItem.Text = "Copy";
            copyToolStripMenuItem.Click += copyToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem
            // 
            pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            pasteToolStripMenuItem.Size = new Size(143, 22);
            pasteToolStripMenuItem.Text = "Cut";
            pasteToolStripMenuItem.Click += pasteToolStripMenuItem_Click;
            // 
            // pasteToolStripMenuItem1
            // 
            pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            pasteToolStripMenuItem1.Size = new Size(143, 22);
            pasteToolStripMenuItem1.Text = "Paste";
            pasteToolStripMenuItem1.Click += pasteToolStripMenuItem1_Click;
            // 
            // fontSettingsToolStripMenuItem
            // 
            fontSettingsToolStripMenuItem.Name = "fontSettingsToolStripMenuItem";
            fontSettingsToolStripMenuItem.Size = new Size(143, 22);
            fontSettingsToolStripMenuItem.Text = "Font Settings";
            fontSettingsToolStripMenuItem.Click += fontSettingsToolStripMenuItem_Click;
            // 
            // ep
            // 
            ep.ContainerControl = this;
            // 
            // btnChangeFont
            // 
            btnChangeFont.Location = new Point(685, 50);
            btnChangeFont.Name = "btnChangeFont";
            btnChangeFont.Size = new Size(164, 29);
            btnChangeFont.TabIndex = 12;
            btnChangeFont.Text = "Change Font";
            btnChangeFont.UseVisualStyleBackColor = true;
            btnChangeFont.Click += btnChangeFont_Click;
            // 
            // btnDefault
            // 
            btnDefault.Location = new Point(685, 86);
            btnDefault.Name = "btnDefault";
            btnDefault.Size = new Size(164, 29);
            btnDefault.TabIndex = 13;
            btnDefault.Text = "Set to default";
            btnDefault.UseVisualStyleBackColor = true;
            btnDefault.Click += btnDefault_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(861, 456);
            Controls.Add(btnDefault);
            Controls.Add(btnChangeFont);
            Controls.Add(txtContent);
            Controls.Add(cbUnderLine);
            Controls.Add(cbItalic);
            Controls.Add(cbBold);
            Controls.Add(label4);
            Controls.Add(nudFontSize);
            Controls.Add(lblFontName);
            Controls.Add(label3);
            Controls.Add(cbFonts);
            Controls.Add(label2);
            Controls.Add(btnSave);
            Controls.Add(txtFileName);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notebook App";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)nudFontSize).EndInit();
            cms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ep).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFileName;
        private Button btnSave;
        private Label label2;
        private ComboBox cbFonts;
        private Label label3;
        private Label lblFontName;
        private NumericUpDown nudFontSize;
        private Label label4;
        private CheckBox cbBold;
        private CheckBox cbItalic;
        private CheckBox cbUnderLine;
        private TextBox txtContent;
        private ErrorProvider ep;
        private Button btnChangeFont;
        private Button btnDefault;
        private ContextMenuStrip cms;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem1;
        private ToolStripMenuItem fontSettingsToolStripMenuItem;
    }
}
