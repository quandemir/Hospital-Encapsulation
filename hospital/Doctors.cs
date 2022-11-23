using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace hospital
{
    internal class Doctors
    {
        public Doctor[] doctors;
        private int index;
        public Doctors(int number)
        {
            doctors = new Doctor[number];
            index = 0;
        }

        public bool insertDoctor(string name, Date birthday, Adress adress)
        {
            Doctor d = new Doctor(name, adress, birthday);

            doctors[index] = d;
            index++;

            return true;
        }

        public int searchDoctor(string name)
        {
            int inx = -1;

            for (int i = 0; i < index; i++)
            {
                if (doctors[i].getName() == name)
                {
                    inx = i;
                    break;
                }
            }

            return inx;
        }

        public void listDoctors()
        {
            for (int i = 0; i < index; i++)
            {
                Console.WriteLine(doctors[i].getName());
            }
        }
    }
}
