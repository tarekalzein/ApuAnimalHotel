using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApuAnimalsHotel.Enums;

namespace ApuAnimalsHotel.POCO
{
    /// <summary>
    /// A Class for the creation of Dog instance. It inherirts the properties from Animal and mammal, it has special property breed. 
    /// </summary>
    class Dog : Mammal
    {
        private string breed;
        private FoodScheduleDictionary foodSchedule;
        
        //Default constructor
        public Dog() : base()
        {
            //foodSchedule= new FoodSchedule();
            foodSchedule = new FoodScheduleDictionary();
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

        /// <summary>
        /// Method to fetch pre-configured eater type for dogs.
        /// </summary>
        /// <returns></returns>
        public override EaterType GetEaterType()
        {
            return EaterType.Carnivore;
        }


        /// <summary>
        /// Method to fetch hard-coded species type.
        /// </summary>
        /// <returns></returns>
        public override string GetSpecies()
        {
            return "Dog";
        }



        public override FoodScheduleDictionary GetFoodSchedule()
        {
            return foodSchedule;
        }
        public override bool AddFoodScheduleItem(string[] item)
        {
            foodSchedule.AddFoodScheduleItem(this.Id, item);
            return true;
        }
    }
}
