namespace _011_ListBox_DateTimePicker_ProgressBasr_MaskedTextBox
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
            lblTitle = new Label();
            groupBox1 = new GroupBox();
            cbEventType = new ComboBox();
            dtpRegistrationDate = new DateTimePicker();
            maskedTxtPhoneNumber = new MaskedTextBox();
            txtFullName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnAddParticipant = new Button();
            listBoxParticipant = new ListBox();
            pbMaxParticipants = new ProgressBar();
            lblParticipantsNumber = new Label();
            label6 = new Label();
            label7 = new Label();
            lblTimeNow = new Label();
            colorDialog1 = new ColorDialog();
            lblChangeBg = new Label();
            lblRestBgColor = new Label();
            timer = new System.Windows.Forms.Timer(components);
            linkGotoWebsite = new LinkLabel();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("MV Boli", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.Black;
            lblTitle.Location = new Point(496, 24);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(312, 28);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Event Registration Manager";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbEventType);
            groupBox1.Controls.Add(dtpRegistrationDate);
            groupBox1.Controls.Add(maskedTxtPhoneNumber);
            groupBox1.Controls.Add(txtFullName);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Black;
            groupBox1.Location = new Point(44, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(500, 185);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Participant Information :";
            // 
            // cbEventType
            // 
            cbEventType.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbEventType.FormattingEnabled = true;
            cbEventType.Items.AddRange(new object[] { "Workshop", "Seminar", "Competition", "Training" });
            cbEventType.Location = new Point(163, 132);
            cbEventType.Name = "cbEventType";
            cbEventType.Size = new Size(332, 29);
            cbEventType.TabIndex = 9;
            cbEventType.Text = "Event Type";
            // 
            // dtpRegistrationDate
            // 
            dtpRegistrationDate.Location = new Point(163, 99);
            dtpRegistrationDate.Name = "dtpRegistrationDate";
            dtpRegistrationDate.Size = new Size(332, 29);
            dtpRegistrationDate.TabIndex = 8;
            // 
            // maskedTxtPhoneNumber
            // 
            maskedTxtPhoneNumber.Location = new Point(163, 66);
            maskedTxtPhoneNumber.Mask = "(999) 000 00 00 00";
            maskedTxtPhoneNumber.Name = "maskedTxtPhoneNumber";
            maskedTxtPhoneNumber.PromptChar = '0';
            maskedTxtPhoneNumber.Size = new Size(332, 29);
            maskedTxtPhoneNumber.TabIndex = 7;
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(163, 34);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(332, 29);
            txtFullName.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 136);
            label5.Name = "label5";
            label5.Size = new Size(97, 21);
            label5.TabIndex = 5;
            label5.Text = "Event Type :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 103);
            label4.Name = "label4";
            label4.Size = new Size(145, 21);
            label4.TabIndex = 4;
            label4.Text = "Registration Date :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 70);
            label3.Name = "label3";
            label3.Size = new Size(128, 21);
            label3.TabIndex = 3;
            label3.Text = "Phone Number :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 37);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 2;
            label2.Text = "Full Name :";
            // 
            // btnAddParticipant
            // 
            btnAddParticipant.BackColor = Color.Black;
            btnAddParticipant.FlatStyle = FlatStyle.Flat;
            btnAddParticipant.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddParticipant.ForeColor = Color.White;
            btnAddParticipant.Location = new Point(207, 288);
            btnAddParticipant.Name = "btnAddParticipant";
            btnAddParticipant.Size = new Size(332, 42);
            btnAddParticipant.TabIndex = 2;
            btnAddParticipant.Text = "Add Participant";
            btnAddParticipant.UseVisualStyleBackColor = false;
            btnAddParticipant.Click += btnAddParticipant_Click;
            // 
            // listBoxParticipant
            // 
            listBoxParticipant.FormattingEnabled = true;
            listBoxParticipant.ItemHeight = 21;
            listBoxParticipant.Location = new Point(643, 131);
            listBoxParticipant.Name = "listBoxParticipant";
            listBoxParticipant.Size = new Size(603, 193);
            listBoxParticipant.TabIndex = 3;
            listBoxParticipant.SelectedIndexChanged += listBoxParticipant_SelectedIndexChanged;
            // 
            // pbMaxParticipants
            // 
            pbMaxParticipants.Location = new Point(643, 331);
            pbMaxParticipants.Maximum = 10;
            pbMaxParticipants.Name = "pbMaxParticipants";
            pbMaxParticipants.Size = new Size(603, 23);
            pbMaxParticipants.TabIndex = 4;
            // 
            // lblParticipantsNumber
            // 
            lblParticipantsNumber.AutoSize = true;
            lblParticipantsNumber.Location = new Point(875, 358);
            lblParticipantsNumber.Name = "lblParticipantsNumber";
            lblParticipantsNumber.Size = new Size(138, 21);
            lblParticipantsNumber.TabIndex = 5;
            lblParticipantsNumber.Text = "Participants: 0 / 10";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(643, 107);
            label6.Name = "label6";
            label6.Size = new Size(153, 21);
            label6.TabIndex = 6;
            label6.Text = "List pf participants :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F);
            label7.Location = new Point(15, 400);
            label7.Name = "label7";
            label7.Size = new Size(80, 15);
            label7.TabIndex = 7;
            label7.Text = "Current time :";
            // 
            // lblTimeNow
            // 
            lblTimeNow.AutoSize = true;
            lblTimeNow.Font = new Font("Segoe UI", 9F);
            lblTimeNow.Location = new Point(94, 400);
            lblTimeNow.Name = "lblTimeNow";
            lblTimeNow.Size = new Size(110, 15);
            lblTimeNow.TabIndex = 8;
            lblTimeNow.Text = "dd/mm/yyyy  00:00";
            // 
            // lblChangeBg
            // 
            lblChangeBg.AutoSize = true;
            lblChangeBg.Font = new Font("Segoe UI", 9F);
            lblChangeBg.Location = new Point(1147, 400);
            lblChangeBg.Name = "lblChangeBg";
            lblChangeBg.Size = new Size(145, 15);
            lblChangeBg.TabIndex = 9;
            lblChangeBg.Text = "Change background color";
            lblChangeBg.Click += lblChangeBg_Click;
            // 
            // lblRestBgColor
            // 
            lblRestBgColor.AutoSize = true;
            lblRestBgColor.Font = new Font("Segoe UI", 9F);
            lblRestBgColor.Location = new Point(1012, 400);
            lblRestBgColor.Name = "lblRestBgColor";
            lblRestBgColor.Size = new Size(126, 15);
            lblRestBgColor.TabIndex = 10;
            lblRestBgColor.Text = "Rest background color";
            lblRestBgColor.Click += lblRestBgColor_Click;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            // 
            // linkGotoWebsite
            // 
            linkGotoWebsite.AutoSize = true;
            linkGotoWebsite.Font = new Font("Segoe UI", 9F);
            linkGotoWebsite.LinkColor = Color.Black;
            linkGotoWebsite.Location = new Point(909, 400);
            linkGotoWebsite.Name = "linkGotoWebsite";
            linkGotoWebsite.Size = new Size(100, 15);
            linkGotoWebsite.TabIndex = 11;
            linkGotoWebsite.TabStop = true;
            linkGotoWebsite.Text = "Go to our website";
            linkGotoWebsite.LinkClicked += linkGotoWebsite_LinkClicked;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1304, 427);
            Controls.Add(linkGotoWebsite);
            Controls.Add(lblRestBgColor);
            Controls.Add(lblChangeBg);
            Controls.Add(lblTimeNow);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(lblParticipantsNumber);
            Controls.Add(pbMaxParticipants);
            Controls.Add(listBoxParticipant);
            Controls.Add(btnAddParticipant);
            Controls.Add(groupBox1);
            Controls.Add(lblTitle);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Event Registration Manager";
            Load += Form1_Load;
            ResizeEnd += Form1_ResizeEnd;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private GroupBox groupBox1;
        private Label label2;
        private Label label3;
        private ComboBox cbEventType;
        private DateTimePicker dtpRegistrationDate;
        private MaskedTextBox maskedTxtPhoneNumber;
        private TextBox txtFullName;
        private Label label5;
        private Label label4;
        private Button btnAddParticipant;
        private ListBox listBoxParticipant;
        private ProgressBar pbMaxParticipants;
        private Label lblParticipantsNumber;
        private Label label6;
        private Label label7;
        private Label lblTimeNow;
        private ColorDialog colorDialog1;
        private Label lblChangeBg;
        private Label lblRestBgColor;
        private System.Windows.Forms.Timer timer;
        private LinkLabel linkGotoWebsite;
    }
}
