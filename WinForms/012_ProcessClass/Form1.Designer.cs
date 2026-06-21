namespace _012_ProcessClass
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
            btnOpenTestFolder = new Button();
            btnOpenPicture = new Button();
            btnOpenFilManagerApp = new Button();
            btnOpenTestFile = new Button();
            btnOpenBook = new Button();
            btnOpenPersonDataApp = new Button();
            btnOpenCdrive = new Button();
            btnOpenCalculator = new Button();
            btnOpenHTMLpage = new Button();
            txtPath = new TextBox();
            brnBrowser = new Button();
            label2 = new Label();
            btnExit = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(265, 9);
            label1.Name = "label1";
            label1.Size = new Size(229, 40);
            label1.TabIndex = 0;
            label1.Text = "Quick Launcher";
            // 
            // btnOpenTestFolder
            // 
            btnOpenTestFolder.BackColor = Color.White;
            btnOpenTestFolder.FlatStyle = FlatStyle.Flat;
            btnOpenTestFolder.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOpenTestFolder.ForeColor = Color.Black;
            btnOpenTestFolder.Location = new Point(38, 75);
            btnOpenTestFolder.Name = "btnOpenTestFolder";
            btnOpenTestFolder.Size = new Size(206, 52);
            btnOpenTestFolder.TabIndex = 1;
            btnOpenTestFolder.Text = "Open Test Folder";
            btnOpenTestFolder.UseVisualStyleBackColor = false;
            btnOpenTestFolder.Click += btnOpenTestFolder_Click;
            // 
            // btnOpenPicture
            // 
            btnOpenPicture.BackColor = Color.White;
            btnOpenPicture.FlatStyle = FlatStyle.Flat;
            btnOpenPicture.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOpenPicture.ForeColor = Color.Black;
            btnOpenPicture.Location = new Point(276, 75);
            btnOpenPicture.Name = "btnOpenPicture";
            btnOpenPicture.Size = new Size(206, 52);
            btnOpenPicture.TabIndex = 2;
            btnOpenPicture.Text = "Open Picture";
            btnOpenPicture.UseVisualStyleBackColor = false;
            btnOpenPicture.Click += btnOpenPicture_Click;
            // 
            // btnOpenFilManagerApp
            // 
            btnOpenFilManagerApp.BackColor = Color.White;
            btnOpenFilManagerApp.FlatStyle = FlatStyle.Flat;
            btnOpenFilManagerApp.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOpenFilManagerApp.ForeColor = Color.Black;
            btnOpenFilManagerApp.Location = new Point(508, 75);
            btnOpenFilManagerApp.Name = "btnOpenFilManagerApp";
            btnOpenFilManagerApp.Size = new Size(206, 52);
            btnOpenFilManagerApp.TabIndex = 3;
            btnOpenFilManagerApp.Text = "Open FileManager App";
            btnOpenFilManagerApp.UseVisualStyleBackColor = false;
            btnOpenFilManagerApp.Click += btnOpenFilManagerApp_Click;
            // 
            // btnOpenTestFile
            // 
            btnOpenTestFile.BackColor = Color.White;
            btnOpenTestFile.FlatStyle = FlatStyle.Flat;
            btnOpenTestFile.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOpenTestFile.ForeColor = Color.Black;
            btnOpenTestFile.Location = new Point(508, 161);
            btnOpenTestFile.Name = "btnOpenTestFile";
            btnOpenTestFile.Size = new Size(206, 52);
            btnOpenTestFile.TabIndex = 6;
            btnOpenTestFile.Text = "Open Test File";
            btnOpenTestFile.UseVisualStyleBackColor = false;
            btnOpenTestFile.Click += btnOpenTestFile_Click;
            // 
            // btnOpenBook
            // 
            btnOpenBook.BackColor = Color.White;
            btnOpenBook.FlatStyle = FlatStyle.Flat;
            btnOpenBook.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOpenBook.ForeColor = Color.Black;
            btnOpenBook.Location = new Point(276, 161);
            btnOpenBook.Name = "btnOpenBook";
            btnOpenBook.Size = new Size(206, 52);
            btnOpenBook.TabIndex = 5;
            btnOpenBook.Text = "Open Test Book";
            btnOpenBook.UseVisualStyleBackColor = false;
            btnOpenBook.Click += btnOpenBook_Click;
            // 
            // btnOpenPersonDataApp
            // 
            btnOpenPersonDataApp.BackColor = Color.White;
            btnOpenPersonDataApp.FlatStyle = FlatStyle.Flat;
            btnOpenPersonDataApp.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOpenPersonDataApp.ForeColor = Color.Black;
            btnOpenPersonDataApp.Location = new Point(38, 161);
            btnOpenPersonDataApp.Name = "btnOpenPersonDataApp";
            btnOpenPersonDataApp.Size = new Size(206, 52);
            btnOpenPersonDataApp.TabIndex = 4;
            btnOpenPersonDataApp.Text = "Open Person Data App";
            btnOpenPersonDataApp.UseVisualStyleBackColor = false;
            btnOpenPersonDataApp.Click += btnOpenPersonDataApp_Click;
            // 
            // btnOpenCdrive
            // 
            btnOpenCdrive.BackColor = Color.White;
            btnOpenCdrive.FlatStyle = FlatStyle.Flat;
            btnOpenCdrive.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOpenCdrive.ForeColor = Color.Black;
            btnOpenCdrive.Location = new Point(508, 247);
            btnOpenCdrive.Name = "btnOpenCdrive";
            btnOpenCdrive.Size = new Size(206, 52);
            btnOpenCdrive.TabIndex = 9;
            btnOpenCdrive.Text = "Open C Drive";
            btnOpenCdrive.UseVisualStyleBackColor = false;
            btnOpenCdrive.Click += btnOpenCdrive_Click;
            // 
            // btnOpenCalculator
            // 
            btnOpenCalculator.BackColor = Color.White;
            btnOpenCalculator.FlatStyle = FlatStyle.Flat;
            btnOpenCalculator.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOpenCalculator.ForeColor = Color.Black;
            btnOpenCalculator.Location = new Point(276, 247);
            btnOpenCalculator.Name = "btnOpenCalculator";
            btnOpenCalculator.Size = new Size(206, 52);
            btnOpenCalculator.TabIndex = 8;
            btnOpenCalculator.Text = "Open Calculator App";
            btnOpenCalculator.UseVisualStyleBackColor = false;
            btnOpenCalculator.Click += btnOpenCalculator_Click;
            // 
            // btnOpenHTMLpage
            // 
            btnOpenHTMLpage.BackColor = Color.White;
            btnOpenHTMLpage.FlatStyle = FlatStyle.Flat;
            btnOpenHTMLpage.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOpenHTMLpage.ForeColor = Color.Black;
            btnOpenHTMLpage.Location = new Point(38, 247);
            btnOpenHTMLpage.Name = "btnOpenHTMLpage";
            btnOpenHTMLpage.Size = new Size(206, 52);
            btnOpenHTMLpage.TabIndex = 7;
            btnOpenHTMLpage.Text = "Open HTML Page";
            btnOpenHTMLpage.UseVisualStyleBackColor = false;
            btnOpenHTMLpage.Click += btnOpenHTMLpage_Click;
            // 
            // txtPath
            // 
            txtPath.Location = new Point(38, 344);
            txtPath.Name = "txtPath";
            txtPath.Size = new Size(444, 29);
            txtPath.TabIndex = 10;
            // 
            // brnBrowser
            // 
            brnBrowser.BackColor = Color.White;
            brnBrowser.FlatStyle = FlatStyle.Flat;
            brnBrowser.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            brnBrowser.ForeColor = Color.Black;
            brnBrowser.Location = new Point(508, 344);
            brnBrowser.Name = "brnBrowser";
            brnBrowser.Size = new Size(206, 29);
            brnBrowser.TabIndex = 11;
            brnBrowser.Text = "Browser";
            brnBrowser.UseVisualStyleBackColor = false;
            brnBrowser.Click += brnBrowser_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 320);
            label2.Name = "label2";
            label2.Size = new Size(57, 21);
            label2.TabIndex = 12;
            label2.Text = "Phath :";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.White;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(38, 410);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(676, 33);
            btnExit.TabIndex = 13;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OliveDrab;
            ClientSize = new Size(762, 479);
            Controls.Add(btnExit);
            Controls.Add(label2);
            Controls.Add(brnBrowser);
            Controls.Add(txtPath);
            Controls.Add(btnOpenCdrive);
            Controls.Add(btnOpenCalculator);
            Controls.Add(btnOpenHTMLpage);
            Controls.Add(btnOpenTestFile);
            Controls.Add(btnOpenBook);
            Controls.Add(btnOpenPersonDataApp);
            Controls.Add(btnOpenFilManagerApp);
            Controls.Add(btnOpenPicture);
            Controls.Add(btnOpenTestFolder);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F);
            ForeColor = Color.White;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnOpenTestFolder;
        private Button btnOpenPicture;
        private Button btnOpenFilManagerApp;
        private Button btnOpenTestFile;
        private Button btnOpenBook;
        private Button btnOpenPersonDataApp;
        private Button btnOpenCdrive;
        private Button btnOpenCalculator;
        private Button btnOpenHTMLpage;
        private TextBox txtPath;
        private Button brnBrowser;
        private Label label2;
        private Button btnExit;
    }
}
