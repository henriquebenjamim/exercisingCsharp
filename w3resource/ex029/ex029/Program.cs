using System;
using System.IO;

namespace ex029
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C:\exercising\w3resource\ex029\textFile.txt
            string fileName = "C:/exercising/w3resource/ex029/textFile.txt";
            FileInfo fi = new FileInfo(fileName);
            string justFileName = fi.Name;
            long size = fi.Length;
            Console.WriteLine($"File Name: {justFileName}");
            Console.WriteLine($"File size in Bytes: {size}");
        }
    }
}
