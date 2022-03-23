using System;
using System.Globalization;

namespace practiceDateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime d1 = new DateTime(2022, 03, 23);
            Console.WriteLine(d1);

            DateTime d2 = new DateTime(2019, 10, 03, 20, 45, 10);
            Console.WriteLine(d2);

            DateTime d3 = new DateTime(2018, 11, 25, 20, 45, 03, 500);
            Console.WriteLine(d3);

            DateTime d4 = DateTime.Now;
            DateTime d5 = DateTime.Today;
            DateTime d6 = DateTime.UtcNow;

            Console.WriteLine(d4);
            Console.WriteLine(d5);
            Console.WriteLine(d6);

            Console.WriteLine(d6-d4);

            Console.WriteLine("Parse");

            DateTime date1 = DateTime.Parse("2000-08-15");
            DateTime date2 = DateTime.Parse("2000-08-17");
            

            Console.WriteLine(date1);
            Console.WriteLine(date2);
            Console.WriteLine(date2 - date1);

            DateTime date3 = DateTime.Parse("2022-10-03 13:05:48");
            Console.WriteLine(date3);

            DateTime date001 = DateTime.Parse("15/08/2022");
            Console.WriteLine(date001);
            DateTime date002 = DateTime.Parse("15/08/2022 13:05:48");
            Console.WriteLine(date002);


            DateTime data1 = DateTime.ParseExact("2000-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Console.WriteLine(data1);
            DateTime data2 = DateTime.ParseExact("15/08/2015 13:05:14", "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine(data2);

            
        }
    }
}
