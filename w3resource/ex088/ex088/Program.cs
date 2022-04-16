using System;

namespace ex088
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //88.Write a C# Sharp program to find the sum of the interior angles (in degrees) of a given Polygon. Input number of straight line(s).
            //From Wikipedia,
            //In geometry, a polygon is a plane figure that is described by a finite number of straight line segments connected to form a closed polygonal chain or polygonal circuit.
            //The solid plane region, the bounding circuit, or the two together, may be called a Polygon.
            //Sample Output:
            //Input number of straight lines of the polygon: 0
            //Sum of the interior angles(in degrees) of the said polygon: -360

            Console.WriteLine("Input a number of straight lines of the polygon: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Sum of the interior angles(n degrees): {calculating(number)}");
        }

        public static int calculating(int number)
        {
            return 180 * (number - 2);
        }
    }
}
