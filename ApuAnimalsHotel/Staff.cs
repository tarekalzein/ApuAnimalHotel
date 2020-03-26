using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApuAnimalsHotel.Interfaces;

namespace ApuAnimalsHotel
{
    public class Staff
    {
        private string name;
        private IListManager<string> m_qualifications;

        public Staff()
        {
            m_qualifications = new ListManager<string>();
        }

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
            }
        }

        public void AddQualification(string qualification)
        {
            m_qualifications.Add(qualification);
        }

       public override string ToString()
        {
            string qualifications = "";
            for (int i=0; i<m_qualifications.Count; i++)
            {
                qualifications += m_qualifications.GetAt(i)+ ". ";
                //qualifications += " ";
            }

            return Name +": "+ qualifications; 
        }
    }
}
