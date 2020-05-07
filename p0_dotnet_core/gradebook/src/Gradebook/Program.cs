using System;
using System.Collections.Generic;

namespace Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length > 0)
            {
                var x = 34.1;
                double y = 35.5;

                double[] numbers = new double[3];
                numbers[0] = 1;
                numbers[2] = 2;


                // we can also decl the values of array immediately
                double[] numbers2 = new double[3] {1.6, 6.3, 45.7};

                for (int i = 0; i < 3; i++)
                {
                    Console.WriteLine(numbers2[i]);
                }
                Console.WriteLine("");

                // we can be even less explicit
                var numbers3 = new[] {12.3, 13.4, 14.5, 15.6, 16.7};
                var result = 0.0;

                for (int i = 0; i < numbers3.Length; i++)
                {
                    result = result + numbers3[i];
                }
                Console.WriteLine(result);


                result = 0.0;
                // better yet, we can use higher order function foreach
                foreach (double num in numbers3)
                {
                    result += num;
                }
                Console.WriteLine(result);


                // with System.Collections.Generic we can now use Lists
                List<double> grades = new List<double>();
                grades.Add(85);
                grades.Add(92);
                grades.Add(89.5);

                foreach (double grade in grades) { Console.Write(grade + " "); }
                Console.WriteLine(grades.Count);
                result = 0.0;
                foreach (var grade in grades) { result += grade; }
                Console.WriteLine($"Your average grade is {(result / grades.Count):N3}");

                Console.WriteLine("\n");
                string name = args[0];
                Console.WriteLine("Hello " + name + "!");
                Console.WriteLine($"Hello {name}!");
            }
            else
            {
                Console.WriteLine("Hello World!");
            }
        }
    }
}
