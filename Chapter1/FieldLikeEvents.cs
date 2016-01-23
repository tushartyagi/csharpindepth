using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1
{
    class FieldLikeEvents
    {
        public event EventHandler MyEvent
        {
            add
            {
                Console.WriteLine("Event has been added");
            }
            remove
            {
                Console.WriteLine("Event has been removed");
            }
        }

        public void DoNothing(object sender, EventArgs args)
        {

        }
    }
}
