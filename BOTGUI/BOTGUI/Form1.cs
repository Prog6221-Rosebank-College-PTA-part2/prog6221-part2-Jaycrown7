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
            string input = txtUserInput.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(input))
            {
                rtbChat.AppendText("Bot: Please type something.\n\n");
                return;
            }

            rtbChat.AppendText("You: " + txtUserInput.Text + "\n");

            if (input == "hello" || input == "hi")
            {
                rtbChat.AppendText("Bot: Hello! Welcome to the Cybersecurity Awareness Bot.\n\n");
            }
            else if (input == "exit")
            {
                Application.Exit();
            }
            else
            {
                rtbChat.AppendText("Bot: I am not sure I understand. Try rephrasing.\n\n");
            }

            txtUserInput.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
