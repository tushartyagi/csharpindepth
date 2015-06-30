using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    // The first step is to create a new delegate type
    // CalculateSomething derives from System.MulticastDelegate 
    // which derives from System.Delegate
    public delegate int CalculateSomething(int param);

    public class SimpleDelegates
    {
        // The second step requires a method with the 
        // same signature
        public int Square(int x) { return x * x; }
        public int Cube(int x) { return x * x * x; }
    }

    
}
