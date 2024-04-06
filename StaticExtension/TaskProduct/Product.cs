using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProduct
{
    internal class Product
    {
        private static int _no=0;

        public int No { get; set; }

        public string Name { get; set; }

        private double _price;

        public double Price
        {
            get { return _price; }

            set
            {
                bool checkPrice = false;
                do
                {
                    if (value > 0)
                    {
                        _price = value;
                    }
                    else
                    {
                        Console.WriteLine("Price duzgun daxil edilmeyib");

                        string price;
                        do
                        {
                            Console.Write("Price: ");
                            price = Console.ReadLine();
                        } while ((!double.TryParse(price, out value)));
                    }

                } while (!checkPrice);
            }
        }

        public string Type { get; set; }

        private int _count;
        public int Count
        {
            get { return _count; }

            set
            {
                if (value > 0)
                {
                    _count = value;
                }
                else
                {
                    Console.WriteLine("Mehsul sayi menfi deyer ala bilmez");
                }
            }
        }

        public Product(string name, double price, string type, int count)
        {
            _no++;  
            No = _no;
            Name = name;
            Price = price;
            Type = type;
            Count = count;
        }

        public override string ToString()
        {
            return $"No: {No}, Name: {Name}, Price: {Price}, Type: {Type}, Count: {Count}";
        }
    }
}
