﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grade
{
    class Program
    {
        static void Main(string[] args)
        {

            IGradeTracker book = CreateGradeBook();

            AddGrades(book);
           // book.WriteGrades(Console.Out);

            GradeStatistics stats = book.ComputeStatistics();
            WriteResult("Average", stats.AverageGrade);
            WriteResult("Highest", stats.HighestGrade);
            WriteResult("Lowest ", stats.LowestGrade);
            WriteResult("Grade", stats.LetterGrade);

        }

        public static IGradeTracker CreateGradeBook()
        {
            return new ThrowAawayGradeBook();
        }

        private static void AddGrades(IGradeTracker book)
        {
            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(75);
        }

        private static void GetBookName (IGradeTracker book)
        {
            try
            {
                Console.WriteLine("Enter a name");
                book.Name = Console.ReadLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void WriteResult(string description, float result)
        {
            Console.WriteLine($"{description}: {result:F2}", description, result);
        }

        static void WriteResult(string description, string result)
        {
            Console.WriteLine($"{description}: {result}", description, result);
        }
    }
}
