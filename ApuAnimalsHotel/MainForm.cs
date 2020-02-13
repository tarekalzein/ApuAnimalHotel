using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ApuAnimalsHotel.Enums;
using ApuAnimalsHotel.POCO;

namespace ApuAnimalsHotel
{
    public partial class MainForm : Form
    {
        string MAMMAL_CHAR_LABEL = "Count of teeth";

        private AnimalManager animalManager = null;
        public MainForm()
        {

            InitializeComponent();
            lblChar1.Text = ""; //remove label text on first run.
            lblChar2.Text = "";


            //Create an instance of AnimalManager to hold List<> for data entry.
            animalManager = new AnimalManager();



            //TO DO: move into a method .e.g. MyInitialization();
            //List CategoryType items in list box.
            Array categoryArray = typeof(CategoryType).GetEnumValues();
            foreach (CategoryType categoryType in categoryArray)
            {
                lbCategory.Items.Add(categoryType);
            }

            //List Gender types in Combo box.
            Array genderArray = Enum.GetValues(typeof(GenderType));
            foreach (GenderType genderType in genderArray)
            {
                cmbGender.Items.Add(genderType);
            }
            cmbGender.SelectedIndex = (int)GenderType.Unknown; //set default value to Unknown
        }



        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Animal animal;

            bool ok = ReadInput(out animal);
            if (ok)
            {
                CategoryType categoryType = (CategoryType)lbCategory.SelectedItem;

                if (categoryType == CategoryType.Mammal)
                {
                    bool char1Ok = false;
                    CheckCharacteristic_1(out char1Ok);
                    if (char1Ok)
                    {
                        Mammal mammal = new Mammal(animal);
                        mammal.TeethCount = int.Parse(CheckCharacteristic_1(out char1Ok));
                        switch ((MammalSpecies)lbObject.SelectedIndex)
                        {
                            case MammalSpecies.Dog:
                                Dog dog = new Dog(mammal);
                                bool char2Ok = false;
                                string breed= CheckCharacteristic_2(out char2Ok);
                                if (char2Ok)
                                {
                                    dog.Breed = breed;
                                    animalManager.Add(dog);
                                }
                                break;
                            case MammalSpecies.Cat:
                                Cat cat = new Cat(mammal);
                                char2Ok = false;
                                CheckCharacteristic_2(out char2Ok);
                                if (char2Ok)
                                {
                                    cat.Breed = CheckCharacteristic_2(out char2Ok);
                                    animalManager.Add(cat);
                                }
                                break;
                        }
                    }
                }
                if (categoryType == CategoryType.Insect)
                {
                    bool char1Ok = false;
                    CheckCharacteristic_1(out char1Ok);
                    if (char1Ok)
                    {
                        Insect insect = new Insect(animal);
                        insect.CountOfLegs = int.Parse(CheckCharacteristic_1(out char1Ok));
                        switch ((InsectSpecies)lbObject.SelectedIndex)
                        {
                            case InsectSpecies.Bee:
                                Bee bee = new Bee(insect);
                                bool char2Ok = false;
                                CheckCharacteristic_2(out char2Ok);
                                if (char2Ok)
                                {
                                    bee.BeeSpecies = CheckCharacteristic_2(out char2Ok);
                                    animalManager.Add(bee);
                                }
                                break;
                            case InsectSpecies.Butterfly:
                                Butterfly butterfly = new Butterfly(insect);
                                char2Ok = false;
                                CheckCharacteristic_2(out char2Ok);
                                if (char2Ok)
                                {
                                    butterfly.WingColor = CheckCharacteristic_2(out char2Ok);
                                    animalManager.Add(butterfly);
                                }
                                break;
                        }
                    }
                }


            }
            UpdateResults();

        }
        private void UpdateResults()
        {
            lbResults.Items.Clear();
            for (int index = 0; index < animalManager.ElementCount; index++)
            {
                Animal animal = animalManager.GetElementAtPosition(index);
                lbResults.Items.Add(animal.ToString());

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void lbObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            //enable text box for species specific character.
            txtChar2.Visible = true;

            var lbObjectSelection = lbObject.SelectedItem;

            switch (lbObjectSelection)
            {
                case MammalSpecies.Dog:
                    lblChar2.Text = "Breed";
                    break;

                case MammalSpecies.Cat:
                    lblChar2.Text = "Breed";
                    break;

                case InsectSpecies.Bee:
                    lblChar2.Text = "Bee Species";
                    break;

                case InsectSpecies.Butterfly:
                    lblChar2.Text = "Wings Color";
                    break;
            }


        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenderType genderType = (GenderType)cmbGender.SelectedItem;
        }

        private void lbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (lbCategory.SelectedItem != null) 
            {
                CategoryType categoryType = (CategoryType)lbCategory.SelectedItem;

                createAnimalObjectList(categoryType);
            }
            

        }

        private void grpbx2_Enter(object sender, EventArgs e)
        {

        }

        private void createAnimalObjectList(CategoryType categoryType)
        {
            //Enable text boxes that are disabled by default.
            txtChar1.Visible = true;


            lbObject.Items.Clear();

            switch (categoryType)
            {
                case CategoryType.Mammal:
                    lblChar1.Text = MAMMAL_CHAR_LABEL;
                    Array mammalsArray = typeof(MammalSpecies).GetEnumValues();
                    foreach (MammalSpecies mammalSpecies in mammalsArray)
                        lbObject.Items.Add(mammalSpecies);
                    break;

                case CategoryType.Insect:
                    lblChar1.Text = "Count of Legs"; //TO DO Change text and make it constant string
                    Array insectsArray = typeof(InsectSpecies).GetEnumValues();
                    foreach (InsectSpecies insectSpecies in insectsArray)
                        lbObject.Items.Add(insectSpecies);
                    break;

                //case CategoryType.Bird:
                //    lblChar1.Text = "Bird CHAR"; //TO DO Change text and make it constant string
                //    break;

                //case CategoryType.Marine:
                //    lblChar1.Text = "Marine CHAR"; //TO DO Change text and make it constant string
                //    break;

                //case CategoryType.Reptile:
                //    lblChar1.Text = "Reptile CHAR"; //TO DO Change text and make it constant string
                //    break;
            }
        }

        private string CheckName(out bool success)
        {
            string name = txtName.Text;
            success = (!String.IsNullOrEmpty(name));
            if (!success)
            {
                MessageBox.Show("Please Check the name field");
            }

            return name;

        }

        private double CheckAge(out bool success)
        {
            double age;
            success = false;
            if(double.TryParse(txtAge.Text, out age) && age >0) //deny wrong input or negative values
            {
                success = true;
            }
            else
            {
                MessageBox.Show("Age is not valid");

            }
            return age;
        }

        private string CheckCharacteristic_1(out bool success)
        {

            string char1 = txtChar1.Text;
            success = (!String.IsNullOrEmpty(char1));
            if(!success)
            {
                MessageBox.Show("Please fill the Animal's special character");
            }
            return char1;
            //if (String.IsNullOrEmpty(txtChar1.Text))
            //    MessageBox.Show("Please fill the Animal's special character");
        }

        private string CheckCharacteristic_2(out bool success)
        {

            string char2 = txtChar2.Text;
            success = (!String.IsNullOrEmpty(char2));
            if (!success)
            {
                MessageBox.Show("Please fill the Animal's special character");
            }
            return char2;
            //if (String.IsNullOrEmpty(txtChar2.Text))
            //    MessageBox.Show("Please fill the Animal's special character");
        }

        private bool ReadInput(out Animal animal)
        {
            animal = new Animal();

            // process Age
            bool ageOk = false;
            animal.Age = CheckAge(out ageOk);

            bool nameOk = false;
            animal.Name = CheckName(out nameOk);

            animal.Gender = (GenderType)cmbGender.SelectedItem;

            return ageOk && nameOk;
        }

        private void AddAnimal()
        {
            //Animal animalObj

        }

        private void txtChar1_TextChanged(object sender, EventArgs e)
        {

        }
    }


}

