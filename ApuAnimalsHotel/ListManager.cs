using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ApuAnimalsHotel.Interfaces;
using ApuAnimalsHotel.POCO;
using ApuAnimalsHotel.UtilitiesLibrary;

namespace ApuAnimalsHotel
{
    public class ListManager<T> : IListManager<T>
        
    {
        [XmlArray]        
        private List<T> m_list;


        /// <summary>
        /// Constructor that creates a generic list of a generic type.
        /// </summary>
        public ListManager()
        {
            m_list = new List<T>();
        }
        /// <summary>
        /// Method to return count of list items. returns 0 if list is null or =0.
        /// </summary>
        public int Count => m_list!=null ? m_list.Count : -1;


        /// <summary>
        /// Adds an object of Type into the list.
        /// </summary>
        /// <param name="aType"></param>
        /// <returns>true on success.</returns>
        public bool Add(T aType)
        {
            if (aType != null)
            {
                m_list.Add(aType);
                return true;

            }
            else 
                return false;
        }

        public bool ChangeAt(T aType, int anIndex)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Check if index is valid to avoid crashes.
        /// </summary>
        /// <param name="index">int index to check if valid </param>
        /// <returns>true if index is valid.</returns>
        public bool CheckIndex(int index)
        {
            return ((index >= 0) && (index < m_list.Count));
        }

        /// <summary>
        /// Deletes all items in the list.
        /// </summary>
        public void DeleteAll()
        {
            m_list.Clear();
        }
        /// <summary>
        /// Checks if index is valid and removes the instance object on that current index.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool DeleteAt(int index)
        {
            if (CheckIndex(index))
            {
                m_list.RemoveAt(index);
                return true;
            }
            else
                return false;
        }
        
        /// <summary>
        /// Fetches the instance from the list at a specified index.
        /// </summary>
        /// <param name="anIndex"></param>
        /// <returns></returns>
        public T GetAt(int anIndex)
        {
            if (CheckIndex(anIndex))
                return m_list[anIndex];

            else return default(T);
        }


        public string[] ToStringArray()
        {
            throw new NotImplementedException();
        }

        public List<string> ToStringList()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sorter for lists of type Animal, searches for property Id and compares it to sort the whole list.
        /// </summary>
        public void SortById()
        {
            try
            {
                PropertyInfo propInfo = typeof(T).GetProperty("Id");
                m_list.Sort((x, y) =>
                Int32.Parse(propInfo.GetValue(x, null).ToString()).
                CompareTo
                (Int32.Parse(propInfo.GetValue(y, null).ToString())
                ));
            }
            catch (Exception e)
            {
                throw e;
                //Code to handle exception.
            }            
        }
        /// <summary>
        /// Sorter for lists of type Animal, searches for property Name and compares it to sort the whole list.
        /// </summary>
        public void SortByName()
        {
            try
            {
                PropertyInfo propInfo = typeof(T).GetProperty("Name");
                m_list.Sort((x, y) => string.Compare(propInfo.GetValue(x, null).ToString(), propInfo.GetValue(y, null).ToString(), true));
            }
            catch(Exception e)
            {
                throw e;
                //Code to handle exception.
            }            
        }

        /// <summary>
        /// Sorter for lists of type Animal, searches for property Age and compares it to sort the whole list.
        /// </summary>
        public void SortByAge()
        {
            try
            {
                PropertyInfo propInfo = typeof(T).GetProperty("Age");
                m_list.Sort((x, y) =>
                Int32.Parse(propInfo.GetValue(x, null).ToString()).
                CompareTo
                (Int32.Parse(propInfo.GetValue(y, null).ToString())
                ));
            }
            catch (Exception e)
            {
                throw e;
                //Code to handle exception.
            }         
        }
        /// <summary>
        /// Sorter for lists of type Animal, searches for property Gender and compares it to sort the whole list.
        /// </summary>
        public void SortByGender()
        {
            try
            {
                PropertyInfo propInfo = typeof(T).GetProperty("Gender");
                m_list.Sort((x, y) => string.Compare(propInfo.GetValue(x, null).ToString(), propInfo.GetValue(y, null).ToString(), true));
            }
            catch (Exception e)
            {
                throw e;
                //Code to handle exception.
            }            
        }

        public void BinarySerialize(string fileName)
        {
            SerializerHelper.Serialize(m_list, SerializeFormat.Bin, fileName);
        }

        public void BinaryDeserialize(string fileName)
        {
            m_list = SerializerHelper.Deserialize<List<T>>(fileName, SerializeFormat.Bin);
        }

        public void XMLSerialize(string fileName)
        {
            SerializerHelper.Serialize<List<T>>(m_list, SerializeFormat.XML, fileName);
        }
        public void XMLDesrialize(string fileName)
        {
            m_list = SerializerHelper.Deserialize<List<T>>(fileName, SerializeFormat.XML);
        }

        public void TextSerialize(string fileName)
        {
            SerializerHelper.Serialize(m_list, SerializeFormat.TXT, fileName);
        }

        public void TextDeserialize(string fileName)
        {
            m_list = SerializerHelper.Deserialize<List<T>>(fileName, SerializeFormat.TXT);
        }
    }
}
