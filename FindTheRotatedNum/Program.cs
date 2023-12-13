using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Number_06
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int max = int.MinValue;

            while (input != "Stop")
            {
                int inputAsNumber = int.Parse(input);

                if (inputAsNumber > max)
                {
                    max = inputAsNumber;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine(max);
        }
    }
}
