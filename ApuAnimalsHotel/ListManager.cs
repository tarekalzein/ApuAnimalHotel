using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using ApuAnimalsHotel.Interfaces;
using ApuAnimalsHotel.POCO;

namespace ApuAnimalsHotel
{
    class ListManager<T> : IListManager<T>
        
    {
        private List<T> m_list;

        public ListManager()
        {
            m_list = new List<T>();
        }
        public int Count => m_list.Count;

        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool Add(T aType)
        {
            m_list.Add(aType);
            return true;
        }

        public bool ChangeAt(T aType, int anIndex)
        {
            throw new NotImplementedException();
        }

        public bool CheckIndex(int index)
        {
            return ((index >= 0) && (index < m_list.Count));
        }

        public void DeleteAll()
        {
            m_list.Clear();
        }
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

        public T GetAt(int anIndex)
        {
            return m_list[anIndex];
        }

        public string[] ToStringArray()
        {
            throw new NotImplementedException();
        }

        public List<string> ToStringList()
        {
            throw new NotImplementedException();
        }

        public void SortById()
        {
            PropertyInfo propInfo = typeof(T).GetProperty("Id");
            m_list.Sort((x, y) =>
            Int32.Parse(propInfo.GetValue(x, null).ToString()).
            CompareTo
            (Int32.Parse(propInfo.GetValue(y, null).ToString())
            ));
        }

        public void SortByName()
        {
            PropertyInfo propInfo = typeof(T).GetProperty("Name");
            m_list.Sort((x, y) => string.Compare(propInfo.GetValue(x, null).ToString(), propInfo.GetValue(y, null).ToString(), true));
        }

        public void SortByAge()
        {
            PropertyInfo propInfo = typeof(T).GetProperty("Age");
            m_list.Sort((x, y) =>
            Int32.Parse(propInfo.GetValue(x, null).ToString()).
            CompareTo
            (Int32.Parse(propInfo.GetValue(y, null).ToString())
            ));
        }

        public void SortByGender()
        {
            PropertyInfo propInfo = typeof(T).GetProperty("Gender");
            m_list.Sort((x, y) => string.Compare(propInfo.GetValue(x, null).ToString(), propInfo.GetValue(y, null).ToString(), true));
        }

        public T GetById(int id) //Not needed anymore
        {
            PropertyInfo propInfo = typeof(T).GetProperty("Id");
            var value = m_list.First(item => Int32.Parse(propInfo.GetValue(item, null).ToString()) == id);
            return value;
        }


    }
}
