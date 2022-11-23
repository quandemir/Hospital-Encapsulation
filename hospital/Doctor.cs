using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace hospital
{
    internal class Doctor
    {
        private string name;
        public Adress address;
        public Date birthdate;

        public Doctor(string name, Adress address, Date birthdate)
        {
            this.name = name;
            this.address = address;
            this.birthdate = birthdate;
        }

        public void setName(string name)
        {
            this.name = name;
        }

        public string getName()
        {
            return this.name;
        }
    }
}
