using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using CybersecuritychatbotGUI;

namespace CybersecuritychatbotGUI
{
    public partial class QuizWindow : Window
    {
        private List<QuizQuestion> questions;
        private int currentQuestionIndex = 0;
        private int score = 0;

        public QuizWindow()
        {
            InitializeComponent();
            LoadQuestions();
            DisplayQuestion();
        }

        private void LoadQuestions()
        {
            questions = new List<QuizQuestion>
            {
                new QuizQuestion("What should you do if you receive an email asking for your password?",
                    new[] {"Reply with your password", "Delete the email", "Report the email as phishing", "Ignore it"}, 2,
                    "Correct! Reporting phishing emails helps prevent scams."),

                new QuizQuestion("Using the same password for multiple accounts is safe.",
                    new[] {"True", "False"}, 1,
                    "Correct! Using unique passwords helps prevent widespread compromise."),

                new QuizQuestion("Which is a strong password?",
                    new[] {"password123", "mydog", "P@ssw0rd!2025", "123456"}, 2,
                    "Correct! A strong password uses symbols, numbers, and upper/lower case."),

                new QuizQuestion("What is phishing?",
                    new[] {"A hacking tool", "A type of firewall", "A scam to trick users into revealing personal info", "A virus"}, 2,
                    "Correct! Phishing tricks people into giving away sensitive data."),

                new QuizQuestion("Should you keep your software and operating system updated?",
                    new[] {"Yes", "No"}, 0,
                    "Correct! Updates patch security vulnerabilities."),

                new QuizQuestion("Multi-factor authentication (MFA) is...",
                    new[] {"Useless", "Too complicated", "An extra security layer", "Only for banks"}, 2,
                    "Correct! MFA provides extra protection for your accounts."),

                new QuizQuestion("Which of these is most secure?",
                    new[] {"Public Wi-Fi", "HTTPS website", "HTTP website", "Unlocked router"}, 1,
                    "Correct! HTTPS encrypts your connection."),

                new QuizQuestion("You should share your password with trusted friends.",
                    new[] {"True", "False"}, 1,
                    "Correct! Never share your passwords with anyone."),

                new QuizQuestion("How can you spot a suspicious link?",
                    new[] {"Hover to preview", "Click quickly", "Ignore the sender", "Forward it to others"}, 0,
                    "Correct! Hover to see where the link actually goes."),

                new QuizQuestion("Social engineering relies on...",
                    new[] {"Technology bugs", "Tricking people", "Slow internet", "Antivirus bypass"}, 1,
                    "Correct! Social engineering manipulates people into breaking security.")
            };
        }

        private void DisplayQuestion()
        {
            if (currentQuestionIndex >= questions.Count)
            {
                txtQuestion.Text = $"Quiz Complete! Your Score: {score}/{questions.Count}";
                txtFeedback.Text = score >= 8 ? "🎉 Great job! You’re a cybersecurity pro!" :
                                  score >= 5 ? "👍 Good effort. Keep learning to stay safe!" :
                                  "📘 Keep practicing to boost your cybersecurity skills!";
                lstOptions.Visibility = Visibility.Collapsed;
                return;
            }

            var q = questions[currentQuestionIndex];
            txtQuestion.Text = $"Q{currentQuestionIndex + 1}: {q.Question}";
            lstOptions.ItemsSource = q.Options;
            lstOptions.SelectedIndex = -1;
            txtFeedback.Text = "";
        }

        private void SubmitAnswer_Click(object sender, RoutedEventArgs e)
        {
            if (lstOptions.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an answer.");
                return;
            }

            var q = questions[currentQuestionIndex];

            if (lstOptions.SelectedIndex == q.CorrectOptionIndex)
            {
                score++;
                txtFeedback.Text = "✅ " + q.Explanation;
            }
            else
            {
                txtFeedback.Text = $"❌ Incorrect. {q.Explanation}";
            }

            currentQuestionIndex++;
            txtScore.Text = $"Score: {score}/{questions.Count}";
            Dispatcher.InvokeAsync(async () =>
            {
                await System.Threading.Tasks.Task.Delay(1500);
                DisplayQuestion();
            });
        }
    }
}