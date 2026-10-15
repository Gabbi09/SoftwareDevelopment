using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoManager
{
    internal class TaskItem
    {

        public int Id { get; set; }
        public string Title {
            get
            {
                return title;
            }

            set
            {
                if (string.IsNullOrEmpty(title))
                    throw new ArgumentNullException("zaglavioeto e zaduljitelno");
            }
        }
        public string Description { get; set; }
            
        public DateTime Deadline { get; set; }
        public bool IsCompleted { get; set; }

        public TaskItem(int id, string title, string description, DateTime deadline)
        {

            if (id <=0)
            {
                throw new ArgumentOutOfRangeException("id trqbva da e polojitelno chislo");
            }

            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentNullException("zaglavieto e zaduljitelno");
            }


            Id = id;
            Title = title;
            Description = description;
            Deadline = deadline;
            IsCompleted = false;
        }
    }
}

