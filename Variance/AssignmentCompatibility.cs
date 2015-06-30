using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variance
{
    class AssignmentCompatibility
    {
        public AssignmentCompatibility()
        {
            // Eric Lippert (difference between covariance and assignment 
            // compatibility): http://goo.gl/zXOXG
            // Assignment Compatibility means the ability to assign a value 
            // of a more specific type to a storage of a compatible, less 
            // specific type.
            string str = "1234";
            object obj = str;
        }


    }
}
