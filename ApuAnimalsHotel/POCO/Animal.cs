using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApuAnimalsHotel.Enums;
using ApuAnimalsHotel.Interfaces;

namespace ApuAnimalsHotel.POCO
{
    abstract class Animal : IAnimal
    {
        private string name;
        private int id;
        private double age;
        private CategoryType category;
        private GenderType gender;

        //empty constructor with some initialization
        public Animal()
        {
           
            name = "";
            age = 0;
            gender = GenderType.Unknown;
             
        }

        //Constructor to copy object.
        public Animal(Animal other)
        {
            this.name = other.name;
            this.age = other.age;
            this.category = other.category;
            this.gender = other.gender;
            this.id = other.id;
        }

        public Animal(string name, double age, CategoryType category, GenderType gender)
        {
            name = Name;
            age = Age;
            category = Category;
            gender = Gender;
            
        }
        //Getters and setters
        public string Name { get; set; }
        public double Age { get; set; }
        public CategoryType Category { get; set; }

        public GenderType Gender { get; set; }

        public int Id { get; set; }
        public int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public abstract EaterType GetEaterType();

        public abstract FoodSchedule GetFoodSchedule();


        public abstract string GetSpecies();



        public override string ToString()
        {
            string strGender = Enum.GetName(typeof(GenderType), Gender);
            string strCategory = Enum.GetName(typeof(CategoryType), Category);

            string strOut = String.Format(" {0, -12} {1,-20} {2, -20} {3, -20} ",
               Id, Name, Age, strGender, strCategory);
            //string strOut = "Name is " + Name + " Age is " + Age + " Gender is" + strGender + " Categor is " + strCategory;

            strOut = strOut.ToUpper();
            return strOut;
        }
    }
}
