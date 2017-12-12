using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // Compiler errors!
            // Value types cannot be set to null!
            // bool myBool = null;
            // int myInt = null;

            // OK! Strings are reference types.
            string myString = null;

            Console.WriteLine("***** Fun with Nullable Data *****\n");
            DatabaseReader dr = new DatabaseReader();

            int? i = dr.GetIntFromDatabase();

            if (i.HasValue)
            {
                Console.WriteLine($"Value of 'i' is {i.Value}");
            }
            else
            {
                Console.WriteLine("Value of 'i' is undefined.");
            }

            // Get bool from "database".
            bool? b = dr.GetBoolFromDatabase();

            if(b != null)
            {
                Console.WriteLine($"Value of 'b' is: {b.Value}");
            }
            else
            {
                Console.WriteLine("Value of 'b' is undefined.");
            }

            Console.ReadLine();

        }

        static void LocalNullableVariables()
        {
            // Define some local nullable variables.
            int? nullableInt = 10;
            double? nullableDouble = 3.14;
            bool? nullableBool = null;
            char? nullableChar = 'a';
            int?[] arrayOfNullableInts = new int?[100];

            // Error! Strings are reference types!
            //string? s = "oops";
        }

        static void LocalNullableVariablesUsingNullable()
        {
            // Define some local nullable types using Nullable<T>.
            Nullable<int> nullableInt = 10;
            Nullable<double> nullableDouble = 3.14;
            Nullable<bool> nullableBool = null;
            Nullable<char> nullableChar = 'a';
            Nullable<int>[] arrayOfNullableInts = new Nullable<int>[10];
        }
    }
}
