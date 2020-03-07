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
        private FoodSchedule foodSchedule;
        

        public Dog() : base()
        {
            foodSchedule= new FoodSchedule();

            AddTestItems();
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
            this.foodSchedule = other.GetFoodSchedule();
        }

        //Not used - Constructor copier that takes another mammal and copy properties to dog object
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

        public override EaterType GetEaterType()
        {
            return EaterType.Carnivore;
        }

        public override FoodSchedule GetFoodSchedule()
        {
            return foodSchedule;
        }

        public override string GetSpecies()
        {
            return "Dog";
        }

        private void AddTestItems()
        {
            foodSchedule.AddFoodScheduleItem("Morning: wet meat!");
            foodSchedule.AddFoodScheduleItem("Lunch: dog food and water!");
            foodSchedule.AddFoodScheduleItem("3PM: Treats");
            foodSchedule.AddFoodScheduleItem("Evenings: Leftovers");
        }
    }
}
