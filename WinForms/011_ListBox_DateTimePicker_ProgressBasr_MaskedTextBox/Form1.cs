using System.Diagnostics;

namespace _011_ListBox_DateTimePicker_ProgressBasr_MaskedTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            lblTimeNow.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            this.Size = new Size(1320, 466);
        }
        private void btnAddParticipant_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFullName.Text))
            {
                MessageBox.Show("Name is required!", "Lack od info");
                return;
            }
            if (!maskedTxtPhoneNumber.MaskCompleted)
            {
                MessageBox.Show("Phone number is incompleted!", "Lack od info");
                return;
            }
            if (cbEventType.SelectedItem == null)
            {
                MessageBox.Show("Please select an event type!", "Lack of info");
                return;
            }
            else
            {
                if (pbMaxParticipants.Value < pbMaxParticipants.Maximum)
                {
                    listBoxParticipant.Items.Add($"{txtFullName.Text} | {cbEventType.SelectedItem} | {dtpRegistrationDate.Value} | {maskedTxtPhoneNumber.Text}");
                    pbMaxParticipants.Value++;
                    lblParticipantsNumber.Text = $"Participants: {pbMaxParticipants.Value} / 10";
                }
                else
                {
                    MessageBox.Show("Regirstation is full!");
                    return;
                }
            }
        }
        private void listBoxParticipant_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxParticipant.SelectedItem == null)
                return;

            string item = (string)listBoxParticipant.SelectedItem;
            string[] arr = item.Split('|');

            MessageBox.Show($"Name : {arr[0].Trim()}" +
                            $"\nEvent type : {arr[1].Trim()}" +
                            $"\nDate & Time : {arr[2].Trim()}" +
                            $"\nPhone : {arr[3].Trim()}");

            //txtFullName.Text = arr[0].Trim();
            //cbEventType.Text = arr[1].Trim();
            //if (DateTime.TryParse(arr[2], out DateTime dt))
            //    dtpRegistrationDate.Value = dt;
            //maskedTxtPhoneNumber.Text = arr[3].Trim();
        }
        private void lblChangeBg_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
                if (this.BackColor == Color.Black)
                {
                    this.ForeColor = Color.White;
                    groupBox1.ForeColor = Color.White;
                    lblTitle.ForeColor = Color.White;
                }
            }

        }
        private void lblRestBgColor_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(224, 224, 224);
            this.ForeColor = Color.Black;
            groupBox1.ForeColor = Color.Black;
            lblTitle.ForeColor = Color.Black;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            lblTimeNow.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
        private void linkGotoWebsite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start(new ProcessStartInfo { FileName = "www.google.com", UseShellExecute = true });
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
