using System;
using System.Linq;

namespace ex069
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //69.Write a C# Sharp program to check if a given string contains only lowercase or uppercase characters.

            string nameUpper = "HENRIQUE";
            string nameLower = "jujubas";
            Console.WriteLine(nameUpper.All(x => char.IsUpper(x)));
            Console.WriteLine(nameLower.All(x => char.IsUpper(x)));

            Console.WriteLine(nameUpper.All(x => char.IsLower(x)));
            Console.WriteLine(nameLower.All(x => char.IsLower(x)));
            Console.WriteLine(checkUpperOrLower("Almondegas"));
            Console.WriteLine(checkUpperOrLower("almofadas"));
        }

        public static string checkUpperOrLower(string str)
        {
            bool strUpper = str.All(x => char.IsUpper(x));
            bool strLower = str.All(x => char.IsLower(x));
            string answer = "";

            if(strUpper)
            {
                answer = "Upper";
            }
            else if(strLower)
            {
                answer = "Lower";
            }
            else
            {
                answer = "None";
            }
            return answer;

        }
    }
}
