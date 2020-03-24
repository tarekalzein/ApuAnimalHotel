using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApuAnimalsHotel.POCO
{
    class Recipe
    {
        private ListManager<string> m_ingredients;
        private string name;

        public Recipe()
        {
            //Not sure if this is needed yet.
            m_ingredients = new ListManager<string>();
            name = Name;
        }

        public ListManager<string> Ingredients { get; }
        public string Name { get; set; }

    }
}
