using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ApuAnimalsHotel.Interfaces;

namespace ApuAnimalsHotel
{
    class Staff
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
    }
}
