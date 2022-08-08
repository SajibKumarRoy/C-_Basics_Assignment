using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Basics_Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Printing Hello World
            Console.WriteLine("Hello World");
            //Declaring all type of primitive type and printing them
            int age = 24;
            Console.WriteLine(age);
            long range = -7091821871L;
            Console.WriteLine(range);
            float CGPA = 3.52f;
            Console.WriteLine(CGPA);
            double PI = 3.14159d;
            Console.WriteLine(PI);
            bool isValid = true;
            Console.WriteLine(isValid);
            char ch = 'x';
            Console.WriteLine(ch);
            string name = "Sajib Kumar Roy";
            Console.WriteLine(name);
            //Overflow Exception Handling
            checked
            {
                int val = int.MaxValue;
                Console.WriteLine(val);
                try
                {
                    Console.WriteLine(val + 2);
                }
                catch(OverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

        }
    }
}
