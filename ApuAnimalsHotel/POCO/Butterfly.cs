using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApuAnimalsHotel.POCO
{
    class Butterfly : Insect
    {
        private string wingColor;

        public Butterfly(): base()
        {

        }

        public Butterfly(Butterfly other)
        {
            this.Name = other.Name;
            this.Age = other.Age;
            this.Category = other.Category;
            this.Gender = other.Gender;
            this.CountOfLegs = other.CountOfLegs;
            this.wingColor = other.wingColor;
        }

        public Butterfly(Insect other)
        {
            this.Name = other.Name;
            this.Age = other.Age;
            this.Category = other.Category;
            this.Gender = other.Gender;
            this.CountOfLegs = other.CountOfLegs;
        }

        public string WingColor
        {
            get { return wingColor; }
            set 
            {
                if (!String.IsNullOrEmpty(value))
                    wingColor = value;
            }
        }
        public override string ToString()
        {
            return base.ToString()+" Wings Color is: "+WingColor;
        }
    }
}
