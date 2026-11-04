using System;

namespace StudentsRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("==Данни за ученик==");


            //ot minalata sedmica
            //1
            Console.Write("Възраст: ");

            if (int.TryParse(Console.ReadLine(), out int age))
            {
                Console.WriteLine($"Възраст: {age}");
            }
            else
            {
                Console.WriteLine("Невалидна възраст.");
            }

            //2
            Console.Write("Въведете клас на ученика: ");

            if (byte.TryParse(Console.ReadLine(), out byte studentClass))
            {
                Console.WriteLine($"Клас: {studentClass}");
            }
            else
            {
                Console.WriteLine("Невалиден клас.");
            }

            //3
            Console.WriteLine("Въведете среден успех: ");
            if (double.TryParse(Console.ReadLine(), out double sredenUspeh))
            {
                Console.WriteLine($"Среден успех: {sredenUspeh}");
            }
            else
            {
                Console.WriteLine("Невалиден среден успех.");
            }

            //4
            Console.WriteLine("Въведете такса: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal sumMoney))
            {
                Console.WriteLine($"Такса: {sumMoney}");
            }

            //6
            Console.Write("Въведете буква на паралелката: ");

            if (char.TryParse(Console.ReadLine(), out char paralelka))
            {
                Console.WriteLine($"Паралелка на ученика: {studentClass} {paralelka}");
            }
            else
            {
                Console.WriteLine("Невалиdна паралелка.");
            }


            //7

            Console.WriteLine("Въведете дата: ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime birthDate))
            {
                Console.WriteLine($"Дата: {birthDate:d}");
            }
            else
            {
                Console.WriteLine("Невалидна дата.");
            }

            

        {
             int nextId = 1;

            
            {
                string name;
                int Age;

                // Въвеждане на име
                while (true)
                {
                    Console.Write("Въведете име на ученик: ");
                    name = Console.ReadLine();

                    try
                    {
                        if (string.IsNullOrWhiteSpace(name))
                            throw new ArgumentException(
                                "Името не може да бъде празно!");

                        break;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                // Въвеждане на възраст
                while (true)
                {
                    Console.Write("Въведете възраст: ");
                    string input = Console.ReadLine();

                    // Проверка за формат
                    if (!int.TryParse(input, out age))
                    {
                        Console.WriteLine(
                            "Невалиден формат! Въведете цяло число.");
                        continue;
                    }

                    try
                    {
                        // Проверка чрез класа Student
                        Student student = new Student(nextId, name, age);

                        nextId++;

                        Console.WriteLine("\nДанни за ученика:");
                        Console.WriteLine($"Id: {student.Id}");
                        Console.WriteLine($"Име: {student.Name}");
                        Console.WriteLine($"Възраст: {student.Age}");

                        break;
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(
                            $"Грешка: {ex.Message}");

                        Console.WriteLine(
                            "Моля, въведете стойността отново.");
                    }
                }
            }
        }


    }
    }
}