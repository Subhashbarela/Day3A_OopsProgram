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
            string ans = "";
            do {
                Console.WriteLine("1: class and object \n2: Inheritance \n3: Method Overloading \n4: MethodOverriding \n5: Encapsulation \n6: Abstraction " +
                    "\n7: Types Of Variable\n8: Types Of method \n9: Value Type And Reference Type");
                Console.WriteLine("Enter your choice..!");
                int choice = int.Parse(Console.ReadLine());
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
                            Console.WriteLine("1: Single Inheritance \n2: Mutlilevel Inheritance \n3: Hierarchical Inheritance");
                            Console.WriteLine("Enter the choice");
                            int opt = int.Parse(Console.ReadLine());
                            switch (opt)
                            {
                                case 1:
                                    {

                                        FirstChild child = new FirstChild();
                                        child.ParentClassMethod();
                                        child.FirstChildClassMethod();
                                        break;
                                    }
                                case 2:
                                    {

                                        SecondChild child = new SecondChild();
                                        child.ParentClassMethod();
                                        child.FirstChildClassMethod();
                                        child.SecondChildClassMethod();
                                        break;
                                    }
                                case 3:
                                    {
                                        FirstChild child = new FirstChild();
                                        child.ParentClassMethod();
                                        child.FirstChildClassMethod();

                                        HierarchicalClass hierarchical = new HierarchicalClass();
                                        hierarchical.ParentClassMethod();
                                        hierarchical.Hierarchical_Class_Method();

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
                    case 3:
                        {
                            MethodOverloading overloading = new MethodOverloading();
                            overloading.Add();
                            overloading.Add(10, 20);
                            overloading.Add(2.4, 7.5);
                            overloading.Add("Subhash", "Barela");

                            break;
                        }
                    case 4:
                        {
                            MChildClassTwo overriding = new MChildClassTwo();
                            overriding.Print();

                            break;
                        }
                    case 5:
                        {
                            EncapsulationClass encapsulation = new EncapsulationClass();
                            encapsulation.ID = 102;
                            encapsulation.Name = "Subash barela";
                            Console.WriteLine("Id is : " + encapsulation.ID);
                            Console.WriteLine("Id is : " + encapsulation.Name);
                            //................................................
                            EncapsulationUsingFunction usingFunction = new EncapsulationUsingFunction();
                            usingFunction.SetData(200, "Bridgelabs Solution");
                            usingFunction.GetData();
                            break;
                        }
                    case 6:
                        {
                            Dog bruzo = new Dog();
                            bruzo.makeSound();

                            Pig pig = new Pig();
                            pig.makeSound();
                            break;
                        }
                    case 7:
                        {
                            // TypesOfVariableClass rtype= new TypesOfVariableClass();
                            //rtype.MethodType(1);
                            //int val=Obj.IntMethodType(4,5);
                            //Console.WriteLine(val);
                            //Console.WriteLine(rtype.DoubleMethodType(4.5,6.7));
                            //Console.WriteLine(rtype.StringMethodType());
                            //Console.WriteLine(rtype.BoolMethodType(10));

                            VariableTypes vr = new VariableTypes();
                            vr.id = 102;
                            vr.name = "Subhash";
                            vr.IsMarride = false;
                            vr.Heigth = 6.64;
                            vr.Display();
                            break;
                        }
                    case 8:
                        {
                            TypesOfMethod Obj = new TypesOfMethod();
                            Obj.NonParameterizeMethod();
                            Obj.ParameterizeMethod("subhash");
                            TypesOfMethod.StaticMethod(); // Access the Static Method So no need to create object of this class
                            break;
                        }
                    case 9:
                        {
                            ValueTypesAndRefrenceType Obj = new ValueTypesAndRefrenceType();
                            int a = 5;
                            Obj.ValueTypeMethod(a); //15
                            Console.WriteLine("Value of a in Main Method " + a); //5

                            // Reference Type
                            int b = 5;  // send reference of this variable
                            Obj.ReferIntVariable(ref b); //15
                            Console.WriteLine("Reference  value in Main Method " + b); // 15

                            //Out parameterise
                            string c;  // send reference of this variable And no need to initialize value
                            Obj.OutTypeMethod(out c); //10
                            Console.WriteLine("Out param value in Main Method " + c); // 10
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Please insert valid input");
                            break;
                        }
                }
                Console.WriteLine("Do you want to continue ...?");
                ans=Console.ReadLine();
            } while (ans=="yes" || ans=="y");
            Console.ReadLine();
          
        }
    }
}
