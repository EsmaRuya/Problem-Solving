namespace _019_ErrorProvider_Clipboard
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
            txtContent = new TextBox();
            label1 = new Label();
            btnCopy = new Button();
            btnCut = new Button();
            btnPaste = new Button();
            btnClearClipBpard = new Button();
            btnClear = new Button();
            ep = new ErrorProvider(components);
            pbImage = new PictureBox();
            label2 = new Label();
            btnClearimg = new Button();
            btnClearClipboardimg = new Button();
            btnPasteimg = new Button();
            btnCutimg = new Button();
            btnCopyimg = new Button();
            ((System.ComponentModel.ISupportInitialize)ep).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            SuspendLayout();
            // 
            // txtContent
            // 
            txtContent.Location = new Point(76, 46);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(402, 29);
            txtContent.TabIndex = 2;
            txtContent.Validating += txtContent_Validating;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 49);
            label1.Name = "label1";
            label1.Size = new Size(43, 21);
            label1.TabIndex = 1;
            label1.Text = "Text :";
            // 
            // btnCopy
            // 
            btnCopy.BackColor = Color.FromArgb(255, 128, 0);
            btnCopy.FlatStyle = FlatStyle.Flat;
            btnCopy.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCopy.ForeColor = Color.White;
            btnCopy.Location = new Point(76, 81);
            btnCopy.Name = "btnCopy";
            btnCopy.Size = new Size(96, 30);
            btnCopy.TabIndex = 0;
            btnCopy.Text = "Copy";
            btnCopy.UseVisualStyleBackColor = false;
            btnCopy.Click += btnCopy_Click;
            // 
            // btnCut
            // 
            btnCut.BackColor = Color.FromArgb(255, 128, 0);
            btnCut.FlatStyle = FlatStyle.Flat;
            btnCut.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCut.ForeColor = Color.White;
            btnCut.Location = new Point(178, 81);
            btnCut.Name = "btnCut";
            btnCut.Size = new Size(96, 30);
            btnCut.TabIndex = 3;
            btnCut.Text = "Cut";
            btnCut.UseVisualStyleBackColor = false;
            btnCut.Click += btnCut_Click;
            // 
            // btnPaste
            // 
            btnPaste.BackColor = Color.FromArgb(255, 128, 0);
            btnPaste.FlatStyle = FlatStyle.Flat;
            btnPaste.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPaste.ForeColor = Color.White;
            btnPaste.Location = new Point(280, 81);
            btnPaste.Name = "btnPaste";
            btnPaste.Size = new Size(96, 30);
            btnPaste.TabIndex = 4;
            btnPaste.Text = "Paste";
            btnPaste.UseVisualStyleBackColor = false;
            btnPaste.Click += btnPaste_Click;
            // 
            // btnClearClipBpard
            // 
            btnClearClipBpard.BackColor = Color.FromArgb(255, 128, 0);
            btnClearClipBpard.FlatStyle = FlatStyle.Flat;
            btnClearClipBpard.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClearClipBpard.ForeColor = Color.White;
            btnClearClipBpard.Location = new Point(76, 115);
            btnClearClipBpard.Name = "btnClearClipBpard";
            btnClearClipBpard.Size = new Size(402, 30);
            btnClearClipBpard.TabIndex = 5;
            btnClearClipBpard.Text = "Clear Clipboard";
            btnClearClipBpard.UseVisualStyleBackColor = false;
            btnClearClipBpard.Click += btnClearClipBpard_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(255, 128, 0);
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClear.ForeColor = Color.White;
            btnClear.Location = new Point(382, 81);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(96, 30);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // ep
            // 
            ep.ContainerControl = this;
            // 
            // pbImage
            // 
            pbImage.BorderStyle = BorderStyle.FixedSingle;
            pbImage.Image = Properties.Resources.Esma_Rüya;
            pbImage.Location = new Point(76, 190);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(402, 227);
            pbImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbImage.TabIndex = 7;
            pbImage.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 173);
            label2.Name = "label2";
            label2.Size = new Size(60, 21);
            label2.TabIndex = 8;
            label2.Text = "Image :";
            // 
            // btnClearimg
            // 
            btnClearimg.BackColor = Color.FromArgb(192, 192, 255);
            btnClearimg.FlatStyle = FlatStyle.Flat;
            btnClearimg.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClearimg.ForeColor = Color.White;
            btnClearimg.Location = new Point(382, 423);
            btnClearimg.Name = "btnClearimg";
            btnClearimg.Size = new Size(96, 30);
            btnClearimg.TabIndex = 13;
            btnClearimg.Text = "Clear";
            btnClearimg.UseVisualStyleBackColor = false;
            btnClearimg.Click += btnClearimg_Click;
            // 
            // btnClearClipboardimg
            // 
            btnClearClipboardimg.BackColor = Color.FromArgb(192, 192, 255);
            btnClearClipboardimg.FlatStyle = FlatStyle.Flat;
            btnClearClipboardimg.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnClearClipboardimg.ForeColor = Color.White;
            btnClearClipboardimg.Location = new Point(76, 457);
            btnClearClipboardimg.Name = "btnClearClipboardimg";
            btnClearClipboardimg.Size = new Size(402, 30);
            btnClearClipboardimg.TabIndex = 12;
            btnClearClipboardimg.Text = "Clear Clipboard";
            btnClearClipboardimg.UseVisualStyleBackColor = false;
            btnClearClipboardimg.Click += btnClearClipboardimg_Click;
            // 
            // btnPasteimg
            // 
            btnPasteimg.BackColor = Color.FromArgb(192, 192, 255);
            btnPasteimg.FlatStyle = FlatStyle.Flat;
            btnPasteimg.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnPasteimg.ForeColor = Color.White;
            btnPasteimg.Location = new Point(280, 423);
            btnPasteimg.Name = "btnPasteimg";
            btnPasteimg.Size = new Size(96, 30);
            btnPasteimg.TabIndex = 11;
            btnPasteimg.Text = "Paste";
            btnPasteimg.UseVisualStyleBackColor = false;
            btnPasteimg.Click += btnPasteimg_Click;
            // 
            // btnCutimg
            // 
            btnCutimg.BackColor = Color.FromArgb(192, 192, 255);
            btnCutimg.FlatStyle = FlatStyle.Flat;
            btnCutimg.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCutimg.ForeColor = Color.White;
            btnCutimg.Location = new Point(178, 423);
            btnCutimg.Name = "btnCutimg";
            btnCutimg.Size = new Size(96, 30);
            btnCutimg.TabIndex = 10;
            btnCutimg.Text = "Cut";
            btnCutimg.UseVisualStyleBackColor = false;
            btnCutimg.Click += btnCutimg_Click;
            // 
            // btnCopyimg
            // 
            btnCopyimg.BackColor = Color.FromArgb(192, 192, 255);
            btnCopyimg.FlatStyle = FlatStyle.Flat;
            btnCopyimg.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCopyimg.ForeColor = Color.White;
            btnCopyimg.Location = new Point(76, 423);
            btnCopyimg.Name = "btnCopyimg";
            btnCopyimg.Size = new Size(96, 30);
            btnCopyimg.TabIndex = 9;
            btnCopyimg.Text = "Copy";
            btnCopyimg.UseVisualStyleBackColor = false;
            btnCopyimg.Click += btnCopyimg_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(541, 513);
            Controls.Add(btnClearimg);
            Controls.Add(btnClearClipboardimg);
            Controls.Add(btnPasteimg);
            Controls.Add(btnCutimg);
            Controls.Add(btnCopyimg);
            Controls.Add(label2);
            Controls.Add(pbImage);
            Controls.Add(btnClear);
            Controls.Add(btnClearClipBpard);
            Controls.Add(btnPaste);
            Controls.Add(btnCut);
            Controls.Add(btnCopy);
            Controls.Add(label1);
            Controls.Add(txtContent);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Copy Paste";
            ((System.ComponentModel.ISupportInitialize)ep).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtContent;
        private Label label1;
        private Button btnCopy;
        private Button btnCut;
        private Button btnPaste;
        private Button btnClearClipBpard;
        private Button btnClear;
        private ErrorProvider ep;
        private Button btnClearimg;
        private Button btnClearClipboardimg;
        private Button btnPasteimg;
        private Button btnCutimg;
        private Button btnCopyimg;
        private Label label2;
        private PictureBox pbImage;
    }
}
