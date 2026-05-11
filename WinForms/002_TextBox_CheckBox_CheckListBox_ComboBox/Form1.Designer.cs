namespace _002_TextBox_CheckBox_CheckListBox_ComboBox
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
            txtBoxName = new TextBox();
            cbPizzaSize = new ComboBox();
            label2 = new Label();
            ckBox_Cheese = new CheckBox();
            ckListBox_Topping = new CheckedListBox();
            label3 = new Label();
            label4 = new Label();
            btnOrder = new Button();
            btnEmptyFields = new Button();
            toolTip1 = new ToolTip(components);
            btnClose = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 91);
            label1.Name = "label1";
            label1.Size = new Size(141, 21);
            label1.TabIndex = 0;
            label1.Text = "Customer Name :";
            // 
            // txtBoxName
            // 
            txtBoxName.BorderStyle = BorderStyle.FixedSingle;
            txtBoxName.Location = new Point(183, 87);
            txtBoxName.Name = "txtBoxName";
            txtBoxName.Size = new Size(260, 29);
            txtBoxName.TabIndex = 1;
            toolTip1.SetToolTip(txtBoxName, "Please enter your name");
            // 
            // cbPizzaSize
            // 
            cbPizzaSize.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbPizzaSize.FormattingEnabled = true;
            cbPizzaSize.Items.AddRange(new object[] { "Small", "Meduim", "Large" });
            cbPizzaSize.Location = new Point(183, 125);
            cbPizzaSize.Name = "cbPizzaSize";
            cbPizzaSize.Size = new Size(260, 29);
            cbPizzaSize.TabIndex = 2;
            cbPizzaSize.Text = "Choose Size";
            toolTip1.SetToolTip(cbPizzaSize, "Please select pizza size");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 129);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 3;
            label2.Text = "Pizza Size :";
            // 
            // ckBox_Cheese
            // 
            ckBox_Cheese.AutoSize = true;
            ckBox_Cheese.Location = new Point(183, 169);
            ckBox_Cheese.Name = "ckBox_Cheese";
            ckBox_Cheese.Size = new Size(126, 25);
            ckBox_Cheese.TabIndex = 5;
            ckBox_Cheese.Tag = "10";
            ckBox_Cheese.Text = "Extra Cheese";
            ckBox_Cheese.UseVisualStyleBackColor = true;
            // 
            // ckListBox_Topping
            // 
            ckListBox_Topping.BorderStyle = BorderStyle.None;
            ckListBox_Topping.CheckOnClick = true;
            ckListBox_Topping.FormattingEnabled = true;
            ckListBox_Topping.Items.AddRange(new object[] { "Olives", "Mushrooms", "Tuna", "Onion", "Corn" });
            ckListBox_Topping.Location = new Point(183, 197);
            ckListBox_Topping.Name = "ckListBox_Topping";
            ckListBox_Topping.Size = new Size(260, 120);
            ckListBox_Topping.TabIndex = 6;
            ckListBox_Topping.Tag = "5";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 171);
            label3.Name = "label3";
            label3.Size = new Size(88, 21);
            label3.TabIndex = 7;
            label3.Text = "Toppings :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Tomato;
            label4.Location = new Point(183, 23);
            label4.Name = "label4";
            label4.Size = new Size(156, 25);
            label4.TabIndex = 8;
            label4.Text = "Pizza Order App";
            // 
            // btnOrder
            // 
            btnOrder.BackColor = Color.Tomato;
            btnOrder.FlatStyle = FlatStyle.Flat;
            btnOrder.ForeColor = Color.White;
            btnOrder.Location = new Point(361, 348);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(135, 45);
            btnOrder.TabIndex = 9;
            btnOrder.Text = "Place order";
            btnOrder.UseVisualStyleBackColor = false;
            btnOrder.Click += btnOrder_Click;
            // 
            // btnEmptyFields
            // 
            btnEmptyFields.BackColor = Color.Tomato;
            btnEmptyFields.FlatStyle = FlatStyle.Flat;
            btnEmptyFields.ForeColor = Color.White;
            btnEmptyFields.Location = new Point(220, 348);
            btnEmptyFields.Name = "btnEmptyFields";
            btnEmptyFields.Size = new Size(135, 45);
            btnEmptyFields.TabIndex = 10;
            btnEmptyFields.Text = "Empty fields";
            btnEmptyFields.UseVisualStyleBackColor = false;
            btnEmptyFields.Click += btnEmptyFields_Click;
            // 
            // toolTip1
            // 
            toolTip1.AutomaticDelay = 10;
            toolTip1.AutoPopDelay = 1000;
            toolTip1.InitialDelay = 10;
            toolTip1.ReshowDelay = 2;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Tomato;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(79, 348);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(135, 45);
            btnClose.TabIndex = 11;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(528, 425);
            Controls.Add(btnClose);
            Controls.Add(btnEmptyFields);
            Controls.Add(btnOrder);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(ckListBox_Topping);
            Controls.Add(ckBox_Cheese);
            Controls.Add(label2);
            Controls.Add(cbPizzaSize);
            Controls.Add(txtBoxName);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pizza Order App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtBoxName;
        private ComboBox cbPizzaSize;
        private Label label2;
        private CheckBox ckBox_Cheese;
        private CheckedListBox ckListBox_Topping;
        private Label label3;
        private Label label4;
        private Button btnOrder;
        private Button btnEmptyFields;
        private ToolTip toolTip1;
        private Button btnClose;
    }
}
