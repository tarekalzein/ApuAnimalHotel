using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApuAnimalsHotel.POCO
{
    public class Recipe
    {
        //private ListManager<string> m_ingredients;
        private List<string> m_ingredients;

        private string name;

        /// <summary>
        /// Constructor method that instantiates a generic list.
        /// </summary>
        public Recipe()
        {
            //m_ingredients = new ListManager<string>();
            m_ingredients = new List<string>();

            name = Name;
        }
        /// <summary>
        /// Getter for the list
        /// </summary>


        /// <summary>
        /// Getter for the Name property
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Method to add ingredient item, it calls the generic method Add in List Manager.
        /// </summary>
        /// <param name="ingredient"></param>
        public void AddIngredient(string ingredient)
        {
            m_ingredients.Add(ingredient);
        }

        /// <summary>
        /// Overriding toString method.
        /// </summary>
        /// <returns>One string that contains the name and all ingredients in one line.</returns>
        public override string ToString()
        {
            string ingredients = "";
            for(int i=0; i<m_ingredients.Count; i++)
            {
                //ingredients += m_ingredients.GetAt(i) + ". "; ;
                ingredients += m_ingredients[i] + ". "; ;

            }
            return Name + ": " + ingredients;
        }



    }
}
