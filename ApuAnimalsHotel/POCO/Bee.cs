using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApuAnimalsHotel.Enums;

namespace ApuAnimalsHotel.POCO
{
    class Bee : Insect
    {
        private string beeSpecies;

        public Bee():base()
        {

        }
        public Bee(Bee other)
        {
            this.Name = other.Name;
            this.Age = other.Age;
            this.Category = other.Category;
            this.Gender = other.Gender;
            this.CountOfLegs = other.CountOfLegs;
            this.beeSpecies = other.beeSpecies;
            this.Id = other.Id;

        }
        public Bee(Insect other)
        {
            this.Name = other.Name;
            this.Age = other.Age;
            this.Category = other.Category;
            this.Gender = other.Gender;
            this.CountOfLegs = other.CountOfLegs;
            this.Id = other.Id;

        }
        //public Bee(string beeSpecies,int countOfLegs, string name, double age, CategoryType category,GenderType gender)
        //    :base(countOfLegs,name,age,category,gender)
        //{
        //    beeSpecies = BeeSpecies;
        //}
        public string BeeSpecies
        {
            get { return beeSpecies; }
            set
            {
                if (!String.IsNullOrEmpty(value))                    
                    beeSpecies = value;
            }
        }

        public override string ToString()
        {            
            return String.Format("{0, -12} {1,-12}", base.ToString(), "Bee Species: "+BeeSpecies.ToUpper());
        }
    }
}
