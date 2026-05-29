using System;
using System.Windows.Forms;

namespace BOTGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            rtbChat.AppendText("========================================\n");

            rtbChat.AppendText(" ██████╗██╗   ██╗██████╗ ███████╗██████╗ \n");
            rtbChat.AppendText("██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗\n");
            rtbChat.AppendText("██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝\n");
            rtbChat.AppendText("██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗\n");
            rtbChat.AppendText("╚██████╗   ██║   ██████╔╝███████╗██║  ██║\n");
            rtbChat.AppendText(" ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝\n\n");

            rtbChat.AppendText("========================================\n\n");

            rtbChat.AppendText("Bot: Welcome to the Cybersecurity Awareness Bot!\n");
            rtbChat.AppendText("Bot: Ask me anything about cybersecurity.\n\n");
        }

        private void btnSend_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
