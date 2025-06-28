using System;

namespace CyberSecurityTaskAssistant
{
    public class Task
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? Reminder { get; set; }
        public bool IsCompleted { get; set; }

        public override string ToString()
        {
            string reminderText = Reminder.HasValue ? $" | Reminder: {Reminder.Value:g}" : "";
            string status = IsCompleted ? " (Completed)" : "";
            return $"{Title}{status} - {Description}{reminderText}";
        }
    }
}