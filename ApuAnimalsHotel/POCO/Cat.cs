using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApuAnimalsHotel.Enums;

namespace ApuAnimalsHotel.POCO
{
    class Cat : Mammal
    {
        private string breed;

        public Cat() : base()
        {

        }
        public Cat(Cat other)
        {
            this.Name = other.Name;
            this.Age = other.Age;
            this.Category = other.Category;
            this.Gender = other.Gender;
            this.TeethCount = other.TeethCount;
            this.Breed = other.breed;
        }
        public Cat(Mammal other)
        {
            this.Name = other.Name;
            this.Age = other.Age;
            this.Category = other.Category;
            this.Gender = other.Gender;
            this.TeethCount = other.TeethCount;
        }

        public Cat(string breed, int teethCount, string name, double age, CategoryType category, GenderType gender) :
            base(teethCount, name, age, category, gender)
        {
            breed = Breed;
        }
        public string Breed
        {
            get { return breed; }
            set
            {
                if (String.IsNullOrEmpty(value)) { breed = value; }
            }
        }
    }
}
