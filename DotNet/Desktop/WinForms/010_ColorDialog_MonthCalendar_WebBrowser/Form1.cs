using System;
using System.Windows.Forms;
using Microsoft.Web.WebView2.Core;

namespace _010_ColorDialog_MonthCalendar_WebBrowser
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void linkChangeBackgroundColor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ColorDialog color = new ColorDialog();
            if (color.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = color.Color;
                if (color.Color == Color.Blue)
                {
                    linkChangeBackgroundColor.LinkColor = Color.White;
                }
                else
                {
                    linkChangeBackgroundColor.LinkColor = Color.Blue;
                }
            }
        }

        private async void tsBtnSearch_Click(object sender, EventArgs e)
        {
           // string url = tsTxtURL.Text;

           //await webView2.EnsureCoreWebView2Async();
           // webView2.CoreWebView2.Navigate(url);

            //if (String.IsNullOrWhiteSpace(url))
            //    return;
            //if (!url.StartsWith("https://") && !url.StartsWith("http://"))
            //{
            //    url = $"https://{url}";
            //}
            //if (Uri.TryCreate(url, UriKind.Absolute, out Uri uri))
            //    webView2.Source = uri;
            //else
            //{
            //    MessageBox.Show("Invalid URL!\nValide URL : Example.com", "Invalid URL");
            //    tsTxtURL.Text = "";
            //}
        }

    }
}
