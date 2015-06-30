using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variance
{
    class Contravariance
    {
        /* http://goo.gl/53fWh
         * The first thing to understand is that it is a relation which is *variant.
         * If it reverses the direction of assignment, then it is contravariant.
         */

        public Contravariance()
        {
            // A valid assignment operation
            Animal animal = new Giraffe();
            List<Animal> animals = new List<Animal>();
            
            // This line shows that IEnumerator<T> is contravariant for type T
            IEnumerable<Giraffe> giraffes = Reverse(animals);
        }

        public Giraffe Reverse(Animal animal)
        {
            Giraffe giraffe = (Giraffe)animal;
            // Some super complex activity
            return giraffe;
        }

        public IEnumerable<Giraffe> Reverse(IEnumerable<Animal> animals)
        {
            List<Giraffe> giraffes = new List<Giraffe>();
            foreach (Animal animal in animals)
            {
                // Some super complex activity
                giraffes.Add((Giraffe)animal);
            }
            
            return giraffes.AsReadOnly();
        }

    }
}
