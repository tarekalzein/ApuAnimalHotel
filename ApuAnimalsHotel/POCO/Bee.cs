﻿using System;
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
        }
        public Bee(Insect other)
        {
            this.Name = other.Name;
            this.Age = other.Age;
            this.Category = other.Category;
            this.Gender = other.Gender;
            this.CountOfLegs = other.CountOfLegs;
        }
        public Bee(string beeSpecies,int countOfLegs, string name, double age, CategoryType category,GenderType gender)
            :base(countOfLegs,name,age,category,gender)
        {
            beeSpecies = BeeSpecies;
        }
        public string BeeSpecies
        {
            get { return beeSpecies; }
            set
            {
                if (String.IsNullOrEmpty(value))
                    beeSpecies = value;
            }
        }
    }
}
