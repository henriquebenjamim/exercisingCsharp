using System;

namespace ex080
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //80.Write a C# Sharp program to convert all the values of a given array of mixed values to string values.
            //Sample Output:
            //Printing original array elements and their types:
            //Value-> 25 :: Type->System.Int32
            //Value->Anna :: Type->System.String
            //Value->False :: Type->System.Boolean
            //Value-> 4 / 15 / 2021 10:37:47 AM::Type->System.DateTime
            //Value-> 112.22 :: Type->System.Double

            //Printing array elements and their types:
            //Value-> 25 :: Type->System.String
            //Value->Anna :: Type->System.String
            //Value->False :: Type->System.String
            //Value-> 4 / 15 / 2021 10:37:47 AM::Type->System.String
            //Value-> 112.22 :: Type->System.String

            object[] requiredArray = new object[5];
            requiredArray[0] = 2016;
            requiredArray[1] = System.DateTime.Now;
            requiredArray[2] = "CodewithKasam";
            requiredArray[3] = true;
            requiredArray[4] = 4.6;
            foreach(object value in requiredArray)
            {
                Console.WriteLine($"Value-> {value} :: Type-> {value.GetType()}");
            }
            Console.WriteLine();
            Console.WriteLine("Printing array elements and their types: ");
            foreach (object value2 in requiredArray)
            {
                Console.WriteLine($"Value-> {value2} :: Type-> {value2.ToString().GetType()}");
            }

        }
    }
}
