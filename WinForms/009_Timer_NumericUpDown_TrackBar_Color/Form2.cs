using System;

namespace _009_Timer_NumericUpDown_TrackBar_Color
{
    public partial class Form2 : Form
    {
        private Form1 _Frm1;
        int r, g, b;
        public Form2(Form1 frm1)
        {
            InitializeComponent();
            _Frm1 = frm1;
        }

        private void _ShowColorValues()
        {  
            txtR.Text = tbR.Value.ToString();
            txtG.Text = tbG.Value.ToString();
            txtB.Text = tbB.Value.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tb_Scroll(object sender, EventArgs e)
        {
            _ShowColorValues();
        }

        private void btnSetColor_Click(object sender, EventArgs e)
        { 
            r = (int)tbR.Value;
            g = (int)tbG.Value;
            b = (int)tbB.Value;

            if (_Frm1 != null)
                _Frm1.BackColor = Color.FromArgb(255, r, g, b);
        }
    }
}
