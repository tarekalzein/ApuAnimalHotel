using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApuAnimalsHotel.Interfaces;

namespace ApuAnimalsHotel.Interfaces
{
   
    interface IListManager<T>
    {
        /// <summary>
        /// Return the number of items in the collection m_list
        /// </summary>
        int Count { get; }

        /// <summary>
        /// Add an object to the collection m_list
        /// </summary>
        /// <param name="aType">A Type</param>
        /// <returns>Success: True, otherwise: false</returns>                    
        bool Add(T aType);

        /// <summary>
        /// Changes an object at a specific index in the collection m_list
        /// </summary>
        /// <param name="aType">A Type</param>
        /// <param name="anIndex">Index to change at0</param>
        /// <returns>True on success</returns>
        bool ChangeAt(T aType, int anIndex);

        /// <summary>
        /// Check index if exists
        /// </summary>
        /// <param name="index"></param>
        /// <returns>True on Success</returns>
        bool CheckIndex(int index);

        /// <summary>
        /// Method to delete all data in m_list
        /// </summary>
        void DeleteAll();

        /// <summary>
        /// Get object with index on m_list
        /// </summary>
        /// <param name="anIndex">an index</param>
        /// <returns>true on success</returns>
        T GetAt(int anIndex);

        /// <summary>
        /// Prepare and return a list of strings where each string contains info about an object in m_list
        /// </summary>
        /// <returns>List of strings</returns>
        string[] ToStringArray();

        /// <summary>
        /// A list of string[] lists that hold data about an object in m_list
        /// </summary>
        /// <returns>List of strings</returns>
        List<string> ToStringList();

        void BinarySerialize(string fileName);

        void BinaryDeserialize(string fileName);
        void XMLSerialize(string fileName);

        void TextSerialize(string fileName);

        void TextDeserialize(string fileName);

    }
}
