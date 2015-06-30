using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variance
{
    class Program
    {
        static void Main(string[] args)
        {

            

        }

        static void BrokenCovariance()
        {
            // An example showing how the covariance is broken wrt 
            // Arrays in C#
            Animal[] animals = new Giraffe[10];

            // Although the below code doesn't throw a compile time error, it will 
            // fail at runtime because Rabbit != Giraffe
            animals[4] = new Rabbit();
        }

    }
}
