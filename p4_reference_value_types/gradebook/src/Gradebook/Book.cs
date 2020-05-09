using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Book
    {
        private string name;
        private List<double> grades;

        public Book(string name)
        {
            this.name = name;
        }
    }
}