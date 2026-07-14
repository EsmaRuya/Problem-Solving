using System.IO;

namespace _006_Practice
{
    // Works only with texts (for now)
    /*
        File Manager Lite :
        Features :  Open a file.
                    Save changes.
                    Copy a file - Save as.
                    Move a file.
                    Rename a file.
                    Unsave changes waring before close.
                    Show recent opened files.
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private OpenFileDialog _OpenFile = new OpenFileDialog();
        private SaveFileDialog _SaveFile = new SaveFileDialog();
        private FileInfo _FileInfo;
        private string _FilePath;
        private string _FilePathSource;
        private string _FilePathDestanation;
        private string _FileName;
        private bool _isModified = false;
        private List<string> _RecentFilesList = new List<string>();
        private void btnOpen_Click(object sender, EventArgs e)
        {
            _OpenFile.Title = "Open Files";
            _OpenFile.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            if (_OpenFile.ShowDialog() == DialogResult.OK)
            {
                txtContent.Visible = true;
                _FilePath = _OpenFile.FileName;
                _FileInfo = new FileInfo(_FilePath);

                lblFilePath.Text = _FilePath;
                lblFileInfo.Text = $"Size: {_FileInfo.Length} bytes | {_FileInfo.Extension}";
                lblFileDate.Text = $"{_FileInfo.CreationTime}";
                txtContent.Text = File.ReadAllText(_FilePath);
                linkMoreInfo.Visible = true;
                _isModified = false;
                _FileName = _FileInfo.Name;
                _RecentFilesList.Add(_FileName);
            }
        }

        private void linkMoreInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show($"Path: {_FilePath}\n\n" +
                            $"Name: {_FileInfo.Name}\n" +
                            $"Extension: {_FileInfo.Extension}\n" +
                            $"Size: {_FileInfo.Length} bytes\n" +
                            $"Last modify: {_FileInfo.LastWriteTime}\n" +
                            $"Created: {_FileInfo.CreationTime}",
                            "File Info",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void txtContent_TextChanged(object sender, EventArgs e)
        {
            _isModified = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_FilePath) || !File.Exists(_FilePath))
            {
                MessageBox.Show("No valid file is currently open.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to save the modifications?", "Save Data", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    File.WriteAllText(_FilePath, txtContent.Text); // overwrite
                    MessageBox.Show("Saved Successfully!\nFile Path: " + _FilePath, "Save Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _isModified = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Save Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            //else
            //{
            //    MessageBox.Show("Save operation canceled!", "Canceled", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (File.Exists(_FilePath))
            {
                _FilePathSource = _OpenFile.FileName;
            }
            else
            {
                MessageBox.Show("File isn't chosen yet!\nOpen a file first!", "Missing file!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_isModified)
            {
                if (MessageBox.Show("You have unsaved changes!\nCopy anyway...\nThis will copy your last version!", "Unsaved changes", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
                {
                    return;
                }
            }

            _FileName = Path.GetFileName(_FilePathSource);
            _SaveFile.FileName = _FileName;

            if (_SaveFile.ShowDialog() == DialogResult.OK)
            {
                _FilePathDestanation = _SaveFile.FileName;
                File.Copy(_FilePathSource, _FilePathDestanation);
                MessageBox.Show("File Copied successfully!", "Copy!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            if (File.Exists(_FilePath))
            {
                _FilePathSource = _OpenFile.FileName;
            }
            else
            {
                MessageBox.Show("File doesn't exist!\nOpen a file first!", "Missing file!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_isModified)
            {
                if (MessageBox.Show("You have unsaved changes!\nCopy anyway...\nThis will copy your last version!", "Unsaved changes", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
                {
                    return;
                }
            }

            _FileName = Path.GetFileName(_FilePathSource);
            _SaveFile.FileName = _FileName;

            if (_SaveFile.ShowDialog() == DialogResult.OK)
            {
                _FilePathDestanation = _SaveFile.FileName;
                File.Move(_FilePathSource, _FilePathDestanation);

                MessageBox.Show("File moved successfully!", "Move!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRename_Click(object sender, EventArgs e)
        {
            if (File.Exists(_FilePath))
            {
                _FilePathSource = _OpenFile.FileName;
            }
            else
            {
                MessageBox.Show("File doesn't exist!\nOpen a file first!", "Missing file!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_isModified)
            {
                if (MessageBox.Show("You have unsaved changes!\nCopy anyway...\nThis will copy your last version!", "Unsaved changes", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.Cancel)
                {
                    return;
                }
            }

            _FileName = Path.GetFileName(_FilePathSource);
            _SaveFile.FileName = _FileName;

            if (_SaveFile.ShowDialog() == DialogResult.OK)
            {
                _FilePathDestanation = _SaveFile.FileName;
                File.Move(_FilePathSource, _FilePathDestanation);

                MessageBox.Show("File renamed successfully!", "Rename!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_isModified)
            {
                if (MessageBox.Show("You have unsaved changes!\n" +
                                    "Do you want to close anyway...",
                                    "Unsaved changes",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnRecentFiles_Click(object sender, EventArgs e)
        {
            Form frm = new Form();
            frm.Size = this.Size;
            frm.Font = this.Font;

            Label lblFiles = new Label();
            lblFiles.AutoSize = true;

            foreach(string file in _RecentFilesList)
            {
                lblFiles.Text += "File name: " + file + "\n";
            }

            frm.Controls.Add(lblFiles);
            frm.ShowDialog();
        }
    }
}
