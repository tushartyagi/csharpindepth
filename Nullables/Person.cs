using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullables
{
    class Person
    {
        DateTime  birth;
        DateTime? death;
        string name;

        public TimeSpan Age
        {
            get
            {
                if(death == null)
                {
                    return DateTime.Now - birth;
                }
                else
                {
                    // As of now, the two values are DateTime. If we use 
                    // death instead of death.Value, then this becomes a 
                    // case of implicit conversion and the return value 
                    // needs to be changed to Timespan?
                    return death.Value - birth;
                }
            }
        }

        public Person(string name, DateTime birth, DateTime? death)
        {
            this.name  = name;
            this.birth = birth;
            this.death = death;
        }

    }

    public static class Test
    {
        public static void Test()
        {
            Person a = new Person("Papa", new DateTime(1953, 6, 16), new DateTime(2015, 5, 3));
            Person b = new Person("Me", new DateTime(1990, 1, 29), null);
            Console.WriteLine(a.Age);
            Console.WriteLine(b.Age);
            Console.ReadLine();
        }
    }
}
