using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsRegistration
{

    using System;

    public class Student
    {
        private string name = string.Empty;
        private int age;
        private int grade;
        private double averageScore;
        private decimal fee;
        private char classLetter;
        private DateTime birthDate;

        public int Id { get; }

        public string Name { get; set; }
       // {
      //      get => name;
        //    set
        //    {
         //       if (string.IsNullOrWhiteSpace(value))
         //           throw new ArgumentException("Името не може да бъде празно!");

          //      name = value;
         //   }
       // }

        public int Age
        {
            get => age;
            set
            {
                if (value < 6 || value > 20)
                    throw new ArgumentOutOfRangeException("Възрастта трябва да бъде между 6 и 20 години!");

                age = value;
            }
        }

        public int Grade
        {
            get => grade;
            set
            {
                if (value < 1 || value > 12)
                    throw new ArgumentOutOfRangeException("Класът трябва да бъде между 1 и 12!");

                grade = value;
            }
        }

        public double AverageScore
        {
            get => averageScore;
            set
            {
                if (double.IsNaN(value) ||
                    double.IsInfinity(value) ||
                    value < 2.0 || value > 6.0)
                {
                    throw new ArgumentOutOfRangeException("Средният успех трябва да бъде между 2.00 и 6.00!");
                }

                averageScore = value;
            }
        }

        public decimal Fee
        {
            get => fee;
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Таксата не може да бъде отрицателна!");

                fee = value;
            }
        }

        public bool HasScholarship { get; set; }

        public char ClassLetter
        {
            get => classLetter;
            set
            {
                if (!char.IsLetter(value))
                    throw new ArgumentException("Буквата на паралелката трябва да бъде буква!");

                classLetter = char.ToUpper(value);
            }
        }

        public DateTime BirthDate
        {
            get => birthDate;
            set
            {
                if (value.Date > DateTime.Today)
                    throw new ArgumentOutOfRangeException("Датата на раждане не може да бъде в бъдещeto!");

                birthDate = value;
            }
        }

       // public Student(int id, string name)
       // {
       //     if (id <= 0)
            //    throw new ArgumentOutOfRangeException("Идентификаторът трябва да бъде положително число!");
        
          //  Id = id;
          //  Name = name;
        //}

        //konstruktora koito priema id i name
        public Student(int id, string name)
        {
            if (id <= 0)
            {
                throw new Exception("ID трябва да бъде положително число!");
            }

            if (string.IsNullOrWhiteSpace(name))
            {
                throw new Exception("Името не може да бъде празно!");
            }

            Id = id;
            Name = name;
        }
    }

}
