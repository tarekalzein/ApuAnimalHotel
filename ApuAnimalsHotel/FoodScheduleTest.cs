using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApuAnimalsHotel.POCO;

namespace ApuAnimalsHotel
{
    class FoodScheduleTest
    {
        public static string[] AddTestFoodSchedule(Animal animal)
        {
           
            string[] items;
            if (animal is Dog)
            {
                items = new string[]
                {
                    "Morning: wet meat!",
                    "Lunch: dog food and water!",
                    "3PM: Treats",
                    "Evenings: Leftovers"
                };
                return items;
            }
            else if (animal is Cat)
            {
                items = new string[]
                {
                    "Morning: wet meat!",
                    "Lunch: dog food and water!",
                    "3PM: Treats",
                    "Evenings: Leftovers"
                };
                return items;
            }
            else if (animal is Bee)
            {
                items = new string[]
                {
                    "Morning: Acacia flowers!",
                    "Lunch: Fruit nectar!",
                    "3PM: Frozen treats",
                    "Evenings: Pollen"
                };
                return items;
            }
            else if (animal is Butterfly)
            {
                items = new string[]
                {
                    "Morning: flowers!",
                    "Lunch: Leaves!",
                    "3PM: Fruit juice",
                    "Evenings: Pollen"
                };
                return items;
            }

            return null;
        }
    }
}
