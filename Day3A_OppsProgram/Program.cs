using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3A_OppsProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1: class and object \n2: Single Inheritance");
            Console.WriteLine("Enter your choice..!");
            int choice=int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        MainClass mainClass = new MainClass();
                        mainClass.SetData(101, "Subhash");
                        mainClass.GetData();
                        break;
                    }
                    case 2:
                    {
                        ChildClass child=new ChildClass();
                        child.ParentClassMethod();
                        child.ChildClassMethod();
                        break;
                    }
                    default:
                    {
                        Console.WriteLine("Please insert valid input");
                        break;
                    }
            }
            Console.ReadLine();
          
        }
    }
}
