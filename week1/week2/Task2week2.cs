using System;

namespace MenteAcademy.week2
{
    internal class Task2week2
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6 };

        static void Main(string[] args)
        {
            Task2week2 task = new Task2week2();
            Console.Write("Max value: ");
            task.findMax();
            Console.Write("Min value: ");
            task.findMin();
            Console.Write("Average value: ");
            task.findAvg();
        }

        public void findMax()
        {
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine(max);
        }

        public void findMin()
        {
            int min = numbers[0];
            foreach (int number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
            }
            Console.WriteLine(min);
        }

        public void findAvg()
        {
            int min = numbers[0];
            int max = numbers[0];

            foreach (int number in numbers)
            {
                if (number < min)
                {
                    min = number;
                }
                if (number > max)
                {
                    max = number;
                }
            }
            double avg = (min + max) / 2.0;
            Console.WriteLine(avg);
        }
    }
}
