using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ZooManagmentSysten
{
    internal class Aardvark: landAnimal, IFeedable
    {
        //overriding the eat method to allow for a more precise output
        public override string Eat()
        {
            return (Name + " the aardvark eats generic food");
        }

        //overloading the eat method of the aardvark to ensure it only eats insects
        public string Eat(String foodType)
        {
            if (foodType == "insects" || foodType == "termites")
                return (Name + " the aardvark eats " + foodType);
            else
            {
               return (Name + " the aardvark only eats insects. Aardvarks are insectivore ");
            }
        }

        //overriding the sleep method
        public override string Sleep() 
        {
            return (Name + " the aardvark sleeps in a burrow");
        }

        //overriding the speak method in the Aardvark class
        public override string Speak()
        {
            if (Gender == 'M')
            {
                return (Name + " the aardvark makes a soft grunting noise since it is a male");
            }
            else
            {
                return (Name + " the aardvark makes a bleating since it is a female");
            }
        }


        //aardvark enclosure number = 3, and sickbay = 4
        public void moveAnimal() {
            if (EnclosureNum == 3) //if the aardvark is in its own enclosure 
            {
                EnclosureNum = 4; //must move to the sickbay
            }
            else EnclosureNum = 3; //if its in the sickbay it must move back to its own enclosure
            
        }
    }
}
