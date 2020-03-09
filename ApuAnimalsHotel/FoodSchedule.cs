using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApuAnimalsHotel
{
    /// <summary>
    /// This  class  is  intended  to  serve  as  schedule  for  feeding  of  the  animal.
    /// Each animal object will be creating an instance of this class (a food schedule) in order to add/edit/delete items
    /// </summary>
    class FoodSchedule
    {
        private List<string> foodDescriptionList;

        /// <summary>
        /// Default constructor that creates a food list.
        /// </summary>
        public FoodSchedule()
        {
            foodDescriptionList = new List<string>();            
        }

        public FoodSchedule(List<string>foodList)
        {
            foodList = foodDescriptionList;
        }
        /// <summary>
        /// Method that returns the list length or 0 if the list is not instatiated yet.
        /// </summary>
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

        /// <summary>
        /// Checks the validation of a given index, returns true if the food list is not null and has at least one item in it.
        /// </summary>
        /// <param name="index">int to check if there is an item in the list on that specific index</param>
        /// <returns></returns>
        public bool ValidateIndex(int index)
        {
            return ((foodDescriptionList!=null) && (index >= 0) && (index < foodDescriptionList.Count));
        }

        /// <summary>
        /// Method to add a new item to the diet/food list and returns true on success.
        /// </summary>
        /// <param name="item">string item of a food item</param>
        /// <returns></returns>
        public bool AddFoodScheduleItem(string item)
        {
            if (item != null)
            {
                foodDescriptionList.Add(item);
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Method to retrieve the food schedule of an animal, it takes an int that represents the index of an animal in the animalManager
        /// and find its foodschedule using the same parameter in the food list.
        /// </summary>
        /// <param name="index">int food list at a specific index </param>
        /// <returns></returns>
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
