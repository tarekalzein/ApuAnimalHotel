using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private AnimalManager animalManager = new AnimalManager();
        private RecipeManager recipeManager = new RecipeManager();


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

        /// <summary>
        /// Method that checks all the inputs from user, on success it creats an instance of Animal and updates the GUI to show the created animal.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            Animal animal = null; //Null object pattern, just to be able to use the reference in animal creation later.

            bool success = CheckInputs();
            if (success)
            {

                if(lbObject.SelectedItem != null) //this is to avoid crash in app due to nullpointerexception when user changes the animal type without adding data
                {
                    string animalObjType = lbObject.SelectedItem.ToString();
                    CreateAnimalInstance(animalObjType, animal);
                }
            }
            UpdateAnimalListView();            
        }

        /// <summary>
        /// Method to update List view with a list of animals
        /// </summary>
        private void UpdateAnimalListView()
        {
            lvAnimalList.Items.Clear();

            //switch cases to find animal subtype to add it to the list view.
            for (int index = 0; index < animalManager.ElementCount; index++)
            {
                Animal animal = animalManager.GetElementAtPosition(index);  //Get the index of the animal in the list.
                string ch1 = "-";
                string ch2 = "-";

                //Dynamically bind the animal object to its subtype to get type specific properties such as breed 
                switch (animal)
                {
                    case Dog dog:
                        dog = (Dog)animal;
                        ch1 = "Teeth Count: " + dog.TeethCount.ToString();
                        ch2 = "Breed: " + dog.Breed;
                        break;

                    case Cat cat:
                        cat = (Cat)animal;
                        ch1 = "Teeth Count: " + cat.TeethCount.ToString();
                        ch2 = "Breed: " + cat.Breed;
                        break;

                    case Bee bee:
                        bee = (Bee)animal;
                        ch1 = "Count of legs: " + bee.CountOfLegs.ToString();
                        ch2 = "Bee species: " + bee.BeeSpecies;
                        break;

                    case Butterfly butterfly:
                        butterfly = (Butterfly)animal;
                        ch1 = "Count of legs: " + butterfly.CountOfLegs.ToString();
                        ch2 = "Wing color: " + butterfly.WingColor;
                        break;
                }

                //Create the string (row) to be added in the ListView. Each animal is a row.
                var row = new string[]
                {
                     animal.Id.ToString(),
                     animal.Name,
                     animal.Age.ToString(),
                     animal.Gender.ToString(),
                     animal.GetSpecies(),
                     (ch1+", "+ch2)

                };
                var lvitem = new ListViewItem(row);
                lvitem.Tag = animal;

                lvAnimalList.Items.Add(lvitem);

                ClearList();
            }
        }

        /// <summary>
        /// Method to empty the text and combo boxes so the user can enter fresh data.
        /// </summary>
        private void ClearList()
        {
            txtName.Clear();
            txtAge.Clear();
            cmbGender.SelectedIndex = (int)GenderType.Unknown;
            txtChar1.Clear();
            txtChar2.Clear();
            lbCategory.ClearSelected();
            lbObject.ClearSelected();

            lblChar1.Text = "";
            lblChar2.Text = "";
            txtChar1.Visible = false;
            txtChar2.Visible = false;
        }

        /// <summary>
        /// Method to load an image of the animal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            //this method is not complete yet. later it shall copy the image to database and link it to the created animal via a dictionary.
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

        /// <summary>
        /// Reads the user seleciton in lbObject (Dog, Cat, etc) and changes the visual labels of special characters accordingly
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// My own initialization of GUI items.
        /// </summary>
        private void InitializeGui()
        {

            lblChar1.Text = ""; //remove label text on first run.
            lblChar2.Text = "";


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

            //Find out which animal category is to be created.
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

            //Uncomment to create test lists of food schedule.
            //animal.AddFoodScheduleItem(animal.Id, FoodScheduleTest.AddTestFoodSchedule(animal));
            
        }
        /// <summary>
        /// Creates an instance of animal according to its type.
        /// </summary>
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbFoodSchedule.Items.Clear();
            lbEaterType.Items.Clear();

            //Get the animal object from animal manager in the selected index.
            if(lvAnimalList.SelectedItems.Count>0) // This if statement is to prevent nullpointerexception on listview index change. when we change selection this will raise the selecedindexchanged twice causing error.
            {               
                Animal animal = animalManager.GetElementAtPosition(lvAnimalList.SelectedIndices[0]);
                lbEaterType.Items.Add(animal.GetEaterType());// Put the Eater type in the eater type label
                UpdateLbFoodSchedule(animal);               
            }
            else
            {
                return;
            }
        }

        /// <summary>
        /// Action methods to sort the list view on headers click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvAnimalList_ColumnClick(object sender, ColumnClickEventArgs e)
        {          
            //Sorting the original list in animal manager
            //This can be turned to switch.
            if (e.Column==0)
            {
                animalManager.SortById();
                ResetColumnHeaders();
                chID.Text = "ID" + " ▼"; //to display that list is sorted according to this column.
            }
            else if (e.Column == 1)
            {
                animalManager.SortByName();
                ResetColumnHeaders();
                chName.Text = "Name" + " ▼";
            }
            else if(e.Column==2)
            {
                animalManager.SortByAge();
                ResetColumnHeaders();
                chAge.Text = "Age" + " ▼";
            }
            else if(e.Column==3)
            {
                animalManager.SortByGender();
                ResetColumnHeaders();
                chGender.Text = "Gender" + " ▼";
            }
            UpdateAnimalListView();
        }

        /// <summary>
        /// A simple and not very effecient method to reset the text in list view column headers to their defaults.
        /// </summary>
        private void ResetColumnHeaders()
        {
            chID.Text = "ID";
            chName.Text = "Name";
            chAge.Text = "Age";
            chGender.Text = "Gender";
            chSpecies.Text = "Species";
        }
        /// <summary>
        /// Opens the recipe form and returns the recipe object to be added to recipe manager and add it to the food details list box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            RecipeForm recipeForm = new RecipeForm();
            if(recipeForm.ShowDialog() == DialogResult.OK)
            {
                recipeManager.Add(recipeForm.Recipe);              
                lbFoodDetails.Items.Add(recipeForm.Recipe.ToString());
            }    
        }

        /// <summary>
        /// Opens the staff form and returns an object of staff to be added to the food details list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            StaffForm staffForm = new StaffForm();
            if(staffForm.ShowDialog() == DialogResult.OK)
            {
                lbFoodDetails.Items.Add(staffForm.Staff.ToString());
            }
        }

        /// <summary>
        /// Delete the selected row in the animal list view.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lvAnimalList.SelectedItems.Count>0)
            {
                animalManager.DeleteAnimal(lvAnimalList.SelectedIndices[0]);
                UpdateAnimalListView();
            }
            

        }

        /// <summary>
        /// Add a food schedule of the animal selected in lvAnimalList.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddFoodSchedule_Click(object sender, EventArgs e)
        {
            if(lvAnimalList.SelectedItems.Count>0)
            {
                FoodScheduleForm foodScheduleForm = new FoodScheduleForm();

                if (foodScheduleForm.ShowDialog() == DialogResult.OK)
                {
                    string[] foodScheduleItems = foodScheduleForm.GetFoodScheduleList();
                    Animal animal = animalManager.GetElementAtPosition(lvAnimalList.SelectedIndices[0]);
                    animal.AddFoodScheduleItem(foodScheduleItems);

                    UpdateLbFoodSchedule(animal);
                }
            }            
        }

        /// <summary>
        /// Updates the food schedule list.
        /// </summary>
        /// <param name="animal"></param>
        private void UpdateLbFoodSchedule(Animal animal)
        {
            lbFoodSchedule.Items.Clear();
            int i = 1;
            foreach (string item in animal.GetFoodSchedule().GetFoodScheduleById(animal.Id))
            {
                string test = "[" + (i) + "] " + item;
                lbFoodSchedule.Items.Add(test);
                i++;
            }

        }

        /// <summary>
        /// Edit the selected animal's food schedule by fetching the list from the animal object and show it in the food schedule form. returns the edited food schedule.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEditFoodSchedule_Click(object sender, EventArgs e)
        {
            if (lvAnimalList.SelectedItems.Count > 0)
            {
                Animal animal = animalManager.GetElementAtPosition(lvAnimalList.SelectedIndices[0]);
                FoodScheduleForm foodScheduleForm = new FoodScheduleForm(animal.GetFoodSchedule().GetFoodScheduleById(animal.Id));
                if (foodScheduleForm.ShowDialog() == DialogResult.OK)
                {
                    string[] foodScheduleItems = foodScheduleForm.GetFoodScheduleList();
                    animal.AddFoodScheduleItem(foodScheduleItems);

                    UpdateLbFoodSchedule(animal);

                }

            }
        }

        /// <summary>
        /// Removes the food schedule of the selected animal by removing its key, value from dictionary.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteFoodSchedule_Click(object sender, EventArgs e)
        {
            if (lvAnimalList.SelectedItems.Count > 0)
            {
                Animal animal = animalManager.GetElementAtPosition(lvAnimalList.SelectedIndices[0]);
                animal.GetFoodSchedule().RemoveFoodItems(animal.Id);
                UpdateLbFoodSchedule(animal);

            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ChosenFile = "";
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "XML Files (*.xml)|*.xml|Binary Files (*.bin)|*.bin";

            try 
            {
                ChosenFile = openFileDialog1.FileName;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //Check file extension xml/bin and run action accordingly
                    if (Path.GetExtension(openFileDialog1.FileName) == ".xml")
                    {
                        MessageBox.Show("Chosen file is XML");//replace with real code
                    }
                    else if (Path.GetExtension(openFileDialog1.FileName) == ".bin")
                    {
                        MessageBox.Show("Chosen file is bin"); //replace with real code.
                    }
                    //The app should remember what type is opened so it can save it with the same extension.
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error opening the selected file");
            }
        }

        private void binaryFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Binary file (*.bin)|*.bin";
            saveFileDialog1.FileName = "SavedData";
            saveFileDialog1.ShowDialog();
            //Check if file name is not empty and proceed with saving
        }

        private void textFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "txt file (*.txt)|*.txt";
            saveFileDialog1.FileName = "SavedData" + "-" + DateTime.Now.ToString("yyyMMddHHmmss"); //Default name

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrEmpty(saveFileDialog1.FileName))
                {
                    StreamWriter writer = new StreamWriter(saveFileDialog1.FileName);
                    try
                    {
                        writer.WriteLine("test"); //replace with serialization code.

                        //Check if file name is not empty and proceed with saving
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error writing to file");
                    }
                    finally
                    {
                        writer.Close();
                    }
                }                
            }
        }
    }
}