using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooManagmentSysten
{
    public partial class frmZooMainScreen : Form
    {
        //global variables

        public List<Animal> animals;
        int animalNum = -1; //default value if no animal is selected

        //method to expose list to other forms
        public List<Animal> GetAnimalsList()
        {
            return animals;
        }



        private void populateAnimals()
        {
            animals.Add(new Penguin { Name = "toby", Age = 3, Gender = 'M', EnclosureNum = 2 });
            animals.Add(new Jackel { Name = "koos", Age = 4, Gender = 'M', EnclosureNum = 1 });
            animals.Add(new Aardvark { Name = "lucy", Age = 5, Gender = 'F', EnclosureNum = 3 });
            animals.Add(new Penguin { Name = "lacy", Age = 1, Gender = 'F', EnclosureNum = 2 });
        }

        private void populateListBox()
        {
            listBox1.Items.Clear();
            foreach (Animal animal in animals)
            {
                listBox1.Items.Add(animal.toString());
            }
        }

        public frmZooMainScreen()
        {
            InitializeComponent();
            animals = new List<Animal>();
        }

        public void AddAnimal(Animal newAnimal)
        {
            animals.Add(newAnimal);
            populateListBox(); // Update list box
        }

        private void btnFeed_Click(object sender, EventArgs e)
        {
            if (animalNum == -1)
            {
                MessageBox.Show("Please select an animal");
            }
            //penguin
            else if (animals[animalNum] is Penguin)
            {
                Penguin penguin = (Penguin)animals[animalNum]; // Cast to penguin
                string foodType = Interaction.InputBox("What food would you like to feed: fish, squid or krill: ", "Select food:", "generic food");
                if (foodType.ToLower() == "fish" || foodType.ToLower() == "squid" || foodType.ToLower() == "krill")
                {
                    txtboxDisplay.Text = penguin.Eat(foodType); // Call Eat on the penguin object
                }
                else
                {
                    txtboxDisplay.Text = penguin.Eat();
                }
            }
            //jackel
            else if (animals[animalNum] is Jackel)
            {

                Jackel jackel = (Jackel)animals[animalNum]; // Cast to jackel
                //getting amount of food
                double foodAmount = int.Parse(Interaction.InputBox("How much food would you like to feed the jackel: max 5kg", "Select weight:", "0"));
                txtboxDisplay.Text = jackel.Eat(foodAmount);


            }
            //aardvark
            else if (animals[animalNum] is Aardvark)
            {
                Aardvark aardvark = (Aardvark)animals[animalNum]; //cast to aardvark
                //getting foof type
                string foodType = Interaction.InputBox("What food would you like to feed to the aardvark: termites, insects? ", "Select food:", "insects");
                txtboxDisplay.Text = aardvark.Eat(foodType.ToLower());
            }

        }

        private void frmZooMainScreen_Load(object sender, EventArgs e)
        {
            populateAnimals();
            populateListBox();

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            animalNum = listBox1.SelectedIndex;
            textBox1.Text = animals[animalNum].Name;
        }

        private void btnSleep_Click(object sender, EventArgs e)
        {
            if (animalNum == -1)
            {
                MessageBox.Show("Please select an animal");
            }
            //penguin
            else if (animals[animalNum] is Penguin)
            {
                Penguin penguin = (Penguin)animals[animalNum]; // Cast to penguin
                txtboxDisplay.Text = penguin.Sleep();
            }
            //jackel
            else if (animals[animalNum] is Jackel)
            {
                Jackel jackel = (Jackel)animals[animalNum]; // Cast to jackel
                txtboxDisplay.Text = jackel.Sleep();


            }
            //aardvark
            else if (animals[animalNum] is Aardvark)
            {
                Aardvark aardvark = (Aardvark)animals[animalNum]; //cast to aardvark
                txtboxDisplay.Text =  aardvark.Sleep();
            }

        }

        private void btnNoise_Click(object sender, EventArgs e)
        {
            if (animalNum == -1)
            {
                MessageBox.Show("Please select an animal");
            }
            //penguin
            else if (animals[animalNum] is Penguin)
            {
                Penguin penguin = (Penguin)animals[animalNum]; // Cast to penguin
                txtboxDisplay.Text = penguin.Speak();
            }
            //jackel
            else if (animals[animalNum] is Jackel)
            {
                Jackel jackel = (Jackel)animals[animalNum]; // Cast to jackel
                txtboxDisplay.Text = jackel.Speak();
            }
            //aardvark
            else if (animals[animalNum] is Aardvark)
            {
                Aardvark aardvark = (Aardvark)animals[animalNum]; //cast to aardvark
                txtboxDisplay.Text = aardvark.Speak();
            }
        }

        private void btnMoveAnimal_Click(object sender, EventArgs e)
        {
            if (animalNum == -1)
            {
                MessageBox.Show("Please select an animal");
            }
            //penguin
            else if (animals[animalNum] is Penguin)
            {
                Penguin penguin = (Penguin)animals[animalNum]; // Cast to penguin
                penguin.moveAnimal();
                populateListBox();
            }
            //jackel
            else if (animals[animalNum] is Jackel)
            {
                Jackel jackel = (Jackel)animals[animalNum]; // Cast to jackel
                jackel.moveAnimal();
                populateListBox();
            }
            //aardvark
            else if (animals[animalNum] is Aardvark)
            {
                Aardvark aardvark = (Aardvark)animals[animalNum]; //cast to aardvark
                aardvark.moveAnimal();
                populateListBox();
            }
        }

        private void btnSwim_Click(object sender, EventArgs e)
        {
            try
            {
                waterAnimal animal = (waterAnimal)animals[animalNum];
                txtboxDisplay.Text = animal.swim();
            }catch(Exception ex) 
            {
                MessageBox.Show("Only water animals can swim");
            }
        }

        private void btnDig_Click(object sender, EventArgs e)
        {
            try
            {
                landAnimal animal = (landAnimal)animals[animalNum];
                txtboxDisplay.Text = animal.digs();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Only land animals can dig");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            animals.RemoveAt(animalNum);
            populateListBox();
            txtboxDisplay.Text = "Animal removed from zoo";
            animalNum = -1;
            textBox1.Text = "";
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            addAnimal add = new addAnimal(this);
            add.ShowDialog();
        }
    }
}
