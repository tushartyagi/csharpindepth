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
        // an Animal type.
        delegate Animal AnimalMaker();

        delegate Animal NameMyAnimal(string professionalName, string funnyName);

        static void Foo()
        {
            Giraffe giraffe = new Giraffe();

            // This is an example of method group being covariant in their 
            // return types. The delegate definition very clearly wants an
            // Animal from the method group but the definition of MakeGiraffe
            // returns a giraffe.
            AnimalMaker animalMaker = new AnimalMaker(giraffe.MakeGiraffe);    

        }
        
    }
}
