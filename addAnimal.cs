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
    public partial class addAnimal : Form
    {
        private frmZooMainScreen mainScreen;

        public addAnimal(frmZooMainScreen mainScreen) // Inject mainScreen in constructor
        {
            InitializeComponent();
            this.mainScreen = mainScreen; // Store the reference
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Assuming mainScreen is a form variable holding a reference to the main form
                if (mainScreen != null && mainScreen.GetAnimalsList() != null) // Check for null before accessing methods
                {
                    string animalType = cmbxAnimalType.Text;
                    string animalName = edtName.Text;
                    char animalGender = (cmbxGender.Text)[0];
                    int animalAge = int.Parse(edtAge.Text);

                    // Determine animal class type based on animalType (replace with your logic)
                    Animal newAnimal;
                    if (animalType == "Jackel")
                    {
                        newAnimal = new Jackel { Name = animalName, Age = animalAge, Gender = animalGender, EnclosureNum = 1 };
                    }
                    else if (animalType == "Penguin")
                    {
                        newAnimal = new Penguin { Name = animalName, Age = animalAge, Gender = animalGender, EnclosureNum = 2 };
                    }
                    else
                    {
                        newAnimal = new Aardvark { Name = animalName, Age = animalAge, Gender = animalGender, EnclosureNum = 3 };
                    }

                    mainScreen.AddAnimal(newAnimal); // Call AddAnimal on mainScreen
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Error: Could not access animal list in main form.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Invalid age format. Please enter a whole number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Please fill in all fields");
            }
        }

    }
}
