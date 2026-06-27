using BOTGUI.Services;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace BOTGUI
{
    public partial class Form1 : Form
    {
        Random random = new Random();
        
        string favoriteTopic = "";
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
            Database db = new Database();

            try
            {
                using (MySqlConnection connection = db.GetConnection())
                {
                    connection.Open();
                    MessageBox.Show("Database connected successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            PlayGreeting();

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

        private void PlayGreeting()
        {
            try
            {
                SoundPlayer player = new SoundPlayer(@"assets\greeting.wav");
                player.PlaySync();
            }
            catch
            {
                MessageBox.Show("Greeting audio could not play.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

            // Greetings
            if (input == "hello" || input == "hi")
            {
                rtbChat.AppendText("Bot: Hello! Welcome to the Cybersecurity Awareness Bot.\n\n");
            }

            // Sentiment Detection
            else if (input.Contains("worried"))
            {
                rtbChat.AppendText("Bot: It is understandable to feel worried about cybersecurity.\n");
                rtbChat.AppendText("Bot: Scammers can be convincing, but staying informed helps you stay safe.\n\n");
            }

            else if (input.Contains("frustrated"))
            {
                rtbChat.AppendText("Bot: Cybersecurity can sometimes feel overwhelming.\n");
                rtbChat.AppendText("Bot: Take things step by step and continue learning.\n\n");
            }

            else if (input.Contains("curious"))
            {
                rtbChat.AppendText("Bot: Curiosity is a great way to improve your cybersecurity knowledge.\n\n");
            }

            // Memory Feature
            else if (input.Contains("i like"))
            {
                if (input.Contains("privacy"))
                {
                    favoriteTopic = "privacy";
                }

                else if (input.Contains("password"))
                {
                    favoriteTopic = "passwords";
                }

                else if (input.Contains("phishing"))
                {
                    favoriteTopic = "phishing";
                }

                else if (input.Contains("scam"))
                {
                    favoriteTopic = "scams";
                }

                rtbChat.AppendText("Bot: Great! I will remember that you are interested in " + favoriteTopic + ".\n\n");
            }

            // Follow-up Conversation
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

            // Password
            else if (input.Contains("password"))
            {
                currentTopic = "password";

                int index = random.Next(passwordResponses.Length);

                rtbChat.AppendText("Bot: " + passwordResponses[index] + "\n");

                if (favoriteTopic == "passwords")
                {
                    rtbChat.AppendText("Bot: Since passwords are your favorite topic, remember to never reuse passwords across accounts.\n");
                }

                rtbChat.AppendText("\n");
            }

            // Phishing
            else if (input.Contains("phishing"))
            {
                currentTopic = "phishing";

                int index = random.Next(phishingResponses.Length);

                rtbChat.AppendText("Bot: " + phishingResponses[index] + "\n");

                if (favoriteTopic == "phishing")
                {
                    rtbChat.AppendText("Bot: Since phishing is your favorite topic, always double-check suspicious email addresses.\n");
                }

                rtbChat.AppendText("\n");
            }

            // Privacy
            else if (input.Contains("privacy"))
            {
                currentTopic = "privacy";

                int index = random.Next(privacyResponses.Length);

                rtbChat.AppendText("Bot: " + privacyResponses[index] + "\n");

                if (favoriteTopic == "privacy")
                {
                    rtbChat.AppendText("Bot: Since privacy is your favorite topic, remember to enable two-factor authentication.\n");
                }

                rtbChat.AppendText("\n");
            }

            // Scam
            else if (input.Contains("scam"))
            {
                currentTopic = "scam";

                int index = random.Next(scamResponses.Length);

                rtbChat.AppendText("Bot: " + scamResponses[index] + "\n");

                if (favoriteTopic == "scams")
                {
                    rtbChat.AppendText("Bot: Since scams are your favorite topic, avoid sharing banking details online.\n");
                }

                rtbChat.AppendText("\n");
            }

            // Purpose
            else if (input.Contains("purpose"))
            {
                rtbChat.AppendText("Bot: My purpose is to help users stay safe online and spread cybersecurity awareness.\n\n");
            }

            // Exit
            else if (input == "exit")
            {
                Application.Exit();
            }

            // Unknown Input
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
