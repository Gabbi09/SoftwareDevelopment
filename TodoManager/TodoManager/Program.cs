using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoManager
{
    internal class Program
    {
        static List<Task> tasks = new List<Task>();

        static void Main()
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("===== УПРАВЛЕНИЕ НА ЗАДАЧИ =====");
                Console.WriteLine("1. Добави нова задача");
                Console.WriteLine("2. Покажи всички задачи");
                Console.WriteLine("3. Маркирай задача като изпълнена");
                Console.WriteLine("4. Изтрий задача");
                Console.WriteLine("5. Изход");
                Console.WriteLine("===============================");
                Console.Write("Избери опция: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                {
                    AddTask();
                }
                else if (choice == "2")
                {
                    ShowTasks();
                }
                else if (choice == "3")
                {
                    CompleteTask();
                }
                else if (choice == "4")
                {
                    DeleteTask();
                }
                else if (choice == "5")
                {
                    Console.WriteLine("Програмата приключи.");
                    break;
                }
                else
                {
                    Console.WriteLine("Невалидна опция!");
                    Console.ReadLine();
                }
            }
        }

        static void AddTask()
        {
            Console.Clear();

            Console.WriteLine("===== ДОБАВЯНЕ НА ЗАДАЧА =====");

            Console.Write("Заглавие: ");
            string title = Console.ReadLine();

            Console.Write("Описание: ");
            string description = Console.ReadLine();

            Console.Write("Краен срок (дд.ММ.гггг): ");
            DateTime deadline;

            while (!DateTime.TryParse(Console.ReadLine(), out deadline))
            {
                Console.Write("Невалидна дата! Въведи отново: ");
            }

            Task newTask = new Task(title, description, deadline);

            tasks.Add(newTask);

            Console.WriteLine("\nЗадачата беше добавена успешно!");
            Console.ReadLine();
        }

        static void ShowTasks()
        {
            Console.Clear();

            Console.WriteLine("===== ВСИЧКИ ЗАДАЧИ =====");

            if (tasks.Count == 0)
            {
                Console.WriteLine("Няма въведени задачи.");
                Console.ReadLine();
                return;
            }

            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine("\nЗадача №" + (i + 1));
                Console.WriteLine("-------------------------");
                Console.WriteLine("Заглавие: " + tasks[i].Title);
                Console.WriteLine("Описание: " + tasks[i].Description);
                Console.WriteLine("Краен срок: " +
                                  tasks[i].Deadline.ToString("dd.MM.yyyy"));

                if (tasks[i].IsCompleted)
                {
                    Console.WriteLine("Статус: Изпълнена");
                }
                else
                {
                    Console.WriteLine("Статус: Неизпълнена");
                }
            }

            Console.WriteLine("\nНатисни Enter за продължаване...");
            Console.ReadLine();
        }

        static void CompleteTask()
        {
            Console.Clear();

            Console.WriteLine("===== МАРКИРАНЕ КАТО ИЗПЪЛНЕНА =====");

            if (tasks.Count == 0)
            {
                Console.WriteLine("Няма въведени задачи.");
                Console.ReadLine();
                return;
            }

            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + tasks[i].Title);
            }

            Console.Write("\nИзбери номер на задача: ");
            int number;

            if (int.TryParse(Console.ReadLine(), out number))
            {
                if (number >= 1 && number <= tasks.Count)
                {
                    tasks[number - 1].IsCompleted = true;

                    Console.WriteLine("Задачата е маркирана като изпълнена!");
                }
                else
                {
                    Console.WriteLine("Невалиден номер на задача!");
                }
            }
            else
            {
                Console.WriteLine("Моля, въведи число!");
            }

            Console.ReadLine();
        }

        static void DeleteTask()
        {
            Console.Clear();

            Console.WriteLine("===== ИЗТРИВАНЕ НА ЗАДАЧА =====");

            if (tasks.Count == 0)
            {
                Console.WriteLine("Няма въведени задачи.");
                Console.ReadLine();
                return;
            }

            for (int i = 0; i < tasks.Count; i++)
            {
                Console.WriteLine((i + 1) + ". " + tasks[i].Title);
            }

            Console.Write("\nИзбери номер на задача за изтриване: ");
            int number;

            if (int.TryParse(Console.ReadLine(), out number))
            {
                if (number >= 1 && number <= tasks.Count)
                {
                    tasks.RemoveAt(number - 1);

                    Console.WriteLine("Задачата беше изтрита!");
                }
                else
                {
                    Console.WriteLine("Невалиден номер на задача!");
                }
            }
            else
            {
                Console.WriteLine("Моля, въведи число!");
            }

            Console.ReadLine();
        }
    }
}
