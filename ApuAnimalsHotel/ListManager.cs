using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApuAnimalsHotel.Interfaces;

namespace ApuAnimalsHotel
{
    class ListManager<T> : IListManager<T>
    {
        private List<T> m_list;

        public ListManager()
        {
            m_list = new List<T>();
        }
        public int Count => throw new NotImplementedException();

        public bool Add(T aType)
        {
            throw new NotImplementedException();
        }

        public bool ChangeAt(T aType, int anIndex)
        {
            throw new NotImplementedException();
        }

        public bool CheckIndex(int index)
        {
            throw new NotImplementedException();
        }

        public void DeleteAll()
        {
            throw new NotImplementedException();
        }

        public T GetAt(int anIndex)
        {
            throw new NotImplementedException();
        }

        public string[] ToStringArray()
        {
            throw new NotImplementedException();
        }

        public List<string> ToStringList()
        {
            throw new NotImplementedException();
        }

    }
}
