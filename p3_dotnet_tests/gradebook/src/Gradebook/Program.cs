using System;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Gradebook 1");

            book.addGrade(89.1);
            book.addGrade(90.5);
            book.addGrade(77.5);

            book.ShowStatistics();
        }
    }
}
