using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product("name");
            p.Price = null;

            FieldLikeEvents f = new FieldLikeEvents();
            f.MyEvent += new EventHandler(f.DoNothing);
        }
    }
}
