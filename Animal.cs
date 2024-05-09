using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagmentSysten
{
    public class Animal
    {
        //the properties
        public string Name { get; set; }
        public int Age { get; set; }
        public char Gender { get; set; } // M/F
        public int EnclosureNum { get; set; } //1-4, one for each type of animal and one for sickbay


        //default methods
        public virtual string Speak() {
            return (Name + " the generic animal makes a generic noise");
        }

        public virtual string Eat() {
            return (Name + " the generic animal eats generic food");
        }

        public virtual string Sleep()
        {
            return (Name + " the generic animal sleeps in generic location");
        }

        public String toString()
        {
            return (Name + "    " + Age.ToString() + "      " + Gender + "      " + EnclosureNum.ToString());
        }

 
    }
}
