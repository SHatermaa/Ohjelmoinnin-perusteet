using System;

namespace If_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double discount = 0;
            string varusmies;
            string opiskelija;
            string MTK;
            int ikä = 0;
            int lippu = 16;



            Console.WriteLine("lippulaskuri");
            Console.Write("Oletko varusmies?  kyllä/ei ");
            varusmies = Console.ReadLine().ToUpper().Trim();

            if (varusmies[0] == 'K')
            {
                discount = 0.5;
                Console.WriteLine($"lipun hinta on {lippu - (discount * lippu)} €");
            }

            else
            {
                Console.Write("oletko opiskelija? kyllä/ei ");
                opiskelija = Console.ReadLine().ToUpper().Trim();
                Console.Write("oletko MTK jäsen? kyllä/ei ");
                MTK = Console.ReadLine().ToUpper().Trim();

                if (opiskelija[0] == 'K' && MTK[0] == 'K')
                {
                    discount = 0.6;
                    Console.WriteLine($"lipun hinta on {lippu - (discount * lippu)} €");
                }

                else if (opiskelija[0] == 'K' && MTK[0] == 'E')
                {
                    discount = 0.45;
                    Console.WriteLine($"lipun hinta on {lippu - (discount * lippu)} €");
                }
                if (opiskelija[0] == 'E')
                {
                    Console.Write("syötä ikä");
                    ikä=int.Parse(Console.ReadLine());

                    if (ikä <= 7)
                    {
                        discount = 1;
                        Console.WriteLine("lippu on ilmainen");
                    }

                    else if (ikä > 65 || ikä <= 15)
                    {
                        discount = 0.5;
                        Console.WriteLine($"lipun hinta on {lippu - (discount * lippu)} €");
                    }

                    else if (MTK[0] == 'K')
                    {
                        discount = 0.15;
                       Console.WriteLine($"lipun hinta on {lippu - (discount * lippu)} €");
                    }

                    else
                    {
                        Console.WriteLine("lipun hinta on 16€");
                    }
                }
            }
        }
    }
}
