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
        public Dog(string breed,int teethCount, string name, double age,CategoryType category,GenderType gender ) :
            base (teethCount,name,age, category,gender)
        {
            breed = Breed;
        }
        public string Breed { get; set; }
    }
}
