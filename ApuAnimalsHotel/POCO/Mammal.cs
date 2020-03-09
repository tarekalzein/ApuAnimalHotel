using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApuAnimalsHotel.POCO;
using ApuAnimalsHotel.Enums;
using ApuAnimalsHotel.Interfaces;

namespace ApuAnimalsHotel.POCO
{
    /// <summary>
    /// Abstract class that inherits the abstract class Animal and the interface IAnimal.
    /// In addition to the properties in Animal, it has special property TeethCount. 
    /// </summary>
    abstract class Mammal : Animal
    {
        private int teethCount;
        //Default constructor
        public Mammal(): base()
        {
            Category = CategoryType.Mammal;
            teethCount = 0;
        }
        //Not userd - Constructor to copy  object.
        public Mammal(Mammal other) 
        {
            this.Name = other.Name;
            this.Age = other.Age;
            this.Category = other.Category;
            this.Gender = other.Gender;
            this.TeethCount = other.TeethCount;
            Category = CategoryType.Mammal;
        }
        public Mammal(int teethCount, string name, double age, CategoryType category, GenderType gender) : base(name, age, category, gender)
        {
            teethCount = TeethCount;
            category = CategoryType.Mammal;
        }

        public Mammal (Animal other)
        {
            Category = CategoryType.Mammal;
            this.Name = other.Name;
            this.Age = other.Age;
            this.Gender = other.Gender;
            this.teethCount = TeethCount;
        }

        public int TeethCount
        {
            get
            {
                return teethCount;
            }
            set 
            {
                if (value > 0)
                    teethCount = value;
            } 
        }
        //To DO: ToString()

        public override string ToString()
        {            
            return String.Format("{0, -25} {1, -12}", base.ToString(), ("Count of teeth: " + TeethCount + ", "));
        }        

    }
}
