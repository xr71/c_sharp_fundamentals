using System;
using System.Collections.Generic;


namespace Gradebook
{
    class Program
    {
        // the opposite of static is just an instance method, instance fields
        // static is not associated with an object instance
        // associated with type defined - can only use Program.Main(args)

        static void Main(string[] args)
        {
            /*
            List<double> grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);

            var result = 0.0;

            foreach (double grade in grades) {
                result += grade;
            }
            */

            var book = new Book("Gradebook 1");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);

            book.ShowStatistics();

            double highGrade = double.MinValue;
            double lowGrade = double.MaxValue;

            List<double> grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);

            foreach (double grade in grades)
            {
                highGrade = Math.Max(grade, highGrade);
                lowGrade = Math.Min(grade, lowGrade);
            }

            Console.WriteLine($"Highest grade is {highGrade} and lowest grade is {lowGrade}");

            // Console.WriteLine(result / grades.Count);

            // WriteLine is a static method, we do not need to create an instance of Console
            // Console.WriteLine("Hello World!");
        }
    }

}
