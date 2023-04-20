using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rozkład_na_czynniki_pierwsze
{
    internal class Program
    {
        static void Main()
        {
            // liczba pierwsza 
            int li = int.Parse(Console.ReadLine());
            int dzielniki = 0;
            for (int spr = 1; spr <= li; spr++)
            {
                if (li % spr == 0)
                {
                    dzielniki++;
                }
            }
            if (dzielniki == 2)
            {
                Console.WriteLine($"{li} jest liczbą pierwszą");
            }
            else
            {
                Console.WriteLine($"{li} nie jest liczbą pierwszą");
            }

            // rozkład na czynniki pierwsze
            int liczba = int.Parse(Console.ReadLine());
            while (liczba != 1)
            {
                for (int lp = 2; lp <= liczba; lp++)
                {
                    int dz = 0;
                    for (int spr = 1; spr <= liczba; spr++)
                    {
                        if (lp % spr == 0)
                        {
                            dz++;
                        }
                    }
                    if (dz == 2 & liczba % lp == 0)
                    {
                        Console.WriteLine($"{liczba} | {lp}");
                        liczba = liczba / lp;
                    }
                }
            }
            Console.WriteLine(liczba);
                
            Console.ReadKey();
        }
    }
}
