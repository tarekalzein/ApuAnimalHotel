﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApuAnimalsHotel.POCO;
using ApuAnimalsHotel.Interfaces;
using System.IO;
using ApuAnimalsHotel.Enums;
using ApuAnimalsHotel.UtilitiesLibrary;

namespace ApuAnimalsHotel
{
    public class AnimalManager : ListManager<Animal>
    {


        private int id;

        //Constructor with no parameters. Creates a list of Animals and resets the ID counter to 1.
        public AnimalManager()
        {
            id = 100;
        }

        /// <summary>
        /// Adds Id to animal object then calls the add method from List Manager.
        /// </summary>
        /// <param name="animalObj"></param>
        public new void Add(Animal animalObj)
        {
            if (animalObj != null)
            {
                animalObj.Id = id;
                base.Add(animalObj);
                id++; //Increment ID after every successful add.
            }
        }

        /// <summary>
        /// Method to fetch animal object from the list manager and casts it to its type.
        /// </summary>
        /// <param name="index">index of the animal in list</param>
        /// <returns>object of animal from list manager</returns>
        public Animal GetElementAtPosition(int index)
        {
            if (base.CheckIndex(index))
            {
                Animal animal = base.GetAt(index);
                if (animal is Dog)
                    return new Dog((Dog)animal);
                if (animal is Cat)
                    return new Cat((Cat)animal);
                if (animal is Bee)
                    return new Bee((Bee)animal);
                if (animal is Butterfly)
                    return new Butterfly((Butterfly)animal);
                else
                    return null;
            }
            return null;
        }
        /// <summary>
        /// Getter for list count.
        /// </summary>
        public int ElementCount
        {
            get { return base.Count; }
        }

        /// <summary>
        /// Reference method to ListManager sorting method
        /// </summary>
        public new void SortByAge()
        {

            base.SortByAge();
        }

        /// <summary>
        /// eference method to ListManager sorting method
        /// </summary>
        public new void SortByName()
        { 
            base.SortByName();
        }

        /// <summary>
        /// eference method to ListManager sorting method
        /// </summary>
        public new void SortByGender()
        {
            base.SortByGender();
        }

        /// <summary>
        /// eference method to ListManager sorting method
        /// </summary>
        public new void SortById()
        {
            base.SortById();
        }

        /// <summary>
        /// eference method to ListManager sorting method
        /// </summary>
        /// <param name="index"></param>
        public void DeleteAnimal(int index)
        {
            base.DeleteAt(index);
        }

        public void SaveToTxt(string filePath)
        {
            SerializerHelper.SerializeToText(filePath, this);
        }
        //This Method can be re-done with a helper class to create instances of Animal.
        /// <summary>
        /// A buggy method that reads lines from a text file and use the data to create an instance of an animal.
        /// Known issues: Foodschedule items are added but the animal manager from the main form can't see it.
        /// Adding a comma to any of the fields will cause the application to show error message (error in reading the file) when importing the file again.
        /// This is because the string will be split with the comma as delimter. Adding any comma will cause index out of range exception.
        /// </summary>
        /// <param name="filePath"></param>
        public void ReadFromTxt(string filePath)
        {
            string line;
            GenderType gender=GenderType.Unknown;
            StreamReader reader = new StreamReader(filePath);
            //each line is supposed to hold data for an animal.
            while((line=reader.ReadLine()) !=null && !string.IsNullOrEmpty(line))
            {
                Animal animal = null;
                string[] words = line.Split(',');
                string type = words[0].Split(':')[1];
                string name= words[1].Split(':')[1];
                int age= int.Parse(words[2].Split(':')[1]);
                string genderString= words[3].Split(':')[1];

                
                System.Diagnostics.Debug.WriteLine(type+name+genderString);
                switch (genderString)
                {
                    case "Male":
                        gender = GenderType.Male;
                        break;
                    case "Female":
                        gender = GenderType.Female;
                        break;
                    case "Unknown":
                        gender = GenderType.Unknown;
                        break;
                }
                    
                string char1= words[4].Split(':')[1];
                string char2= words[5].Split(':')[1];

                System.Diagnostics.Debug.WriteLine(words[6].Split(':')[1]);
                string foodSheduleString = words[6].Split(':')[1];
                string[] data = foodSheduleString.Split('[', ']');

                List<string> foodSchedule= new List<string>();
                foreach (string item in data)
                {
                    if (!string.IsNullOrEmpty(item))
                        foodSchedule.Add(item);
                }

                //foodSchedule= foodSchedule.Where(x => !string.IsNullOrEmpty(x)).ToArray();

                switch (type)
                {
                    case "Dog":
                        animal = new Dog
                        {
                            Age = age,
                            Name = name,
                            TeethCount = int.Parse(char1),
                            Category = CategoryType.Mammal,
                            Breed = char2,
                            Gender = gender
                        };
                        break;

                    case "Cat":
                        animal = new Cat
                        {
                            Age = age,
                            Name = name,
                            TeethCount = int.Parse(char1),
                            Category = CategoryType.Mammal,
                            Breed = char2,
                            Gender = gender
                        };
                        break;

                    case "Bee":
                        animal = new Bee
                        {
                            Age = age,
                            Name = name,
                            Category = CategoryType.Insect,
                            CountOfLegs = int.Parse(char1),
                            BeeSpecies = char2,
                            Gender = gender,
                        };
                        break;

                    case "Butterfly":
                        animal = new Butterfly
                        {
                            Age = age,
                            Name = name,
                            Category = CategoryType.Insect,
                            CountOfLegs = int.Parse(char1),
                            WingColor = char2,
                            Gender = gender,
                        };
                        break;
                }
                //foreach(string item in foodSchedule)
                //{
                //    System.Diagnostics.Debug.WriteLine(item);

                //}
                //string[] test = { "test1", "test2" };


                animal.AddFoodScheduleItem(foodSchedule.ToArray());
                this.Add(animal);               

            }
            reader.Close();
        }
    }
}
