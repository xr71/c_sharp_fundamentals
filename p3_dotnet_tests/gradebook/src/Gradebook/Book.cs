using System;
using System.Collections.Generic;

namespace Gradebook
{
    public class Book
    {
        public Book(string name)
        {
            this.name = name;
            grades = new List<double>();
        }

        public void addGrade(double grade)
        {
            grades.Add(grade);
        }

        public Statistic GetStatistics()
        {
            Statistic result = new Statistic();

            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            foreach (double grade in grades)
            {
                result.Average += grade;
                result.High = Math.Max(result.High, grade);
                result.Low = Math.Min(result.Low, grade);
            }

            result.Average = result.Average / grades.Count;

            return result;
        }
        public void ShowStatistics()
        {
            var result = 0.0;
            var minValue = double.MaxValue;
            var maxValue = double.MinValue;

            foreach (double grade in grades)
            {
                result += grade;
                minValue = Math.Min(minValue, grade);
                maxValue = Math.Max(maxValue, grade);
            }

            Console.WriteLine($"Average is {result / grades.Count}");
            Console.WriteLine($"Highest grade is {maxValue}");
            Console.WriteLine($"Lowest grade is {minValue}");

        }

        private List<double> grades;
        private string name;
    }
}
