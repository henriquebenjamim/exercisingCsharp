using System;
using System.Collections.Generic;

namespace praticeTimeSpam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TimeSpan t = new TimeSpan(2, 3, 5, 7, 11);
            TimeSpan t2 = new TimeSpan(3, 2, 3, 1, 10);

            Console.WriteLine(t);
            Console.WriteLine(t2);

            Console.WriteLine("Days: " + t.Days);
            Console.WriteLine("Hours: " + t.Hours);
            Console.WriteLine("Minutes: " + t.Minutes);
            Console.WriteLine($"Milliseconds: {t.Milliseconds}");
            Console.WriteLine($"Seconds: {t.Seconds}");
            Console.WriteLine($"Ticks: {t.Ticks}");


            Console.WriteLine("TotalDays: " + t.TotalDays);
            Console.WriteLine("TotalHours: " + t.TotalHours);
            Console.WriteLine("TotalMinutes: " + t.TotalMinutes);
            Console.WriteLine("TotalSeconds: " + t.TotalSeconds);
            Console.WriteLine($"TotalMilliseconds: {t.TotalMilliseconds}");

            TimeSpan spread = t2 - t;
            Console.WriteLine($"Spread: {spread}");
            Console.WriteLine(spread.Days);
            Console.WriteLine(spread.TotalDays);
            
            string hora = "13:05:48";
            DateTime date3 = DateTime.Parse(hora);
            
            Console.WriteLine(date3.ToString("hh:mm:ss"));

            List<int> list = new List<int>(2);
            list.Add(2);
            list.Add(4);
            Console.WriteLine(String.Join(" ", list));

        }
    }
}
