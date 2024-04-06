using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProduct
{
    internal class Person
    {
        private static int _id;
        public int Id { get; set; }

        public string Fullname { get; set; }

        private sbyte _age;

        public sbyte Age
        {
            get { return _age; }

            set
            {
                bool checkAge = false;

                do
                {
                    if (value >= 0 && value <= 125)
                    {
                        _age = value;
                    }
                    else
                    {
                        Console.WriteLine("Age duzgun daxil edilmeyib");

                        string age;
                        do
                        {
                            Console.Write("Age: ");
                            age = Console.ReadLine();
                        } while ((!sbyte.TryParse(age, out value)));
                    }
                } while (!checkAge);
            }

        }

        public double Cash { get; set; }




        public Person()
        {
            _id++;
            Id = _id;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Fullname: {Fullname}, Age: {Age}, Cash: {Cash}";
        }
    }
}
