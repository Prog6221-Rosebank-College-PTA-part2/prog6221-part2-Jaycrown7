using System;
using System.Windows.Forms;

namespace BOTGUI
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        string currentTopic = "";

        string[] passwordResponses =
        {
            "Use strong and unique passwords for every account.",
            "Avoid using personal information in your passwords.",
            "Use a password manager to store passwords safely."
        };

        string[] phishingResponses =
        {
            "Be careful of suspicious emails and fake links.",
            "Never click unknown links from emails.",
            "Scammers often pretend to be trusted companies."
        };

        string[] privacyResponses =
        {
            "Review your privacy settings regularly.",
            "Enable two-factor authentication on your accounts.",
            "Avoid sharing personal information online."
        };

        string[] scamResponses =
        {
            "Never trust offers that seem too good to be true.",
            "Scammers often create urgency to pressure victims.",
            "Always verify websites before entering information."
        };

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
            else if (input.Contains("tell me more") || input.Contains("another tip"))
            {
                if (currentTopic == "password")
                {
                    int index = random.Next(passwordResponses.Length);
                    rtbChat.AppendText("Bot: " + passwordResponses[index] + "\n\n");
                }
                else if (currentTopic == "phishing")
                {
                    int index = random.Next(phishingResponses.Length);
                    rtbChat.AppendText("Bot: " + phishingResponses[index] + "\n\n");
                }
                else if (currentTopic == "privacy")
                {
                    int index = random.Next(privacyResponses.Length);
                    rtbChat.AppendText("Bot: " + privacyResponses[index] + "\n\n");
                }
                else if (currentTopic == "scam")
                {
                    int index = random.Next(scamResponses.Length);
                    rtbChat.AppendText("Bot: " + scamResponses[index] + "\n\n");
                }
                else
                {
                    rtbChat.AppendText("Bot: Please mention a cybersecurity topic first.\n\n");
                }
            }
            else if (input.Contains("password"))
            {
                currentTopic = "password";
                int index = random.Next(passwordResponses.Length);
                rtbChat.AppendText("Bot: " + passwordResponses[index] + "\n\n");
            }
            else if (input.Contains("phishing"))
            {
                currentTopic = "phishing";
                int index = random.Next(phishingResponses.Length);
                rtbChat.AppendText("Bot: " + phishingResponses[index] + "\n\n");
            }
            else if (input.Contains("privacy"))
            {
                currentTopic = "privacy";
                int index = random.Next(privacyResponses.Length);
                rtbChat.AppendText("Bot: " + privacyResponses[index] + "\n\n");
            }
            else if (input.Contains("scam"))
            {
                currentTopic = "scam";
                int index = random.Next(scamResponses.Length);
                rtbChat.AppendText("Bot: " + scamResponses[index] + "\n\n");
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
