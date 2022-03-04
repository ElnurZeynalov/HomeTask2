using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            Console.WriteLine("Yoxlamaq isdediyiniz reqemi daxil edin: ");
            x = Convert.ToInt32(Console.ReadLine());
            if (x%2 == 0)
            {
                while (x>1)
                {
                    x=x/2;
                    
                }
                if (x == 1)
                { 
                Console.WriteLine("Ikinin quvvetidir");
                }
                else 
                { 
                    Console.WriteLine("Ikinin quveti deyil");
                }
            }
            else if (x == 1)
            {
                Console.WriteLine("Ikinin quvetidir");
            }
            else
            {
                Console.WriteLine("Ikinin quvveti deyil");
            }
        }
    }
}
