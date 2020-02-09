using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApuAnimalsHotel.Enums;

namespace ApuAnimalsHotel.POCO
{
    class Animal
    {
        private Animal animal;

        public Animal(Animal animal)
        {
            this.animal = animal;
        }

        public Animal(string name, double age, CategoryType category, GenderType gender)
        {
            name = Name;
            age = Age;
            category = Category;
            gender = Gender;
        }
        public string Name { get; set; }
        public double Age { get; set; }
        public CategoryType Category { get; set; }

        public GenderType Gender { get; set; }

    }
}
