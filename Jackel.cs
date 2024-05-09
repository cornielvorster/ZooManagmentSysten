using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooManagmentSysten { 

    public class Jackel : landAnimal, IFeedable
    {
        //overriding the eat method to allow for a more precise output
        public override string Eat()
        {
            return (Name + " the jackel eats generic food"); 
        }

        //overloading the eat method of the jackal to ensure that the jackal doesnt get overfeed
        public string Eat(double foodWeight) {
            if (foodWeight > 5)
            {
                return (Name + " the jackal cannot recieve more than 5KG of food. ");
            }
            else return (Name + " the jackal eats " + foodWeight + " kg of food. ");
        }

        //overriding the sleep method
        public override string Sleep()
        {
            return (Name + " the jackel sleeps in a den");
        }

        //overriding the speak method
        public override string Speak()
        {
            return (Name + " the jackel makes a howling noise");

        }

        //jackel enclosure number = 1, and sickbay = 4
        public void moveAnimal()
        {
            if (EnclosureNum == 1) //if the jackel is in its own enclosure 
            {
                EnclosureNum = 4; //must move to the sickbay
            }
            else EnclosureNum = 1; //if its in the sickbay it must move back to its own enclosure

        }
    }
}
