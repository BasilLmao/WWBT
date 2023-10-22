using System.Diagnostics;
using System.Net;

namespace WWBT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string address = "https://pastebin.com/raw/AR7Aedjb";
            WebClient client = new WebClient();
            string reply = client.DownloadString(address);
            textBox1.Text = reply;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var uri = "https://github.com/BasilLmao";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var uri = "https://discord.gg/wzBHe5BJ";
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.UseShellExecute = true;
            psi.FileName = uri;
            System.Diagnostics.Process.Start(psi);
        }
    }
}