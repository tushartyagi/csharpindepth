using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variance
{
    class Covariance
    {
        /* http://goo.gl/53fWh
         * The first thing to understand is that it is a relation which is *variant.
         * If it preserves the direction of assignment, then it is covariant.
         */

        public Covariance()
        {
            // A valid assignment operation
            Animal animal = new Giraffe();

            // This line shows that IEnumerator<T> is covariant for type T
            IEnumerable<Animal> animals = new List<Giraffe>();
        }

        public void ArrayCovariance()
        {
            // Arrays are always covariant since
            Animal[] animals = new Giraffe[10];

            // and
            object[] strings = new String[5];

            // but these can be misused
            // strings[0] = 12; 
            // The above code compiles fine but breaks at runtime.
        }
    }
}
