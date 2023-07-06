using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3A_OppsProgram
{
    internal class MainClass
    {
        public int id;
        public string name;
        public void SetData(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public void GetData()
        {
            Console.WriteLine("name is: " + name);
            Console.WriteLine("id is: " + id);
        }
    }
}
