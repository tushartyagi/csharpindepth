using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void TestSimpleDelegates()
        {
            SimpleDelegates sd = new SimpleDelegates();
            
            // The third step is to create the instance of delegate
            CalculateSomething cSquare = new CalculateSomething(sd.Square);
            // This is also called MethodGroup because it contains the method name 
            // and the object on which it is called, and more than one methods may
            // be available due to overloading. The implicit conversation will 
            // convert a method group to any delegate type with compatible 
            // signature.
            CalculateSomething cCube = new CalculateSomething(sd.Cube);

            cSquare += cCube;

            // The fourth step is delegate instance invocation
            Console.WriteLine(cSquare(12));
            Console.WriteLine(cCube(3));
            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            TestSimpleDelegates();
        }

    }
}
