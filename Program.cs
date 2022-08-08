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
            //Type Conversion
            //Implicit
            //int to long(vice - versa)
            int var1 = 50;
            long var2 = var1;
            Console.WriteLine(var1+" "+var2);
            //char to ASCII int (vice versa)
            char ch1 = 'A';
            int ascii = ch1;
            Console.WriteLine(ascii);
            //Explicit
            //string to int (vice-versa)
            string str1 = "10";
            int val1 = Convert.ToInt32(str1);
            Console.WriteLine(str1+" "+val1);
            int val2 = 20;
            string str2 = Convert.ToString(val2);
            Console.WriteLine(val2+" "+str2);
            //string to long (vice-versa)
            long val3 = Convert.ToInt64(str1);
            Console.WriteLine(str1 + " " + val3);
            long val4 = 25L;
            string str3 = Convert.ToString(val4);
            Console.WriteLine(val4 + " " + str3);
            //string to double (vice-versa)
            string str4 = "3.14159";
            double val5 = Convert.ToDouble(str4);
            Console.WriteLine(str4 + " " + val5);
            double val6 = 3.8345d;
            string str5 = Convert.ToString(val6);
            Console.WriteLine(val6 + " " + str5);
            //string to float (vice-versa)
            string str6 = "3.5";
            float val7 = float.Parse(str6);
            Console.WriteLine(str6 + " " + val7);
            float val8 = 7.34f;
            string str7 = Convert.ToString(val8);
            Console.WriteLine(val8 + " " + str7);
            //string to bool (vice-versa)
            string str8 = "true";
            bool val9 = Convert.ToBoolean(str8);
            Console.WriteLine(str8 + " " + val9);
            bool val10 = false;
            string str9 = Convert.ToString(val10);
            Console.WriteLine(val10 + " " + str9);
        }
    }
}
