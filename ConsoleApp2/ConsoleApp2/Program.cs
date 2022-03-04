using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Axdaracaginiz herfi daxil edin");
            string herf =Console.ReadLine();
            Console.WriteLine("Herfi axdaracagimiz soz veya cumleni daxil edin");
            string soz = Console.ReadLine();
            int total=0;
            for (int i=0; i < soz.Length; i++)
            {
                if (herf.Contains(soz[i]))
                {
                    total++;
                }
            }
            Console.WriteLine(total);
        }
    }
}
