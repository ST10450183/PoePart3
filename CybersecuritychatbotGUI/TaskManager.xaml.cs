using System;
using System.Collections.ObjectModel;
using System.Windows;
using System.Timers; // Explicit namespace
using System.Windows.Threading;
using System.Diagnostics;

namespace CyberSecurityTaskAssistant
{
    public partial class TaskManager : Window
    {
        private ObservableCollection<Task> tasks = new ObservableCollection<Task>();
        private System.Timers.Timer reminderTimer;

        public TaskManager()
        {
            InitializeComponent();
            TaskList.ItemsSource = tasks;

            reminderTimer = new System.Timers.Timer(60000); // 1 minute interval
            reminderTimer.Elapsed += ReminderTimer_Elapsed;
            reminderTimer.Start();
        }

        private void AddTask_Click(object sender, RoutedEventArgs e)
        {
            var title = TitleBox.Text.Trim();
            var description = DescriptionBox.Text.Trim();
            var reminder = ReminderDatePicker.SelectedDate;

            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Please enter a task title.");
                return;
            }

            Task newTask = new Task
            {
                Title = title,
                Description = string.IsNullOrEmpty(description) ? "No description provided." : description,
                Reminder = reminder,
                IsCompleted = false
            };

            tasks.Add(newTask);
            ClearInputs();

            MessageBox.Show($"Task '{title}' added. {(reminder.HasValue ? $"Reminder set for {reminder.Value:g}." : "")}");
        }

        private void ClearInputs()
        {
            TitleBox.Text = "";
            DescriptionBox.Text = "";
            ReminderDatePicker.SelectedDate = null;
        }

        private void DeleteTask_Click(object sender, RoutedEventArgs e)
        {
            if (TaskList.SelectedItem is Task selectedTask)
            {
                tasks.Remove(selectedTask);
            }
        }

        private void MarkCompleted_Click(object sender, RoutedEventArgs e)
        {
            if (TaskList.SelectedItem is Task selectedTask)
            {
                selectedTask.IsCompleted = true;
                TaskList.Items.Refresh();
            }
        }

        private void ReminderTimer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            Dispatcher.Invoke(() =>
            {
                foreach (var task in tasks)
                {
                    if (task.Reminder.HasValue &&
                        !task.IsCompleted &&
                        task.Reminder.Value.Date == DateTime.Now.Date &&
                        task.Reminder.Value.Hour == DateTime.Now.Hour &&
                        task.Reminder.Value.Minute == DateTime.Now.Minute)
                    {
                        MessageBox.Show($"🔔 Reminder: {task.Title}\n{task.Description}", "Cybersecurity Task Reminder");
                    }
                }
            });
        }
    }
}