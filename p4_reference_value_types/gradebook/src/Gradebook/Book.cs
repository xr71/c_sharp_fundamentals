using System;
using System.Collections.Generic;

namespace Gradebook
{
    public class Book
    {
        public string Name;
        private List<double> grades;

        public Book(string name)
        {
            Name = name;
            grades = new List<double>();
        }

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }


        public Statistics ShowStatistics()
        {
            Statistics result = new Statistics();
            foreach(double grade in grades)
            {
                result.Low = Math.Min(result.Low, grade);
                result.High = Math.Max(result.High, grade);
                result.Average += grade;
            }
            result.Average = result.Average / grades.Count;

            return result;
        }
    }
}
