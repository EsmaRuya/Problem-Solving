namespace _016_ListView_FolderBrwoserDialog_TreeView
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
            btnBrwoser = new Button();
            rbFolders = new RadioButton();
            rbFiles = new RadioButton();
            lvShowData = new ListView();
            columnHeader0 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            treeView = new TreeView();
            SuspendLayout();
            // 
            // btnBrwoser
            // 
            btnBrwoser.Location = new Point(172, 26);
            btnBrwoser.Name = "btnBrwoser";
            btnBrwoser.Size = new Size(143, 31);
            btnBrwoser.TabIndex = 7;
            btnBrwoser.Text = "Brwoser";
            btnBrwoser.UseVisualStyleBackColor = true;
            btnBrwoser.Click += btnBrwoser_Click;
            // 
            // rbFolders
            // 
            rbFolders.AutoSize = true;
            rbFolders.Location = new Point(83, 29);
            rbFolders.Name = "rbFolders";
            rbFolders.Size = new Size(83, 25);
            rbFolders.TabIndex = 6;
            rbFolders.TabStop = true;
            rbFolders.Text = "Folders";
            rbFolders.UseVisualStyleBackColor = true;
            // 
            // rbFiles
            // 
            rbFiles.AutoSize = true;
            rbFiles.Location = new Point(15, 29);
            rbFiles.Name = "rbFiles";
            rbFiles.Size = new Size(62, 25);
            rbFiles.TabIndex = 5;
            rbFiles.TabStop = true;
            rbFiles.Text = "Files";
            rbFiles.UseVisualStyleBackColor = true;
            // 
            // lvShowData
            // 
            lvShowData.BorderStyle = BorderStyle.FixedSingle;
            lvShowData.Columns.AddRange(new ColumnHeader[] { columnHeader0, columnHeader1 });
            lvShowData.FullRowSelect = true;
            lvShowData.GridLines = true;
            lvShowData.Location = new Point(11, 76);
            lvShowData.MultiSelect = false;
            lvShowData.Name = "lvShowData";
            lvShowData.Size = new Size(1156, 352);
            lvShowData.TabIndex = 9;
            lvShowData.UseCompatibleStateImageBehavior = false;
            lvShowData.View = View.Details;
            // 
            // columnHeader0
            // 
            columnHeader0.Text = "File Name";
            columnHeader0.Width = 350;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Path";
            columnHeader1.Width = 800;
            // 
            // treeView
            // 
            treeView.Location = new Point(1173, 76);
            treeView.Name = "treeView";
            treeView.Size = new Size(276, 352);
            treeView.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1461, 478);
            Controls.Add(treeView);
            Controls.Add(lvShowData);
            Controls.Add(btnBrwoser);
            Controls.Add(rbFolders);
            Controls.Add(rbFiles);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnBrwoser;
        private RadioButton rbFolders;
        private RadioButton rbFiles;
        private ListView lvShowData;
        private ColumnHeader columnHeader0;
        private ColumnHeader columnHeader1;
        private TreeView treeView;
    }
}
