using System;
using System.IO;
using System.Linq;

namespace ex064
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //64.Write a C# Sharp program to get the file name (including extension) from a given path

            string path = @"C:\exercising\w3resource\ex064\henrique.txt";
            File.Create(path);
            Console.WriteLine("Ok");

            Console.WriteLine(path.Split('/').Last());

        }
    }
}
