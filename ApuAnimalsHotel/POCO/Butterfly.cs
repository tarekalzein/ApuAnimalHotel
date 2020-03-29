using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApuAnimalsHotel.Enums;

namespace ApuAnimalsHotel.POCO
{
    class Butterfly : Insect
    {
        private string wingColor;
        private FoodScheduleDictionary foodSchedule;


        public Butterfly(): base()
        {
            foodSchedule = new FoodScheduleDictionary();
        }

        public Butterfly(Butterfly other)
        {
            this.Name = other.Name;
            this.Age = other.Age;
            this.Category = other.Category;
            this.Gender = other.Gender;
            this.CountOfLegs = other.CountOfLegs;
            this.wingColor = other.wingColor;
            this.Id = other.Id;
            this.foodSchedule = other.GetFoodSchedule();
        }

        public Butterfly(Insect other)
        {
            this.Name = other.Name;
            this.Age = other.Age;
            this.Category = other.Category;
            this.Gender = other.Gender;
            this.CountOfLegs = other.CountOfLegs;
            this.Id = other.Id;

        }

        public string WingColor
        {
            get { return wingColor; }
            set 
            {
                if (!String.IsNullOrEmpty(value))
                    wingColor = value;
            }
        }

        public override EaterType GetEaterType()
        {
            return EaterType.Herbivore;
        }

        //public override FoodSchedule GetFoodSchedule()
        //{
        //    return foodSchedule;
        //}



        public override FoodScheduleDictionary GetFoodSchedule()
        {
            return foodSchedule;
        }

        public override string GetSpecies()
        {
            return "Butterfly";
        }
        public override string ToString()
        {
            return String.Format("{0, -12} {1,-12}", base.ToString(), " Wings Color is: " + WingColor);

        }

        public override bool AddFoodScheduleItem(string[] item)
        {
            foodSchedule.AddFoodScheduleItem(this.Id, item);
            return true;
        }
    }
}
