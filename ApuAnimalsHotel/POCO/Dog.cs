using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApuAnimalsHotel.Enums;

namespace ApuAnimalsHotel.POCO
{
    class Dog : Mammal
    {
        private string breed;

        public Dog() : base()
        {

        }
        public Dog(Dog other)
        {
            this.Name = other.Name;
            this.Age = other.Age;
            this.Category = other.Category;
            this.Gender = other.Gender;
            this.TeethCount = other.TeethCount;
            this.Breed = other.Breed;
            this.Id = other.Id;
        }
        public Dog(Mammal other)
        {
            this.Name = other.Name;
            this.Age = other.Age;
            this.Category = other.Category;
            this.Gender = other.Gender;
            this.TeethCount = other.TeethCount;
            this.breed = Breed;
            this.Id = other.Id;
        }

        public Dog(string breed, int teethCount, string name, double age, CategoryType category, GenderType gender) :
            base(teethCount, name, age, category, gender)
        {
            breed = Breed;
        }
        public string Breed 
        {
            get { return breed; }
            set
            {
                if (!String.IsNullOrEmpty(value)) { breed = value; }
            }
        }

        public override string ToString()
        {           
            return String.Format("{0, -12} {1,-12}", base.ToString(), " the breed is: " + Breed);
        }
    }
}
