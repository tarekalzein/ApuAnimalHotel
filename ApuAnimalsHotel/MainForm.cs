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
        string INSECT_CHAR_LABEL = "Count of Legs";

        private AnimalManager animalManager = null;
        public MainForm()
        {
            InitializeComponent();           
            InitializeGui(); //Own initialization of some GUI components.
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
            Animal animal =new Animal();

            bool success = CheckInputs();
            if (success)
            {
                string animalObjType = lbObject.SelectedItem.ToString();
                CreateAnimalInstance(animalObjType,animal);
            }
            UpdateResults(); //update results in the result list.
        }

        private void UpdateResults()
        {
            lbResults.Items.Clear(); //start with a clean list.
            for (int index = 0; index < animalManager.ElementCount; index++)
            {
                Animal animal = animalManager.GetElementAtPosition(index);  //Get the index of the animal in the list.
                lbResults.Items.Add(animal.ToString()); //add fetched data to the list.
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string imageLocation = "";

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png";

                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    imgAnimal.ImageLocation = imageLocation;
                }
            }
            catch(Exception)
            {

            }
           
        }

        private void lbObject_SelectedIndexChanged(object sender, EventArgs e)
        {
            //enable text box for species specific character.
            txtChar2.Visible = true;
            txtChar1.Visible = true;


            var lbObjectSelection = lbObject.SelectedItem; //read animal object controller and rename label according to animal type.

            switch (lbObjectSelection)
            {
                case MammalSpecies.Dog:
                    lblChar2.Text = "Breed";
                    lblChar1.Text = MAMMAL_CHAR_LABEL;

                    break;

                case MammalSpecies.Cat:
                    lblChar2.Text = "Breed";
                    lblChar1.Text = MAMMAL_CHAR_LABEL;
                    break;

                case InsectSpecies.Bee:
                    lblChar2.Text = "Bee Species";
                    lblChar1.Text = INSECT_CHAR_LABEL;
                    break;

                case InsectSpecies.Butterfly:
                    lblChar2.Text = "Wings Color";
                    lblChar1.Text = INSECT_CHAR_LABEL;

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
            //if (lbCategory.SelectedItem != null) //to prevent crashes.
            //{
            CreateAnimalObjectList(); //create animal subcategories list.
            //}            

        }

        private void grpbx2_Enter(object sender, EventArgs e)
        {
        }

        private void InitializeGui()
        {

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

        //This method is the core method to create the animal object.
        private void CreateAnimalInstance(string animalObjType, Animal animal)
        {
            //All inputs are validated before this step. assign variable to each input to use later in animal obj creation.
            string animalName= txtName.Text;
            double animalAge= double.Parse(txtAge.Text);
            string char_1 = txtChar1.Text;
            string char_2=txtChar2.Text;
            GenderType animalGender = (GenderType)cmbGender.SelectedItem;

            switch (animalObjType)
            {
                case "Dog":
                    animal = new Dog
                    {
                        Age = animalAge,
                        Name = animalName,
                        TeethCount = int.Parse(char_1),
                        Category=CategoryType.Mammal,
                        Breed=char_2,
                        Gender=animalGender
                    };
                    break;

                case "Cat":
                    animal = new Cat
                    {
                        Age = animalAge,
                        Name = animalName,
                        TeethCount = int.Parse(char_1),
                        Category = CategoryType.Mammal,
                        Breed = char_2,
                        Gender = animalGender
                    };                   
                    break;

                case "Bee":
                    animal = new Bee
                    {
                        Age = animalAge,
                        Name = animalName,
                        Category = CategoryType.Insect,
                        CountOfLegs = int.Parse(char_1),
                        BeeSpecies = char_2,
                        Gender = animalGender,
                    };
                    break;

                case "Butterfly":
                    animal = new Butterfly
                    {
                        Age = animalAge,
                        Name = animalName,
                        Category = CategoryType.Insect,
                        CountOfLegs = int.Parse(char_1),
                        WingColor = char_2,
                        Gender = animalGender,
                    };
                    break;
            }
            animalManager.Add(animal);
        }
        private void CreateAnimalObjectList()
        {
            //Enable text boxes that are disabled by default.

            lbObject.Items.Clear(); //prevent duplicating data in the list.

            if (cbListAll.Checked) 
            {
                lbCategory.Enabled = false;
                Array mammalsArray = typeof(MammalSpecies).GetEnumValues();
                foreach (MammalSpecies mammalSpecies in mammalsArray)
                    lbObject.Items.Add(mammalSpecies);
                Array insectsArray = typeof(InsectSpecies).GetEnumValues();
                foreach (InsectSpecies insectSpecies in insectsArray)
                    lbObject.Items.Add(insectSpecies);


            }

            else
            {
                lbCategory.Enabled = true;
                if (lbCategory.SelectedItem != null)//to prevent crashes
                {
                    //{
                    CategoryType categoryType = (CategoryType)lbCategory.SelectedItem;


                    switch (categoryType)
                    {
                        case CategoryType.Mammal:                           
                            Array mammalsArray = typeof(MammalSpecies).GetEnumValues();
                            foreach (MammalSpecies mammalSpecies in mammalsArray)
                                lbObject.Items.Add(mammalSpecies);
                            break;

                        case CategoryType.Insect:
                            Array insectsArray = typeof(InsectSpecies).GetEnumValues();
                            foreach (InsectSpecies insectSpecies in insectsArray)
                                lbObject.Items.Add(insectSpecies);
                            break;
                    }
                } 
                   
            }
            
        }
        //Method to validate input in Name field
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

        //Method to validate input in Age field

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

        //Method to validate input in Species special character(characeter 1) field
        private string CheckCharacteristic_1(out bool success)
        {

            string char1 = txtChar1.Text;
            success = (!String.IsNullOrEmpty(char1));
            if(!success)
            {
                MessageBox.Show("Please fill the Animal's special character");
            }

            success = int.TryParse(char1, out _);// this is just to check if it is int or not.
            if (!success)
            {
                MessageBox.Show("Only numbers are allowed in animal's special character");
            }
            return char1;
        }

        //Method to validate input in Species special character(characeter 1) field
        private string CheckCharacteristic_2(out bool success)
        {
            string char2 = txtChar2.Text;
            success = (!String.IsNullOrEmpty(char2));
            if (!success)
            {
                MessageBox.Show("Please fill the Animal's special character");
            }
            return char2;
        }

        private void txtChar1_TextChanged(object sender, EventArgs e)
        {
        }

        //Method that returns bool true if all checks pass evaulation.
        private bool CheckInputs()
        {
            bool nameOk = false ;
            bool animalAgeOk = false;
            bool char1_ok = false;
            bool char2_ok = false;

            CheckName(out nameOk);
            CheckAge(out animalAgeOk);
            CheckCharacteristic_1(out char1_ok);
            CheckCharacteristic_2(out char2_ok);

            return nameOk && animalAgeOk && char1_ok && char2_ok;
        }

        private void cbListAll_CheckedChanged(object sender, EventArgs e)
        {
            CreateAnimalObjectList();
            lbCategory.ClearSelected();

        }
    }
}

