using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nullables
{
    public static class TestNullable
    {
        public static void Display<T>(Nullable<T> nullableType)
            where T : struct
        {
            // The two primary properties of Nullable<T>, HasValue & GetValueOrDefault()
            if(nullableType.HasValue)
            {
                Console.WriteLine("Value: {0}", nullableType.Value);
            }
            else
            {
                Console.WriteLine("Default value: {0}", nullableType.GetValueOrDefault());
            }
            Console.WriteLine("To String: " + nullableType.ToString());
            Console.WriteLine("Hashcode " + nullableType.GetHashCode().ToString());
        }

        public static void Test()
        {
            // Two ways of creating a nullable<T> with values
            Nullable<int> nullableInt = new Nullable<int>(5);
            Nullable<float> nullableFloat = new Nullable<float>(12.03f);

            Nullable<decimal> nullableDec = new Nullable<decimal>();

            TestNullable.Display<int>(nullableInt);
            TestNullable.Display<decimal>(nullableDec);
            Console.ReadLine();
        }
    }
}
