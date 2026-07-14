namespace _017_ImageList
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
            components = new System.ComponentModel.Container();
            TreeNode treeNode7 = new TreeNode("Home", 0, 0);
            TreeNode treeNode8 = new TreeNode("People", 2, 2);
            TreeNode treeNode9 = new TreeNode("Settings", 4, 4);
            TreeNode treeNode10 = new TreeNode("Users", 1, 1);
            TreeNode treeNode11 = new TreeNode("Data", 3, 3);
            TreeNode treeNode12 = new TreeNode("Exit", 5, 5);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            tvForms = new TreeView();
            imageList1 = new ImageList(components);
            SuspendLayout();
            // 
            // tvForms
            // 
            tvForms.Dock = DockStyle.Left;
            tvForms.ImageIndex = 0;
            tvForms.ImageList = imageList1;
            tvForms.Location = new Point(0, 0);
            tvForms.Name = "tvForms";
            treeNode7.ImageIndex = 0;
            treeNode7.Name = "Node0";
            treeNode7.SelectedImageIndex = 0;
            treeNode7.Text = "Home";
            treeNode8.ImageIndex = 2;
            treeNode8.Name = "Node1";
            treeNode8.SelectedImageIndex = 2;
            treeNode8.Text = "People";
            treeNode9.ImageIndex = 4;
            treeNode9.Name = "Node2";
            treeNode9.SelectedImageIndex = 4;
            treeNode9.Text = "Settings";
            treeNode10.ImageIndex = 1;
            treeNode10.Name = "Node3";
            treeNode10.SelectedImageIndex = 1;
            treeNode10.Text = "Users";
            treeNode11.ImageIndex = 3;
            treeNode11.Name = "Node5";
            treeNode11.SelectedImageIndex = 3;
            treeNode11.Text = "Data";
            treeNode12.ImageIndex = 5;
            treeNode12.Name = "Node4";
            treeNode12.SelectedImageIndex = 5;
            treeNode12.Text = "Exit";
            tvForms.Nodes.AddRange(new TreeNode[] { treeNode7, treeNode8, treeNode9, treeNode10, treeNode11, treeNode12 });
            tvForms.SelectedImageIndex = 0;
            tvForms.Size = new Size(158, 502);
            tvForms.TabIndex = 0;
            tvForms.AfterSelect += tvForms_AfterSelect;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "home_32.png");
            imageList1.Images.SetKeyName(1, "administrator_32.png");
            imageList1.Images.SetKeyName(2, "group_32.png");
            imageList1.Images.SetKeyName(3, "data_management_32.png");
            imageList1.Images.SetKeyName(4, "account_settings_32.png");
            imageList1.Images.SetKeyName(5, "exit_32.png");
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1010, 502);
            Controls.Add(tvForms);
            Font = new Font("Segoe UI", 14F);
            IsMdiContainer = true;
            Margin = new Padding(5, 5, 5, 5);
            Name = "frmMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DashBoard";
            ResumeLayout(false);
        }

        #endregion

        private TreeView tvForms;
        private ImageList imageList1;
    }
}
