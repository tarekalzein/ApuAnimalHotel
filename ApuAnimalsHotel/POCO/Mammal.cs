using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApuAnimalsHotel.POCO;
using ApuAnimalsHotel.Enums;

namespace ApuAnimalsHotel.POCO
{
    class Mammal : Animal
    {
        private int teethCount;
        public Mammal(): base()
        {
            Category = CategoryType.Mammal;
        }

        public Mammal(Mammal other) 
        {
            this.Name = other.Name;
            this.Age = other.Age;
            this.Category = other.Category;
            this.Gender = other.Gender;
            this.TeethCount = other.TeethCount;
            Category = CategoryType.Mammal;
        }
        public Mammal(int teethCount, string name, double age, CategoryType category, GenderType gender) : base(name, age,category,gender)
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
    }
}
