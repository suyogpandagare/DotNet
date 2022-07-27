using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR
{
    public class Person
    {
        private string fName;
        private string lName;
        private DateTime birthDate;

        public Person()
        {
            this.fName = "Suyog";
            this.lName = "Pandagare";
            this.birthDate = new DateTime(1998,3,17);
            
        }

        public Person(string fName, string lName, DateTime birthDate)
        {
            this.fName = fName;
            this.lName = lName;
            this.birthDate = birthDate;
        }

        public override string ToString()
        {
            return base.ToString()+" "+fName+" "+lName+" "+birthDate.ToShortDateString();
        }
    }
}
