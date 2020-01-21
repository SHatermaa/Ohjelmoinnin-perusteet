using System;

namespace testi_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Onko luku pariton,parillinen tai nolla");
            Console.WriteLine("Syötä luku");
            n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine($"Numero {n}on parillinen");
            }
            else
            {
                Console.WriteLine($"Numero {n} on pariton");
            }
        }
    }
}
