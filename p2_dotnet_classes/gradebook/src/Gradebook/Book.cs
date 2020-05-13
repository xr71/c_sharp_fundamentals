using System.Collections.Generic;
using System;

namespace Gradebook
{
    class Book
    {
        // we need a constructor so we don't get NullReferenceException
        // field def
        List<double> grades;  // grades here is implicitly private

        // give a name to this gradebook
        private string name;

        // we can write an explicit constructor
        public Book(string name)  // notice the same name as your class with no return type
        {
            grades = new List<double>();
            // remember that grades is not accessible to the Main program
            // this is encapsulation

            // this is an implicit variable always available inside methods
            this.name = name;
        }

        public void AddGrade(double grade)
        {
            // there is an implicit this here
            grades.Add(grade);
        }

        public void AddGrade(char letter)
        {
            if (letter = 'A')
            {
                grades.Add(90);
            }
            else
            {
                grades.Add(0);
            }
        }

        public void ShowStatistics()
        {
            double highGrade = double.MinValue;
            double lowGrade = double.MaxValue;
            double averageGrade = 0.0;

            foreach(double grade in grades)
            {
                highGrade = Math.Max(grade, highGrade);
                lowGrade = Math.Min(grade, lowGrade);
                averageGrade += grade;
            }

            Console.WriteLine($"Highest grade is {highGrade} Lowest grade is {lowGrade} Average grade is {averageGrade / grades.Count}");
        }
    }
}
