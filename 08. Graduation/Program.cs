using System;

namespace _08._Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double sumGrades = 0;
            int counterGrade = 1;
            double currentGrade = double.Parse(Console.ReadLine());
            int badGrades = 0;
            double avg = 0;
            while (counterGrade <= 12)
            {
               
                if (currentGrade < 4)
                {
                    if (badGrades == 2)
                    {
                        Console.WriteLine();
                    }
                    currentGrade = double.Parse(Console.ReadLine());
                }
                else
                {
                    counterGrade++;
                    sumGrades += currentGrade;
                    currentGrade = double.Parse(Console.ReadLine());
                }
                

            }
            avg = sumGrades / 12;
            if (badGrades != 2)
            {
                Console.WriteLine("");
            }
            Console.WriteLine("");
        }
    }
}
