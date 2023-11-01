using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };

            int sum = 0;

            foreach(int number in numbers)
            {
                sum += number;
            }

            Console.WriteLine("The sum of all elements:"+sum);
        }
    }
}
