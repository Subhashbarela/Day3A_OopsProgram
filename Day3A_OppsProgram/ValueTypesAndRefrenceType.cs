using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3A_OppsProgram
{
    public class ValueTypesAndRefrenceType
    {
        public void ValueTypeMethod(int a)
        {
            a += 10;
            Console.WriteLine(" value caller method a is: " + a);
        }
        public void ReferIntVariable(ref int a)
        {
            a += 10;
            Console.WriteLine(" value of caller method is: " + a);
        }
        // this variable access address  for storing value
        public void OutTypeMethod(out string str)
        {
            str = "BridgeLebs";
            Console.WriteLine(" string in caller method is: " + str);
        }       
    }
}
