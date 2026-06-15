namespace _009_Timer_NumericUpDown_TrackBar_Color
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        decimal minutes, seconds;

        private void _SetBottuns()
        {
            btnStart.Text = "Start";

            btnStart.Enabled = true;
            btnStop.Enabled = false;
            nudDurationInMin.Enabled = true;
            nudDurationInSec.Enabled = true;
            txtExerciceName.Enabled = true;
            cbDifficulty.Enabled = true;
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Start")
            {
                minutes = nudDurationInMin.Value;
                seconds = nudDurationInSec.Value;
            }
            timer.Start();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            nudDurationInMin.Enabled = false;
            nudDurationInSec.Enabled = false;
            txtExerciceName.Enabled = false;
            cbDifficulty.Enabled = false;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (seconds > 0)
            {
                seconds--;
                if (seconds == 0 && minutes == 0)
                {
                    MessageBox.Show("Time's up!", "Time's up", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _SetBottuns();
                }
                    
            }
            else
            {
                if (minutes > 0)
                {
                    minutes--;
                    seconds = 59;
                }
            }
            lblCounterDown.Text = $"00:{minutes:00}:{seconds:00}";  
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timer.Stop();
            btnStart.Text = "Continue";
            btnStart.Enabled = true;
            btnStop.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            timer.Stop();
            _SetBottuns();
            lblCounterDown.Text = "00:00:00";
        }

        private void linkChangeBgColor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 frm = new Form2(this);
            frm.Show();
        }
    }
}
