using System;

namespace ex016
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = Console.ReadLine();
            //Console.WriteLine(s[0]);
            //Console.WriteLine(s[s.Length -1]);
            //s += 'a';
            //Console.WriteLine(s);

            //string nome = Console.ReadLine();
            //Console.Write($"{nome.Substring(nome.Length - 1)}{nome.Substring(1, nome.Length - 2)}{nome.Substring(0, 1)}");
            
            string s = Console.ReadLine();
            Console.WriteLine(s);  
            Console.WriteLine(switchingPosition(s));
        }

        public static string switchingPosition(string s)
        {
            return s.Length > 1 ? s.Substring(s.Length - 1) + s.Substring(1, s.Length - 2) + s.Substring(0, 1) : s;
        }
    }
}
