namespace _008_DeleteControls
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
            label2 = new Label();
            txtName = new TextBox();
            btnAdd = new Button();
            txtDepartement = new TextBox();
            label3 = new Label();
            txtAddress = new TextBox();
            label4 = new Label();
            btnFind = new Button();
            btnClose = new Button();
            btnMoreInfo = new Button();
            btnDeleteControls = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ink Free", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(235, 18);
            label1.Name = "label1";
            label1.Size = new Size(146, 23);
            label1.TabIndex = 0;
            label1.Text = "Delete Controls";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(30, 91);
            label2.Name = "label2";
            label2.Size = new Size(53, 21);
            label2.TabIndex = 1;
            label2.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(143, 91);
            txtName.Name = "txtName";
            txtName.Size = new Size(303, 29);
            txtName.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.Salmon;
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.ForeColor = Color.White;
            btnAdd.Location = new Point(30, 267);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(114, 33);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add new";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // txtDepartement
            // 
            txtDepartement.Location = new Point(143, 139);
            txtDepartement.Name = "txtDepartement";
            txtDepartement.Size = new Size(303, 29);
            txtDepartement.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(30, 141);
            label3.Name = "label3";
            label3.Size = new Size(107, 21);
            label3.TabIndex = 4;
            label3.Text = "Departement";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(143, 187);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(303, 29);
            txtAddress.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(30, 191);
            label4.Name = "label4";
            label4.Size = new Size(70, 21);
            label4.TabIndex = 6;
            label4.Text = "Address";
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.Salmon;
            btnFind.FlatStyle = FlatStyle.Flat;
            btnFind.ForeColor = Color.White;
            btnFind.Location = new Point(162, 267);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(114, 33);
            btnFind.TabIndex = 8;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Salmon;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(418, 267);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(114, 33);
            btnClose.TabIndex = 10;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            // 
            // btnMoreInfo
            // 
            btnMoreInfo.BackColor = Color.Salmon;
            btnMoreInfo.FlatStyle = FlatStyle.Flat;
            btnMoreInfo.ForeColor = Color.White;
            btnMoreInfo.Location = new Point(289, 267);
            btnMoreInfo.Name = "btnMoreInfo";
            btnMoreInfo.Size = new Size(114, 33);
            btnMoreInfo.TabIndex = 9;
            btnMoreInfo.Text = "More Info";
            btnMoreInfo.UseVisualStyleBackColor = false;
            // 
            // btnDeleteControls
            // 
            btnDeleteControls.BackColor = Color.Red;
            btnDeleteControls.FlatStyle = FlatStyle.Flat;
            btnDeleteControls.ForeColor = Color.White;
            btnDeleteControls.Location = new Point(481, 92);
            btnDeleteControls.Name = "btnDeleteControls";
            btnDeleteControls.Size = new Size(114, 71);
            btnDeleteControls.TabIndex = 11;
            btnDeleteControls.Text = "Delete Controls";
            btnDeleteControls.UseVisualStyleBackColor = false;
            btnDeleteControls.Click += btnDeleteControls_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(468, 166);
            label5.Name = "label5";
            label5.Size = new Size(141, 17);
            label5.TabIndex = 12;
            label5.Text = "Click to delete controls";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            ClientSize = new Size(639, 335);
            Controls.Add(label5);
            Controls.Add(btnDeleteControls);
            Controls.Add(btnClose);
            Controls.Add(btnMoreInfo);
            Controls.Add(btnFind);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(txtDepartement);
            Controls.Add(label3);
            Controls.Add(btnAdd);
            Controls.Add(txtName);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 4, 4, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Delete Controls";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtName;
        private Button btnAdd;
        private TextBox txtDepartement;
        private Label label3;
        private TextBox txtAddress;
        private Label label4;
        private Button btnFind;
        private Button btnClose;
        private Button btnMoreInfo;
        private Button btnDeleteControls;
        private Label label5;
    }
}
