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
        public void FirstChildClassMethod()
        {
            Console.WriteLine("This is child class method ");
        }
    }
    public class SecondChild : FirstChild
    {
        public void SecondChildClassMethod()
        {
            Console.WriteLine("This is Second child class method ");
        }
    }
    public class HierarchicalClass: ParentClass
    {
        public void Hierarchical_Class_Method()
        {
            Console.WriteLine("This is Hierachical class method ");
        }

    }

}
