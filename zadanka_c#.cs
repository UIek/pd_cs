using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main()
        {
            //Write a program that answers each question "perhaps"
            for (int k = 0; k < 10; k++)
            {
                string pytanie = Console.ReadLine();
                Console.WriteLine("perhaps");
            }

            //Let's write a program that will display all numbers that are divisible by 9. Up to the value given by the user.
            int lic = int.Parse(Console.ReadLine());
            while (lic > 0)
            {
                if (lic % 9 == 0)
                {
                    Console.WriteLine(lic);
                }
                lic--;
            }

            //Write a program to write all numbers that are NOT divisible by 3.To the value given by the user.
            int li = int.Parse(Console.ReadLine());
            while (li > 0)
            {
                if (li % 3 != 0)
                {
                    Console.WriteLine(li);
                }
                li--;
            }

            int l = int.Parse(Console.ReadLine());
            for (int i = 0; i < l; i++)
            {
                if (i % 3 != 0)
                {
                    Console.WriteLine(i);
                }
            }

            //Write a program that prints n powers of 2.
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Math.Pow(2, n));
            Console.WriteLine(Math.Pow(n, 2));

            //Sum up all the numbers that are divisible by the 5 Up to the value specified by the user.
            int x = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 0; i < x; i++)
            {
                if (i % 5 == 0)
                {
                    sum += i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(sum);

            //View n times I LOVE PROGRAMMING !!!
            int nnn = int.Parse(Console.ReadLine());
            for (int i = 0; i < nnn; i++)
            {
                Console.WriteLine("I LOVE PROGRAMING!!!!!");
            }

            //Check if asked  x number is prime ?
            int xx = int.Parse(Console.ReadLine());
            for (int i = 0; i <= xx; i++)
            {
                int nn = int.Parse(Console.ReadLine());
                int dzielniki = 0;
                for (int j = 1; j <= nn; j++)
                {
                    if (nn % j == 0)
                    {
                        dzielniki++;
                    }
                }
                if (dzielniki == 2)
                {
                    Console.WriteLine($"{nn} jest liczbą pierwszą");
                }
                else
                {
                    Console.WriteLine($"{nn} nie jest liczbą pierwszą");
                }
            }

            //Spell your name.
            string imie = Console.ReadLine();
            for (int i = 0; i < imie.Length; i++)
            {
                Console.WriteLine(imie[i]);
            }

            //Display 100 random numbers.
            for (int i = 0; i < 100; i++)
            {
                
                Console.WriteLine(new Random().Next());
            }

            Console.ReadKey();
        }
    }
}
