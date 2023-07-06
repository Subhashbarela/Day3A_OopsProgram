using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3A_OppsProgram
{
    public class MParentClass
    {
        //virtual keyword give authority to child class to modify method based on your need
        public virtual void Print()
        {
            Console.WriteLine("This is PARENT class ");
        }
    }
    public class MChildClassOne : MParentClass
    {
        public override void Print()
        {
            Console.WriteLine("This is CHILD  ONE class ");
        }
    }
    public class MChildClassTwo : MParentClass
    {
        public override void Print()
        {
            Console.WriteLine("This is CHILD  TWO class ");
        }
    }
}
