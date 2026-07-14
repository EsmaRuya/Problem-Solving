namespace _007_Practice
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
            btnAddNew = new Button();
            txtBox_ID = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtBox_Name = new TextBox();
            txtBox_Address = new TextBox();
            btnFind = new Button();
            btnShowAll = new Button();
            btnExit = new Button();
            toolTip1 = new ToolTip(components);
            btnAddPhoto = new Button();
            btnShowAllWithPictures = new Button();
            picPerson = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picPerson).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(255, 128, 128);
            label1.Location = new Point(273, 21);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 32);
            label1.TabIndex = 0;
            label1.Text = "Person Data";
            // 
            // btnAddNew
            // 
            btnAddNew.BackColor = Color.FromArgb(255, 128, 128);
            btnAddNew.FlatStyle = FlatStyle.Flat;
            btnAddNew.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddNew.ForeColor = Color.White;
            btnAddNew.Location = new Point(42, 238);
            btnAddNew.Margin = new Padding(4);
            btnAddNew.Name = "btnAddNew";
            btnAddNew.Size = new Size(115, 33);
            btnAddNew.TabIndex = 1;
            btnAddNew.Text = "Add New";
            toolTip1.SetToolTip(btnAddNew, "Add new");
            btnAddNew.UseVisualStyleBackColor = false;
            btnAddNew.Click += btnAddNew_Click;
            // 
            // txtBox_ID
            // 
            txtBox_ID.Location = new Point(148, 87);
            txtBox_ID.Margin = new Padding(4);
            txtBox_ID.Name = "txtBox_ID";
            txtBox_ID.Size = new Size(411, 29);
            txtBox_ID.TabIndex = 2;
            toolTip1.SetToolTip(txtBox_ID, "Enter your ID");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(52, 87);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(47, 25);
            label2.TabIndex = 3;
            label2.Text = "ID : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(52, 127);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 25);
            label3.TabIndex = 4;
            label3.Text = "Name : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(52, 168);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(98, 25);
            label4.TabIndex = 5;
            label4.Text = "Address : ";
            // 
            // txtBox_Name
            // 
            txtBox_Name.Location = new Point(148, 125);
            txtBox_Name.Margin = new Padding(4);
            txtBox_Name.Name = "txtBox_Name";
            txtBox_Name.Size = new Size(411, 29);
            txtBox_Name.TabIndex = 6;
            toolTip1.SetToolTip(txtBox_Name, "Enter your name");
            // 
            // txtBox_Address
            // 
            txtBox_Address.Location = new Point(148, 168);
            txtBox_Address.Margin = new Padding(4);
            txtBox_Address.Name = "txtBox_Address";
            txtBox_Address.Size = new Size(411, 29);
            txtBox_Address.TabIndex = 7;
            toolTip1.SetToolTip(txtBox_Address, "Enter your address");
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.FromArgb(255, 128, 128);
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFind.ForeColor = Color.White;
            btnFind.Location = new Point(176, 238);
            btnFind.Margin = new Padding(4);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(115, 33);
            btnFind.TabIndex = 8;
            btnFind.Text = "Find";
            toolTip1.SetToolTip(btnFind, "Find a person");
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.BackColor = Color.FromArgb(255, 128, 128);
            btnShowAll.FlatStyle = FlatStyle.Flat;
            btnShowAll.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowAll.ForeColor = Color.White;
            btnShowAll.Location = new Point(310, 238);
            btnShowAll.Margin = new Padding(4);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(115, 33);
            btnShowAll.TabIndex = 9;
            btnShowAll.Text = "Show All";
            toolTip1.SetToolTip(btnShowAll, "Show all people");
            btnShowAll.UseVisualStyleBackColor = false;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(255, 128, 128);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExit.ForeColor = Color.White;
            btnExit.Location = new Point(444, 238);
            btnExit.Margin = new Padding(4);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(115, 33);
            btnExit.TabIndex = 10;
            btnExit.Text = "Exit";
            toolTip1.SetToolTip(btnExit, "Exit");
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // toolTip1
            // 
            toolTip1.AutomaticDelay = 10;
            toolTip1.AutoPopDelay = 1000;
            toolTip1.InitialDelay = 10;
            toolTip1.ReshowDelay = 2;
            // 
            // btnAddPhoto
            // 
            btnAddPhoto.BackColor = Color.FromArgb(255, 128, 128);
            btnAddPhoto.FlatStyle = FlatStyle.Flat;
            btnAddPhoto.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddPhoto.ForeColor = Color.White;
            btnAddPhoto.Location = new Point(567, 245);
            btnAddPhoto.Margin = new Padding(4);
            btnAddPhoto.Name = "btnAddPhoto";
            btnAddPhoto.Size = new Size(136, 26);
            btnAddPhoto.TabIndex = 12;
            btnAddPhoto.Text = "Add Photo";
            toolTip1.SetToolTip(btnAddPhoto, "Add photo");
            btnAddPhoto.UseVisualStyleBackColor = false;
            btnAddPhoto.Click += btnAddPhoto_Click;
            // 
            // btnShowAllWithPictures
            // 
            btnShowAllWithPictures.BackColor = Color.FromArgb(255, 128, 128);
            btnShowAllWithPictures.FlatStyle = FlatStyle.Flat;
            btnShowAllWithPictures.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowAllWithPictures.ForeColor = Color.White;
            btnShowAllWithPictures.Location = new Point(42, 279);
            btnShowAllWithPictures.Margin = new Padding(4);
            btnShowAllWithPictures.Name = "btnShowAllWithPictures";
            btnShowAllWithPictures.Size = new Size(517, 26);
            btnShowAllWithPictures.TabIndex = 13;
            btnShowAllWithPictures.Text = "Show all wwith pictures";
            toolTip1.SetToolTip(btnShowAllWithPictures, "Show all with pictures");
            btnShowAllWithPictures.UseVisualStyleBackColor = false;
            btnShowAllWithPictures.Click += btnShowAllWithPictures_Click;
            // 
            // picPerson
            // 
            picPerson.BorderStyle = BorderStyle.FixedSingle;
            picPerson.Location = new Point(566, 87);
            picPerson.Name = "picPerson";
            picPerson.Size = new Size(136, 151);
            picPerson.SizeMode = PictureBoxSizeMode.StretchImage;
            picPerson.TabIndex = 11;
            picPerson.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(742, 324);
            Controls.Add(btnShowAllWithPictures);
            Controls.Add(btnAddPhoto);
            Controls.Add(picPerson);
            Controls.Add(btnExit);
            Controls.Add(btnShowAll);
            Controls.Add(btnFind);
            Controls.Add(txtBox_Address);
            Controls.Add(txtBox_Name);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtBox_ID);
            Controls.Add(btnAddNew);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PersonData";
            ((System.ComponentModel.ISupportInitialize)picPerson).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnAddNew;
        private TextBox txtBox_ID;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtBox_Name;
        private TextBox txtBox_Address;
        private Button btnFind;
        private Button btnShowAll;
        private Button btnExit;
        private ToolTip toolTip1;
        private PictureBox picPerson;
        private Button btnAddPhoto;
        private Button btnShowAllWithPictures;
    }
}
