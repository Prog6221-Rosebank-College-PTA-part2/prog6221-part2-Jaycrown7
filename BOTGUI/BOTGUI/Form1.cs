using BOTGUI.Models;
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
        TaskManager taskManager = new TaskManager();
        ActivityLogger logger = new ActivityLogger();
        QuizManager quizManager = new QuizManager();

        int currentQuestion = 0;
        int score = 0;

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
            // ---------- NLP SIMULATION ----------

            // Start Quiz
            if (input.Contains("quiz") ||
                input.Contains("test me") ||
                input.Contains("play game") ||
                input.Contains("play quiz") ||
                input.Contains("cyber game"))
            {
                btnStartQuiz.PerformClick();
                rtbChat.AppendText("Bot: Starting the Cybersecurity Quiz...\n\n");
                logger.Log("NLP: Quiz started");
                txtUserInput.Clear();
                return;
            }

            // Show Activity Log
            if (input.Contains("activity") ||
                input.Contains("what have you done") ||
                input.Contains("show log") ||
                input.Contains("history"))
            {
                btnShowLog.PerformClick();
                rtbChat.AppendText("Bot: Displaying your recent activity.\n\n");
                logger.Log("NLP: Activity log requested");
                txtUserInput.Clear();
                return;
            }

            // View Tasks
            if (input.Contains("show tasks") ||
                input.Contains("view tasks") ||
                input.Contains("my tasks") ||
                input.Contains("task list"))
            {
                btnViewTasks.PerformClick();
                logger.Log("NLP: Viewed tasks");
                txtUserInput.Clear();
                return;
            }

            // Reminder / Task
            if ((input.Contains("remind") ||
                 input.Contains("remember")) &&
                 (input.Contains("password") ||
                  input.Contains("privacy") ||
                  input.Contains("2fa")))
            {
                rtbChat.AppendText("Bot: I understand you want to create a cybersecurity reminder.\n");
                rtbChat.AppendText("Bot: Please use the Task Assistant below to add it.\n\n");

                logger.Log("NLP: Reminder recognised");

                txtUserInput.Clear();
                return;
            }

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

        private void DisplayQuestion()
        {
            QuizQuestion q = quizManager.Questions[currentQuestion];

            lblQuestion.Text = q.Question;

            rbOptionA.Text = q.OptionA;
            rbOptionB.Text = q.OptionB;
            rbOptionC.Text = q.OptionC;
            rbOptionD.Text = q.OptionD;

            rbOptionA.Checked = false;
            rbOptionB.Checked = false;
            rbOptionC.Checked = false;
            rbOptionD.Checked = false;

            rbOptionC.Visible = !string.IsNullOrEmpty(q.OptionC);
            rbOptionD.Visible = !string.IsNullOrEmpty(q.OptionD);
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            logger.Log("Viewed Tasks");
            if (string.IsNullOrWhiteSpace(txtTaskTitle.Text))
            {
                MessageBox.Show("Please enter a task title.");
                return;
            }

            TaskItem task = new TaskItem();

            task.Title = txtTaskTitle.Text;
            task.Description = txtTaskDescription.Text;
            task.ReminderDate = dtpReminder.Value;
            task.Status = "Pending";

            taskManager.AddTask(task);

            MessageBox.Show("Task added successfully!");

            rtbChat.AppendText("Bot: Your task has been added successfully.\n\n");

            txtTaskTitle.Clear();
            txtTaskDescription.Clear();
        }

        private void rtbChat_Enter(object sender, EventArgs e)
        {

        }

        private void rtbChat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnViewTask_Click(object sender, EventArgs e)
        {
            
            List<TaskItem> tasks = taskManager.GetTasks();

            rtbChat.AppendText("========== TASK LIST ==========\n");

            if (tasks.Count == 0)
            {
                rtbChat.AppendText("No tasks found.\n\n");
                return;
            }

            foreach (TaskItem task in tasks)
            {
                rtbChat.AppendText(
                    "ID: " + task.TaskID +
                    "\nTitle: " + task.Title +
                    "\nDescription: " + task.Description +
                    "\nReminder: " + task.ReminderDate +
                    "\nStatus: " + task.Status +
                    "\n---------------------------\n");
            }

            rtbChat.AppendText("\n");
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {

            if (int.TryParse(txtTaskID.Text, out int taskID))
            {
                logger.Log("Deleted Task ID " + taskID);
                taskManager.DeleteTask(taskID);

                MessageBox.Show("Task deleted successfully.");

                rtbChat.AppendText("Bot: Task deleted successfully.\n\n");

                txtTaskID.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid Task ID.");
            }
        }

        private void btnCompleteTask_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtTaskID.Text, out int taskID))
            {
                taskManager.CompleteTask(taskID);

                logger.Log("Completed Task ID " + taskID);

                MessageBox.Show("Task marked as completed.");

                rtbChat.AppendText("Bot: Task marked as completed.\n\n");

                txtTaskID.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid Task ID.");
            }

        }

        private void btnShowLog_Click(object sender, EventArgs e)
        {
            rtbActivityLog.Clear();

            foreach (string activity in logger.GetRecentActivities())
            {
                rtbActivityLog.AppendText(activity + Environment.NewLine);
            }
        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            currentQuestion = 0;

            score = 0;

            lblScore.Text = "Score: 0";

            logger.Log("Quiz Started");

            DisplayQuestion();
        }

        private void btnSubmitAnswer_Click(object sender, EventArgs e)
        {
            char answer = ' ';

            if (rbOptionA.Checked)
                answer = 'A';

            else if (rbOptionB.Checked)
                answer = 'B';

            else if (rbOptionC.Checked)
                answer = 'C';

            else if (rbOptionD.Checked)
                answer = 'D';

            else
            {
                MessageBox.Show("Please select an answer.");

                return;
            }

            QuizQuestion q = quizManager.Questions[currentQuestion];

            if (answer == q.CorrectAnswer)
            {
                score++;

                MessageBox.Show("Correct!\n\n" + q.Explanation);
            }
            else
            {
                MessageBox.Show("Wrong!\n\n" + q.Explanation);
            }

            currentQuestion++;

            lblScore.Text = "Score: " + score;

            if (currentQuestion >= quizManager.Questions.Count)
            {
                logger.Log("Quiz Completed");

                MessageBox.Show(GetFinalMessage());

                lblQuestion.Text = "Quiz Finished!";

                return;
            }

            DisplayQuestion();

        }
        private string GetFinalMessage()
        {
            if (score >= 10)
                return "Excellent! You are a cybersecurity expert!\n\nFinal Score: " + score + "/12";

            if (score >= 7)
                return "Great job! You have good cybersecurity knowledge.\n\nFinal Score: " + score + "/12";

            if (score >= 4)
                return "Good effort. Keep learning to stay safe online.\n\nFinal Score: " + score + "/12";

            return "You should learn more about cybersecurity. Practice makes perfect!\n\nFinal Score: " + score + "/12";
        }
    }
    
}
