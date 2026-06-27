using BOTGUI.Models;
using System.Collections.Generic;

namespace BOTGUI.Services
{
    public class QuizManager
    {
        public List<QuizQuestion> Questions = new List<QuizQuestion>()
        {
            new QuizQuestion()
            {
                Question="What should you do if you receive an email asking for your password?",
                OptionA="Reply with your password",
                OptionB="Delete the email",
                OptionC="Report it as phishing",
                OptionD="Ignore it",
                CorrectAnswer='C',
                Explanation="Reporting phishing emails helps stop scams."
            },

            new QuizQuestion()
            {
                Question="Which password is the strongest?",
                OptionA="123456",
                OptionB="Password",
                OptionC="John2005",
                OptionD="T#9vL!82@Qa",
                CorrectAnswer='D',
                Explanation="Strong passwords contain uppercase letters, lowercase letters, numbers and symbols."
            },

            new QuizQuestion()
            {
                Question="True or False: You should reuse the same password for every account.",
                OptionA="True",
                OptionB="False",
                OptionC="",
                OptionD="",
                CorrectAnswer='B',
                Explanation="Each account should have its own unique password."
            },

            new QuizQuestion()
            {
                Question="Which of these is an example of phishing?",
                OptionA="A fake bank email asking for your password",
                OptionB="A school newsletter",
                OptionC="A weather forecast",
                OptionD="A software update notification",
                CorrectAnswer='A',
                Explanation="Phishing tries to trick users into giving away sensitive information."
            },

            new QuizQuestion()
            {
                Question="What does 2FA stand for?",
                OptionA="Two-Factor Authentication",
                OptionB="Two File Access",
                OptionC="Twice File Approved",
                OptionD="Two Fast Accounts",
                CorrectAnswer='A',
                Explanation="2FA adds an extra layer of security."
            },

            new QuizQuestion()
            {
                Question="True or False: Public Wi-Fi is always safe.",
                OptionA="True",
                OptionB="False",
                OptionC="",
                OptionD="",
                CorrectAnswer='B',
                Explanation="Public Wi-Fi can expose your data if it's unsecured."
            },

            new QuizQuestion()
            {
                Question="Which website is usually secure?",
                OptionA="http://example.com",
                OptionB="https://example.com",
                OptionC="ftp://example.com",
                OptionD="file://example.com",
                CorrectAnswer='B',
                Explanation="HTTPS encrypts communication between you and the website."
            },

            new QuizQuestion()
            {
                Question="What should you do before clicking a link in an email?",
                OptionA="Click immediately",
                OptionB="Forward it",
                OptionC="Check the sender and hover over the link",
                OptionD="Reply asking if it's real",
                CorrectAnswer='C',
                Explanation="Always verify links before clicking."
            },

            new QuizQuestion()
            {
                Question="True or False: Antivirus software should be updated regularly.",
                OptionA="True",
                OptionB="False",
                OptionC="",
                OptionD="",
                CorrectAnswer='A',
                Explanation="Updates protect against new threats."
            },

            new QuizQuestion()
            {
                Question="Which information should NEVER be shared online?",
                OptionA="Your favourite colour",
                OptionB="Your banking PIN",
                OptionC="Your hobbies",
                OptionD="Your favourite movie",
                CorrectAnswer='B',
                Explanation="Banking details should always remain private."
            },

            new QuizQuestion()
            {
                Question="Which attack tricks people instead of computers?",
                OptionA="Firewall",
                OptionB="Social Engineering",
                OptionC="Encryption",
                OptionD="Backup",
                CorrectAnswer='B',
                Explanation="Social engineering manipulates people into revealing information."
            },

            new QuizQuestion()
            {
                Question="What is the safest action when downloading software?",
                OptionA="Download from any website",
                OptionB="Download from official websites only",
                OptionC="Use unknown links",
                OptionD="Download cracked software",
                CorrectAnswer='B',
                Explanation="Official websites reduce the risk of malware."
            }
        };
    }
}
