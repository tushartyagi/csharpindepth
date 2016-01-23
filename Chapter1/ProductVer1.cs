using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    class Product
    {
        string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        decimal? price;
        public decimal? Price
        {
            get { return price; }
            set { price = value; }
        }

        public Product(string name, decimal? price = null)
        {
            this.Name = name;
            this.Price = price;
        }
    }

    class ProductNameComparer : IComparer
    {

        public int Compare(object x, object y)
        {
            Product first = (Product)x;
            Product second = (Product)y;
            return first.Name.CompareTo(second.Name);
        }
    }

}
