using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApuAnimalsHotel.POCO;
using ApuAnimalsHotel.Interfaces;

namespace ApuAnimalsHotel
{
    class AnimalManager : ListManager<Animal>
    {

        private ListManager<Animal> listManager;

        private int id;

        //Constructor with no parameters. Creates a list of Animals and resets the ID counter to 1.
        public AnimalManager()
        {
            listManager = new ListManager<Animal>();
            id = 100;

        }

        public new void Add(Animal animalObj)
        {
            if (animalObj != null)
            {
                animalObj.Id = id;
                listManager.Add(animalObj);
                id++; //Increment ID after every successful add.

            }
        }

        //Method to get index number for an element in the list.
        public Animal GetElementAtPosition(int index)
        {
            if (listManager.CheckIndex(index))
            {
                Animal animal = listManager.GetAt(index);
                if (animal is Dog)
                    return new Dog((Dog)animal);
                if (animal is Cat)
                    return new Cat((Cat)animal);
                if (animal is Bee)
                    return new Bee((Bee)animal);
                if (animal is Butterfly)
                    return new Butterfly((Butterfly)animal);
                else
                    return null;
            }
            return null;

        }

        public int ElementCount
        {
            get { return listManager.Count; }
        }

        /// <summary>
        /// Method that with help of LINQ finds the animal object by its id.
        /// </summary>
        /// <param name="id">integer animal's id</param>
        /// <returns></returns>
        public Animal GetElementById(int id)//Not needed anymore
        {
            return listManager.GetById(id);
        }


        public new void SortByAge()
        {

            listManager.SortByAge();
        }
        public new void SortByName()
        { 
            listManager.SortByName();
        }

        public new void SortByGender()
        {
            listManager.SortByGender();
        }

        public new void SortById()
        {
            listManager.SortById();
        }

        public void DeleteAnimal(int index)
        {
            listManager.DeleteAt(index);
        }
    }
}
