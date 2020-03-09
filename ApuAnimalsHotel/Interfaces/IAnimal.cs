using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApuAnimalsHotel.Enums;


namespace ApuAnimalsHotel.Interfaces
{
    /// <summary>
    /// Interface that sets the rules for all subclasses derived from the animal class. 
    /// </summary>
    interface IAnimal
    {
        GenderType Gender { get; set; }
        int ID { get; set; }
        string Name { get; set; }

        EaterType GetEaterType();

        FoodSchedule GetFoodSchedule();
        string GetSpecies();



    }
}
