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
        public Mammal(int teethCount, string name, double age, CategoryType category, GenderType gender) : base(name, age,category,gender)
        {
            teethCount = TeethCount;
        }

        public int TeethCount { get; set; }
    }
}
