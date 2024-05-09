using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ZooManagmentSysten
{
    internal class Penguin: waterAnimal, IFeedable, ISickbay
    {
        //overriding the eat method to allow for a more precise output
        public override string Eat()
        {
           String output = (Name + " the penguin eats generic food");
            return output;
        }

        //overloading the eat method to be able to pass a parameter of which food the penguin eats
        public string Eat(String food)
        {
            return (Name + " the penguin eats " + food);
        }

        //overriding the sleep method
        public override string Sleep()
        {
            return (Name + " the penguin sleeps in the water");
        }

        //overriding the speak method of penguin
        public override string Speak()
        {
            if (Age <= 2) //if the penguin is under 2 its chirps
            {
                return (Name + " the penguin makes a chirping noise");
            }
            return (Name + " the penguin makes a squawking noise"); //if older it squawks

        }

        //penguin enclosure number = 2, and sickbay = 4
        public void moveAnimal()
        {
            if (EnclosureNum == 2) //if the enclosure is in its own enclosure 
            {
                EnclosureNum = 4; //must move to the sickbay
            }
            else EnclosureNum = 2; //if its in the sickbay it must move back to its own enclosure

        }
    }
}
