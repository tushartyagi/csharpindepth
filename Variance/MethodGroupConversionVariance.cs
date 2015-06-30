using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variance
{
    static class MethodGroupConversionVariance
    {
        // A delegate which expects the methods to return 
        // an Animal type. This will showcase return type covariance 
        // wherein we use a method which returns a more derived type.
        delegate Animal AnimalMaker();

        // A delegate which expects the method to have Giraffe and 
        // Rabbit as arguments. Here we will show method param 
        // contravariance wherein the delegate is passed a method 
        // which can take a less derived arguments.
        delegate void UseSpecificAnimals(Giraffe father, Rabbit mother);

        // A delegate having return type covariance and 
        // method param contravariance
        delegate Animal ReturnOneAnimal(Rabbit rabbit, Giraffe giraffe);

        static void ReturnTypeCovariance()
        {
            Giraffe giraffe = new Giraffe();

            // This is an example of method group being covariant in their 
            // return types. The delegate definition very clearly wants an
            // Animal from the method group but the definition of MakeGiraffe
            // returns a giraffe.
            // From the article here: http://goo.gl/bpDPPX
            // "The caller of func is never going to get anything that they’re
            // not capable of dealing with."
            AnimalMaker animalMaker = new AnimalMaker(giraffe.MakeGiraffe);    

        }

        static void UseUnspecificAnimals(Animal father, Animal mother)
        {
            // And do something with them
        }

        static void MethodParamContravariance()
        {
            UseSpecificAnimals useSpecificAnimals = new UseSpecificAnimals(UseUnspecificAnimals);

            // While the delegate can accept the method which less derived params, 
            // the method itself requires that correct objects are passed.
            Giraffe giraffe = new Giraffe();
            Rabbit rabbit = new Rabbit();
            useSpecificAnimals(giraffe, rabbit);
        }

        static Giraffe ReturnGiraffe(Animal first, Animal second)
        {
            if (first.GetType() == typeof(Giraffe))
            {
                return (Giraffe)first;
            }
            else
            {
                return (Giraffe)second;
            }
        }

        static void CombineVariances()
        {
            ReturnOneAnimal pickGiraffe = new ReturnOneAnimal(ReturnGiraffe);
            
            Giraffe giraffe = new Giraffe();
            Rabbit rabbit = new Rabbit();
            pickGiraffe(rabbit, giraffe);

        }
    }
}
