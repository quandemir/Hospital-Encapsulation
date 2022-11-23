using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital
{
    internal class Adress
    {

        private string text;
        private string city;

        public Adress(string text, string city)
        {
            this.text = text;
            this.city = city;
        }

        public void setText(string text)
        {
            this.text = text;
        }
        public void setCity(string city)
        {
            this.city = city;
        }

        public string getText()
        {
            return this.text;
        }

        public string getCity()
        {
            return this.city;
        }
    }
}
