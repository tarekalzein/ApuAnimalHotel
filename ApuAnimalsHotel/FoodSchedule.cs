using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApuAnimalsHotel
{
    class FoodSchedule
    {
        private List<string> foodDescriptionList;


        public FoodSchedule()
        {
            foodDescriptionList = new List<string>();            
        }

        public FoodSchedule(List<string>foodList)
        {
            foodList = foodDescriptionList;
        }

        public int Count {
            get
            {
                if(foodDescriptionList!=null)
                {
                    return foodDescriptionList.Count;
                }
                else
                {
                    return 0;
                }
            }
        }

        public bool ValidateIndex(int index)
        {
            return ((foodDescriptionList!=null) && (index >= 0) && (index < foodDescriptionList.Count));
        }

        public bool AddFoodScheduleItem(string item)
        {
            if (item != null)
            {
                foodDescriptionList.Add(item);
                return true;
            }
            else return false;
        }

        public string GetFoodSchedule(int index)
        {
            if (ValidateIndex(index))
            {
                return foodDescriptionList[index];
            }
            else return "error retreving food schedule";
        }



    }
}
