using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1,4,6,9,12,15,18,20,21};
            int total=0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                if (arr[i]%3 == 0)
                {  
                    total =total+arr[i];
                    
                }
            }
            Console.WriteLine("Bu arrayin icindeki 3 e bolunen reqemlerin cemi "+ total+" beraberdir");
        }
    }
}
