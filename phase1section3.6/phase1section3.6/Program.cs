using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phase1section3._6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doApp();
        }
        public static void doApp()
        {
            int number = 20;
            if (number < 10)
            {
                Console.WriteLine("number is less than 5");
            }
            else if (number > 10)
            {
                Console.WriteLine("Number is greater than 10");
            }
            else
            {
                Console.WriteLine("Number is equal to 10");
            }
            char grade = 'B';
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent");
                    break;
                case 'B':
                case 'c':
                    Console.WriteLine("Good job!");
                    break;
                case 'D':
                case 'F':
                    Console.WriteLine("you need to improve.");
                    break;
                default:
                    Console.WriteLine("invalid grade");
                    break;
            }

            for (int j = 1; j <= 10; j++)
            {
                Console.WriteLine("for loop iteration:" + j);
            }

            int k = 1;
            do
            {
                Console.WriteLine("Do-while loop iteration:" + k);
                k++;

            }
            while (k <= 5);

            string[] colors = { "Red", "Green", "Blue" };
            foreach (string color in colors)
            {
                Console.WriteLine("color: " + color);
            }
        }
    }
}

