using CybersecuritychatbotGUI;
using CybersecuritychatbotGUI;
using CyberSecurityTaskAssistant;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows;

namespace CybersecuritychatbotGUI
{
    public partial class MainWindow : Window
    {
        DisplayMessages messageHandler = new DisplayMessages();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            string threat = txtThreatInput.Text;
            string result = messageHandler.GetThreatDefinition(threat);
            txtOutput.Text = result;
            ActivityLog.Add($"Definition searched for: '{threat}'");
        }

        private void btnTips_Click(object sender, RoutedEventArgs e)
        {
            string threat = txtThreatInput.Text;
            string result = messageHandler.GetThreatTips(threat);
            txtOutput.Text = result;
            ActivityLog.Add($"Tips retrieved for: '{threat}'");
        }

        private void btnTaskManager_Click(object sender, RoutedEventArgs e)
        {
            TaskManager taskWindow = new TaskManager();
            taskWindow.Show();
            ActivityLog.Add("Opened Task Manager window");
        }

        private void btnStartQuiz_Click(object sender, RoutedEventArgs e)
        {
            QuizWindow quizWindow = new QuizWindow();
            quizWindow.Show();
            ActivityLog.Add("Started Cybersecurity Quiz");
        }

        private void btnProcessNLP_Click(object sender, RoutedEventArgs e)
        {
            string input = txtNLPInput.Text.ToLower();

            if (input.Contains("show activity log") || input.Contains("what have you done"))
            {
                List<string> recent = ActivityLog.GetRecent();
                txtOutput.Text = "Here's a summary of recent actions:\n" + string.Join("\n", recent);
                return;
            }

            // Simulate NLP: check for keywords to add task or reminder
            if (input.Contains("remind me") || input.Contains("set reminder"))
            {
                ActivityLog.Add($"Reminder detected in input: '{input}'");
                txtOutput.Text = $"Reminder noted: '{input}'";
            }
            else if (input.Contains("add task") || input.Contains("create task"))
            {
                ActivityLog.Add($"Task request detected: '{input}'");
                txtOutput.Text = $"Task added from input: '{input}'. You can set a reminder too.";
            }
            else
            {
                txtOutput.Text = $"I'm not sure how to handle: '{input}', but I'm learning!";
            }
        }
    }
}