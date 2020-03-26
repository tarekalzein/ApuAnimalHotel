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

        /// <summary>
        /// Adds Id to animal object then calls the add method from List Manager.
        /// </summary>
        /// <param name="animalObj"></param>
        public new void Add(Animal animalObj)
        {
            if (animalObj != null)
            {
                animalObj.Id = id;
                listManager.Add(animalObj);
                id++; //Increment ID after every successful add.
            }
        }

        /// <summary>
        /// Method to fetch animal object from the list manager and casts it to its type.
        /// </summary>
        /// <param name="index">index of the animal in list</param>
        /// <returns>object of animal from list manager</returns>
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
        /// <summary>
        /// Getter for list count.
        /// </summary>
        public int ElementCount
        {
            get { return listManager.Count; }
        }

        /// <summary>
        /// Reference method to ListManager sorting method
        /// </summary>
        public new void SortByAge()
        {

            listManager.SortByAge();
        }

        /// <summary>
        /// eference method to ListManager sorting method
        /// </summary>
        public new void SortByName()
        { 
            listManager.SortByName();
        }

        /// <summary>
        /// eference method to ListManager sorting method
        /// </summary>
        public new void SortByGender()
        {
            listManager.SortByGender();
        }

        /// <summary>
        /// eference method to ListManager sorting method
        /// </summary>
        public new void SortById()
        {
            listManager.SortById();
        }

        /// <summary>
        /// eference method to ListManager sorting method
        /// </summary>
        /// <param name="index"></param>
        public void DeleteAnimal(int index)
        {
            listManager.DeleteAt(index);
        }
    }
}
