using System;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Gradebook 1");
            // book.AddGrade(89.5);
            // book.AddGrade(90.5);
            // book.AddGrade(77.5);

            bool done = false;

            while (!done)
            {
                Console.WriteLine("Enter a grade or the letter 'q' to quit: ");
                var ingrade = Console.ReadLine();

                if (ingrade == "q")
                {
                    break;
                }
                else
                {
                    try
                    {
                        var ingradenum = double.Parse(ingrade);
                        book.AddGrade(ingradenum);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        Console.WriteLine("***");
                    }
                }

            }

            var result = book.GetStatistics();

            Console.WriteLine($"The average grade is {result.Average}");
            Console.WriteLine($"The letter grade is {result.Letter}");
            Console.WriteLine($"The low grade is {result.Low}");
            Console.WriteLine($"The high grade is {result.High}");
        }
    }
}
