using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApuAnimalsHotel.POCO;

namespace ApuAnimalsHotel
{
    class AnimalManager
    {

        private List<Animal> m_animalList;
        private int id;

        //Constructor with no parameters. Creates a list of Animals and resets the ID counter to 1.
        public AnimalManager() 
        {
            m_animalList = new List<Animal>();
            id = 1;
            
        }

        public void Add(Animal animalObj)
        {
            if (animalObj != null)
            {
                animalObj.Id = id;
                m_animalList.Add(animalObj);
                id++; //Increment ID after every successful add.
                

            }
        }

        //Method to get index number for an element in the list.
        public Animal GetElementAtPosition(int index)
        {
            if (IsIndexValid(index))
            {
                if (m_animalList[index] is Dog)
                    return new Dog((Dog)m_animalList[index]);
                if (m_animalList[index] is Cat)
                    return new Cat((Cat)m_animalList[index]);
                if (m_animalList[index] is Bee)
                    return new Bee((Bee)m_animalList[index]);
                if (m_animalList[index] is Butterfly)
                    return new Butterfly((Butterfly)m_animalList[index]);
                return null;
            }
            else
                return null;
        }

        //method to check validity of index (if within scope).
        public bool IsIndexValid(int index)
        {
            return ((index >= 0) && (index < m_animalList.Count));
        }

        public int ElementCount
        {
            get { return m_animalList.Count; }
        }

       
        
    }
}
