using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoManager
{
    internal class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Deadline { get; set; }
        public bool IsCompleted { get; set; }

        public Task(string title, string description, DateTime deadline)
        {
            Title = title;
            Description = description;
            Deadline = deadline;
            IsCompleted = false;
        }
    }
}

