using System;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Grade Book 1");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);

            var stats = book.ShowStatistics();

            Console.WriteLine($"Average grade is: {stats.Average}");
            Console.WriteLine($"Low grade is: {stats.Low}");
            Console.WriteLine($"High grade is: {stats.High}");
        }

    }
}
