using System.IO;

using System.Threading.Tasks;

namespace _013_Panel_TabControl_SplitContainer_RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void _ChangeTheme(Control parent, Color BgColor, Color foreColor)
        {
            foreach (Control c in parent.Controls)
            {
                c.BackColor = BgColor;
                c.ForeColor = foreColor;

                if (c.HasChildren)
                {
                    _ChangeTheme(c, BgColor, foreColor);
                }
            }
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            await myWebView.EnsureCoreWebView2Async();
        }
        private void rdbHTML_CheckedChanged(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPageHTML;
        }
        private void rdbCSS_CheckedChanged(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPageCSS;
        }
        private void rdbJS_CheckedChanged(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabPageJS;
        }
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabPageHTML)
                rdbHTML.Checked = true;
            else if (tabControl.SelectedTab == tabPageCSS)
                rdbCSS.Checked = true;
            else rdbJS.Checked = true;

        }
        private void btnMode_Click(object sender, EventArgs e)
        {
            if (this.BackColor == Color.White)
            {
                this.BackColor = Color.Black;
                this.ForeColor = Color.White;
                _ChangeTheme(this, Color.Black, Color.White);
                btnMode.BackColor = Color.White;
                btnDownload.BackColor = Color.White;
                btnResize.BackColor = Color.White;
            }
            else if (this.BackColor == Color.Black)
            {
                this.BackColor = Color.White;
                this.ForeColor = Color.Black;
                _ChangeTheme(this, Color.White, Color.Black);
            }
        }
        private async void btnShowResult_Click(object sender, EventArgs e)
        {
            try
            {
                string strWeb = $@"<!DOCTYPE html>
                                    <html>
                                    <head>
                                        <style>
                                            {txtCSS.Text}
                                        </style>
                                    </head>

                                    <body>

                                        {txtHTML.Text}

                                        <script>
                                            {txtJS.Text}
                                        </script>

                                    </body>
                                    </html>";
                myWebView.NavigateToString(strWeb);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btnOrientation_Click(object sender, EventArgs e)
        {
            if (sc.Orientation == Orientation.Vertical)
            {
                sc.Orientation = Orientation.Horizontal;
                btnOrientation.Text = "Vertical";
            }
            else
            {
                sc.Orientation = Orientation.Vertical;
                btnOrientation.Text = "Horizontal";
            }
        }
        private void btnResize_Click(object sender, EventArgs e)
        {
            try
            {
                sc.Panel2Collapsed = !sc.Panel2Collapsed;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog f = new FolderBrowserDialog();
                if(f.ShowDialog() == DialogResult.OK)
                {
                    string path = f.SelectedPath;
                    string html = $@"<!DOCTYPE html>
                                    <html>
                                    <head>
                                        <meta charset='utf-8'>
                                        <title>My Project</title>

                                        <link rel='stylesheet' href='style.css'>
                                    </head>
                                    <body>
                                        {txtHTML.Text}
                                        <script src='script.js'></script>
                                    </body>
                                    </html>";

                    if (!string.IsNullOrWhiteSpace(txtHTML.Text))
                        File.WriteAllText(Path.Combine(path, "index.html"), html);
                    if (!string.IsNullOrWhiteSpace(txtCSS.Text))
                        File.WriteAllText(Path.Combine(path, "style.css"), txtCSS.Text);
                    if (!string.IsNullOrWhiteSpace(txtJS.Text))
                        File.WriteAllText(Path.Combine(path, "script.js"), txtJS.Text);

                    MessageBox.Show("Files are saved successfully!");
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
