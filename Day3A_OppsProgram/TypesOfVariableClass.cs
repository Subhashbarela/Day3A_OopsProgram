using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3A_OppsProgram
{
    internal class TypesOfVariableClass
    {
       
            // void,int,String,bool,Double
            public void MethodType()  // Non Parameterize  method
            {
                Console.WriteLine("its a void mathod");
            }
            public void MethodType(int one)  //  Parameterize  method
            {
                Console.WriteLine(one);
            }
            public int IntMethodType()  // int return type
            {
                return 4 + 3;
            }
            public int IntMethodType(int one, int two)
            {
                int three = one + two;
                return three;
            }
            public double DoubleMethodType() // double return type
            {
                return 40.3;
            }
            public double DoubleMethodType(double four, double five)
            {
                double six = four + five;
                return six;
            }
            public string StringMethodType()  // string return type
            {
                return "BridgeLabs";
            }
            public bool BoolMethodType(int ten)  //boolean return type
            {
                if (ten == 10)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

        }
    }
