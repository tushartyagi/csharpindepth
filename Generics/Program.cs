using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Generics
{
    class Example
    {
        public static Dictionary<string, int> CountWords(string text)
        {
            Dictionary<string, int> frequencies = new Dictionary<string, int>();

            string[] words = Regex.Split(text, @"\W+");

            foreach (string word in words)
            {
                if (frequencies.ContainsKey(word))
                {
                    frequencies[word]++;
                }
                else
                {
                    frequencies[word] = 1;
                }
            }

            return frequencies;
        }

        public static int CompareToDefault<T>(T value)
            where T : IComparable<T>
        {
            return value.CompareTo(default(T));
        }


        public static bool TypeUnconstrainedComparision<T>(T value1, T value2)
        {
            // Here value1 == value2 is invalid operation. 
            // When the type is unconstrained, then these cannot be used to 
            // compare each other, but only to null.
            // In order to use comparision, use value1.EqualTo(value2)
            return value1 == null;
        }

        public static int TypeConstrainedValueTypeComparision<T>(T value)
            where T : struct
        {
            // == and != cannot be used at all
            // return value == default(T), and
            // return value != default(T) 
            // will throw compilee time errors
            return 0;
        }

        public static bool TypeConstrainedReferenceTypeComparision<T>(T value1, T value2)
            where T : class
        {
            // This compiles fine, and at runtime calls the overloaded methods if available
            return value1 == value2;
        }

        public static void PrintDefaultValue<T>()
        {
            Console.WriteLine("Type: {0}, Default: {1}", typeof(T), default(T));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string text = @"Do you like green eggs and ham?
                            I do not like them, Sam-I-am.
                            I do not like green eggs and ham.";

            Dictionary<string, int> frequencies = Example.CountWords(text);



            Example.PrintDefaultValue<int>();
            Example.PrintDefaultValue<decimal>();
            Example.PrintDefaultValue<Example>();
            Example.PrintDefaultValue<Foo>();
            Example.PrintDefaultValue<DateTime>();

            Console.ReadLine();
        }

        struct Foo { };
    }
}
