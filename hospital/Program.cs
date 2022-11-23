using hospital;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace hospital
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctors hospital1 = new Doctors(10);

            int selection = 0;

            do
            {

                Console.WriteLine("         MENU");
                Console.WriteLine("1 - Insert a new doctor");
                Console.WriteLine("2 - Search a doctor");
                Console.WriteLine("3 - List all doctors");
                Console.WriteLine("4 - EXIT");
                Console.Write("Enter an operation: ");
                selection = Convert.ToInt32(Console.ReadLine());

                switch (selection)
                {
                    case 1:

                        Console.Write("Enter the name: ");
                        string name = Console.ReadLine();


                        Console.Write("Enter the birthday (dd-mm-yyyy): ");
                        string birthday = Console.ReadLine();
                        string[] dates = birthday.Split('-');


                        int day = Convert.ToInt32(dates[0]);
                        int month = Convert.ToInt32(dates[1]);
                        int year = Convert.ToInt32(dates[2]);

                        Date dateBirthday = new Date(day, month, year);


                        Console.Write("Enter the address text: ");
                        string text = Console.ReadLine();
                        Console.Write("Enter the city: ");
                        string city = Console.ReadLine();

                        Adress objectAdress = new Adress(text, city);

                        bool control = hospital1.insertDoctor(name.ToUpper(), dateBirthday, objectAdress);

                        if (control)
                            Console.WriteLine("Successfully added!");
                        else
                            Console.WriteLine("Not added!");
                        Console.ReadLine();

                        break;
                    case 2:

                        Console.Write("Enter the name: ");
                        string searchName = Console.ReadLine();

                        int inx = hospital1.searchDoctor(searchName.ToUpper());

                        if (inx == -1)
                        {
                            Console.WriteLine("There is no doctor named this entity");
                        }
                        else
                        {
                            Console.WriteLine("{0}-{1}-{2}", hospital1.doctors[inx].birthdate.getDay(),
                                                                hospital1.doctors[inx].birthdate.getMonth(),
                                                                hospital1.doctors[inx].birthdate.getYear());

                            Console.WriteLine("{0} - {1}", hospital1.doctors[inx].address.getText(),
                                                            hospital1.doctors[inx].address.getCity());
                        }

                        Console.ReadLine();

                        break;
                    case 3:

                        hospital1.listDoctors();

                        Console.ReadLine();

                        break;
                    default:

                        Console.WriteLine("Wrong entry!!!");

                        break;
                }

                Console.Clear();

            } while (selection != 4);
        }
    }
}
