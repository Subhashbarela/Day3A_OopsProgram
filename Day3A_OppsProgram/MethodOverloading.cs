using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3A_OppsProgram
{
    internal class MethodOverloading
    {
        public void Add()
        {
            int a = 10;
            int b = 20;
            int c = a + b;
            Console.WriteLine(c);
        }
        public void Add(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("Addition of two integer value: " + c);
        }
        public void Add(double a, double b)
        {
            double c = a + b;
            Console.WriteLine("Addition of two float value: " + c);
        }
        public void Add(string a, string b)
        {
            string c = a + " " + b;
            Console.WriteLine("Concatinate of two string value: " + c);
        }
    }
}
