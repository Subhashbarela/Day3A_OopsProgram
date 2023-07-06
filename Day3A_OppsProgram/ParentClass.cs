using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3A_OppsProgram
{
    public class ParentClass
    {
        public void ParentClassMethod()
        {
            Console.WriteLine("this is parent class method");
        }
    }
    public class FirstChild: ParentClass
    {
        public void ChildClassMethod()
        {
            Console.WriteLine("This is child class method ");
        }
    }
    public class SecondChild : FirstChild
    {
        public void ChildClassBMethod()
        {
            Console.WriteLine("This is Second child class method ");
        }
    }

}
