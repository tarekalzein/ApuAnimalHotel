using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApuAnimalsHotel
{
    /// <summary>
    /// Container class that takes an animal id as key and holds an array of food schedule (as strings)
    /// </summary>
    [Serializable]
    public class FoodScheduleDictionary
    {
        Dictionary<string, string[]> m_foodDictionary;

        public FoodScheduleDictionary()
        {
            m_foodDictionary = new Dictionary<string, string[]>();
        }
        /// <summary>
        /// Method to check validity of key.
        /// </summary>
        /// <param name="id">animal id is the key of the dictionary</param>
        /// <returns>true if animal is added to collection</returns>
        public bool CheckKey(int id)
        {
            if (m_foodDictionary.ContainsKey(id.ToString()))
                return true;
            else
                return false;
        }

        /// <summary>
        /// Method to check if a give value exist in dictioary.
        /// </summary>
        /// <param name="value">the value to check in dictionary</param>
        /// <returns>true if value exists.</returns>
        public bool CheckValue(string[] value)
        {
            if (m_foodDictionary.ContainsValue(value))
                return true;
            else 
                return false;
        }

        /// <summary>
        /// Method to add key,value pair to dictionary.
        /// </summary>
        /// <param name="id">animal id that represents the key</param>
        /// <param name="item">an array of strings that represent the items in this animal's food schedule.</param>
        /// <returns>true on successful add.</returns>
        public bool AddFoodScheduleItem(int id, string[] item)
        {
            if (item != null )
            {
                if (CheckKey(id))
                {
                    m_foodDictionary[id.ToString()] = item;
                    return true;
                }
                else
                    m_foodDictionary.Add(id.ToString(), item);
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Retrieves an array of food schedule of a selected animal by its id.
        /// </summary>
        /// <param name="id">animal id to get its food schedule.</param>
        /// <returns></returns>
        public string[] GetFoodScheduleById(int id)
        {
            if (CheckKey(id))
                return m_foodDictionary[id.ToString()];

            else
                return new string[] { " No items has been added."};
        }

        /// <summary>
        /// removes a key,value pair if key exists in dictionary.
        /// </summary>
        /// <param name="id"></param>
        public void RemoveFoodItems(int id)
        {
            if (CheckKey(id))
                m_foodDictionary.Remove(id.ToString());
        }


    }    
}
