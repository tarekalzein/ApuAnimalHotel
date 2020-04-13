using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApuAnimalsHotel.Enums;
using ApuAnimalsHotel.Interfaces;

namespace ApuAnimalsHotel.POCO
{
    /// <summary>
    /// Abstract class that inherits the abstract class Animal and the interface IAnimal.
    /// In addition to the properties in Animal, it has special property TeethCount. 
    /// </summary>
    [Serializable]
    public abstract class Insect : Animal
    {
        private int countOfLegs;

        public Insect():base()
        {
            Category = CategoryType.Insect;

        }

        public Insect(Insect other)
        {
            this.Name = other.Name;
            this.Age = other.Age;
            this.Category = other.Category;
            this.Gender = other.Gender;
            this.CountOfLegs = other.CountOfLegs;
            Category = CategoryType.Insect;
        }

        public Insect(Animal other)
        {
            Category = CategoryType.Insect;
            this.Name = other.Name;
            this.Age = other.Age;
            this.Gender = other.Gender;
            this.countOfLegs = CountOfLegs;
        }

        //public Insect(int countOfLegs, string name, double age, CategoryType category, GenderType gender) :base(name,age, category,gender)
        //{
        //    countOfLegs = CountOfLegs;
        //    category = CategoryType.Insect;
        //}
        public int CountOfLegs {
            get { return countOfLegs; }
            set
            {
                if (value>0)
                {
                    countOfLegs = value;
                }
            }
        }

        //To Do: ToString()
        public override string ToString()
        {
            return String.Format("{0, -25} {1, -12}", base.ToString(),("Count of Legs: " + CountOfLegs +", "));
        }
    }
}
