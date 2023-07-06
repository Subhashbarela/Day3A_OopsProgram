using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3A_OppsProgram
{
    public class EncapsulationClass
    {

        private int id;
        private string name;
        public int ID
        {
            set // set private so no anyone can assign value from other class
            {
                id = value;
            }      
            get { 
                return id;
            }
        }
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

    }
    public class EncapsulationUsingFunction
    {
        // variable make as private so no anyone can assign the value outside of class
        private int id;
        private string name;

        // make method as public
        public void SetData(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public void GetData()
        {
            Console.WriteLine("Your id is: " + id);
            Console.WriteLine("Your name is: " + name);

        }
    }

}
