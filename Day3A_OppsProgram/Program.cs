﻿using System;
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
            Console.WriteLine("1: class and object \n2: Inheritance");
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
                        Console.WriteLine("1: Single Inheritance \n2: Mutlilevel Inheritance");
                        Console.WriteLine("Enter the choice");
                        int opt=int.Parse(Console.ReadLine());
                        switch(opt)
                        {
                            case 1:
                                {

                                    FirstChild child = new FirstChild();
                                    child.ParentClassMethod();
                                    child.FirstChildMethod();
                                    break;
                                }   
                            case 2:
                                {

                                    SecondChild child = new SecondChild();
                                    child.ParentClassMethod();
                                    child.FirstChildMethod();
                                    child.SecondChileMethod();
                                    break;
                                }
                            default:
                                {
                                    Console.WriteLine("Please insert the valid input..!");
                                    break;
                                }
                        }
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
