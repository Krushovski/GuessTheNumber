using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _RandomNumGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if (a > b)
            {
                int temp = a;
                a = b;
                b = temp;
            }
            int rand_num = rd.Next(a, b);
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"Random number is between {a} and {b}. GUESS IT!!! :D : ");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Player 1");
            int guess = int.Parse(Console.ReadLine());
            int triesLeft = 0;

            for (int i = 1; i <= 30; ++i)
            {
                triesLeft = 30 - i;
                if (guess < rand_num)
                {
                    Console.WriteLine($"Try higher! You still have {30 - i} tries!");
                    guess = int.Parse(Console.ReadLine());
                }
                else if (guess > rand_num)
                {
                    Console.WriteLine($"Try lower!You still have {30 - i} tries!");
                    guess = int.Parse(Console.ReadLine());
                }
                else if (guess == rand_num)
                {
                    Console.WriteLine($"Good Job! You guessed it! The number is {rand_num}!!!");
                    i = 31;

                }
            }
            Console.WriteLine($"Player 1 has {triesLeft} tries left!"); Console.WriteLine(); Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Player 2");
            int min = a;
            int max = b;
            int guess2 = (max + min) / 2;
            //  int guess2 = rd.Next(min, max);
            int triesLeft2 = 0;
            Console.WriteLine(guess2);
            for (int i = 1; i <= 30; i++)
            {
                triesLeft2 = 30 - i;
                if (guess2 < rand_num)
                {
                    Console.WriteLine($"Try higher! You still have {30 - i} tries!");
                    min = guess2;
                    guess2 = (max + min) / 2;
                    Console.WriteLine(guess2);
                }
                else if (guess2 > rand_num)
                {
                    Console.WriteLine($"Try lower!You still have {30 - i} tries!");
                    max = guess2;
                    guess2 = (max + min) / 2;
                    Console.WriteLine(guess2);
                }
                else if (guess2 == rand_num)
                {
                    Console.WriteLine($"Good Job! You guessed it! The number is {rand_num}!!!");
                    i = 31;

                }
            }
            Console.WriteLine($"Player 2 has {triesLeft2} tries left!");


            Console.ForegroundColor = ConsoleColor.Yellow;
            if (triesLeft > triesLeft2)
            {
                Console.WriteLine("Player 1 wins!");
            }
            else if (triesLeft == triesLeft2)
            {
                Console.WriteLine("It's a draw!");
            }
            else
            {
                Console.WriteLine("Player 2 wins!");
            }
            Console.ReadLine();
        }

    }
}