using System;

namespace StudentsRegistration
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
            Console.WriteLine("Въведете парична стойност: ");
            if (decimal.TryParse(Console.ReadLine(), out decimal sumMoney))
            {
                Console.WriteLine($"Парична стойност:: {sumMoney}");
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

            if (DateTime.TryParse(Console.ReadLine(), out DateTime birthDate))
            {
                Console.WriteLine($"Дата: {birthDate:d}");
            }
            else
            {
                Console.WriteLine("Невалидна дата.");
            }

        }
    }
}