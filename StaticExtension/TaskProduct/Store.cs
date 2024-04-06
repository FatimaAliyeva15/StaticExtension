using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace TaskProduct
{
    internal class Store
    {
        private static int _id;
        public int Id { get; set; }
        public Store()
        {
            _id++;
            Id = _id;
        }

        public Product[] Products = new Product[] { };

        public void AddProduct(Product product)
        {
            Array.Resize(ref Products, Products.Length + 1);
            Products[Products.Length - 1] = product;
        }

        public Product[] RemoveProductByNo(int no)
        {
            Product[] removeproduct = { };

            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].No != no)
                {
                    Array.Resize(ref removeproduct, Products.Length + 1);
                    removeproduct[Products.Length - 1] = Products[i];
                }
            }
            return removeproduct;
        }

        public Product[] GetProduct(int No)
        {
            Product[] productno = { };

            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].No == No)
                {
                    Array.Resize(ref productno, productno.Length + 1);
                    productno[productno.Length - 1] = Products[i];
                }
            }
            return productno;
        }

        public Product[] FilterProductsByType(string type)
        {
            Product[] producttype = { };

            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].Type == type)
                {
                    Array.Resize(ref producttype, producttype.Length + 1);
                    producttype[producttype.Length - 1] = Products[i];
                }
            }
            return producttype;
        }

        public Product[] FilterProductsByName(string name)
        {
            Product[] productname = { };

            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].Name == name)
                {
                    Array.Resize(ref productname, productname.Length + 1);
                    productname[productname.Length - 1] = Products[i];
                }
            }
            return productname;
        }

        public void Sale(int no, Person person)
        {
            double sale;
            for (int i = 0; i < Products.Length; i++)
            {
                if (Products[i].No == no)
                {
                    Products[i].Count--;
                    sale = person.Cash - Products[i].Price;
                }
            }
        }
    }
}
