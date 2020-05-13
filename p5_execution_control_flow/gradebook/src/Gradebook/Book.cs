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
            grades = new List<double>();
            Name = name;
        }

        public Statistics GetStatistics()
        {
            Statistics result = new Statistics();
            // foreach (double grade in grades)
            // {
            //     result.Average += grade;
            //     result.Low = Math.Min(grade, result.Low);
            //     result.High = Math.Max(grade, result.High);
            // }
            // result.Average = result.Average / grades.Count;


            // using a do while loop instead
            var index = 0;
            // do
            // {
            //     result.Average += grades[index];
            //     result.Low = Math.Min(grades[index], result.Low);
            //     result.High = Math.Max(grades[index], result.High);

            //     index++;
            // } while (index < grades.Count);

            // better yet, just use a while loop so it doesn't execute once if grades is blank
            while (index < grades.Count)
            {
                result.Average += grades[index];
                result.Low = Math.Min(grades[index], result.Low);
                result.High = Math.Max(grades[index], result.High);

                index++;
            }
            result.Average = result.Average / grades.Count;


            switch (result.Average)
            {
                case var d when d >= 90.0:
                    result.Letter = 'A';
                    break;
                case var d when d >= 80.0:
                    result.Letter = 'B';
                    break;

                default:
                    result.Letter = 'C';
                    break;
            }

            return result;
        }

        public void AddGrade(double grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                grades.Add(grade);
            }
            else
            {
                // we need to try and catch this elsewhere
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }
        }

        public void AddGrade(char letter)
        {
            if (letter == 'A')
            {
                grades.Add(90);
            }
            else
            {
                grades.Add(0);
            }
        }
    }
}
