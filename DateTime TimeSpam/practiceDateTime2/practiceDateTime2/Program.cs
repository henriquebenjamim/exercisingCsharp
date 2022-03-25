using System;

namespace practiceDateTime2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DateTime d = new DateTime(2010, 4, 15, 14, 22, 30, 205);
            ////15/04/2010 14:22:30:205

            //Console.WriteLine(d);
            //Console.WriteLine("1) Date: " + d.Date);
            //Console.WriteLine("2) Day:  " + d.Day);
            //Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            //Console.WriteLine($"4) DayOfYear: {d.DayOfYear}");
            //Console.WriteLine($"5) Hour: {d.Hour}");
            //Console.WriteLine($"6) Kind: {d.Kind}");
            //Console.WriteLine($"7) Millisecond: {d.Millisecond}");
            //Console.WriteLine("8) Minute: " + d.Minute);
            //Console.WriteLine("9) Month: " + d.Month);
            //Console.WriteLine("10) Second: " + d.Second);
            //Console.WriteLine("11) Ticks: " + d.Ticks);
            //Console.WriteLine($"12) TimeOfDay: {d.TimeOfDay}");
            //Console.WriteLine("13) Year: " + d.Year);

            DateTime d1 = new DateTime(2022, 9, 10, 18, 12, 59, 999);


            // saida esperada: sábado, 10 de setembro de 2022
            // ToLongDateString()
            string s1 = d1.ToLongDateString();
            string s2 = d1.ToShortDateString();
            // da para guardar numa string isso.
            Console.WriteLine(d1.ToLongDateString());
            Console.WriteLine(s2);

            string s3 = d1.ToLongTimeString();
            string s4 = d1.ToShortTimeString();
            Console.WriteLine("Short & Long TimeString");
            Console.WriteLine(s3);
            Console.WriteLine(s4);


            string s5 = d1.ToString();
            Console.WriteLine(s5); // padrao
            string s6 = d1.ToString("yyyy-MM-dd HH:mm:ss");
            Console.WriteLine(s6); // override
            string s7 = d1.ToString("yyyy-MM-dd HH:mm:ss:fff");
            Console.WriteLine(s7); // override with milisec


            // Operacoes 
            Console.WriteLine("Iniciando as operações");
            DateTime datas = new DateTime(2001, 8, 15, 13, 45, 58);
            DateTime datas2 = datas.AddHours(2);

            Console.WriteLine(datas);
            Console.WriteLine(datas2);

            // DateTime datas3 = datas.Add
            // é possivel fazer o Add com Dias, horas, milisegundos, meses, segundos, anos, minutos, ticks

            // isso fica legal com prazos como boletos, alugueis, (datas de vencimentos) = Exemplo

            Console.WriteLine("Diferença entre datas:");

            DateTime primeiraData = new DateTime(2000, 10, 15);
            DateTime segundaData = new DateTime(2000, 10, 18);
            DateTime terceiraData = new DateTime(2000, 12, 27);

            // na variavel
            TimeSpan t = terceiraData.Subtract(primeiraData);
            Console.WriteLine(segundaData.Subtract(primeiraData));
            Console.WriteLine(t);
        }
    }
}
