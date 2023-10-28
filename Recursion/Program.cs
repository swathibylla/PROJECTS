using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phase1section4._27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {
            string[] students = new string[8];
            students[0] = "Kavya";
            students[1] = "Mani";
            students[2] = "Akash";
            students[3] = "Sandeep";
            students[4] = "Naveen";
            students[5] = "Harsha";
          

            int currElem = 0;
            printViaRecursion(students, currElem);
        }

        public static void printViaRecursion(string[] arr, int currElem)
        {
            Console.WriteLine(arr[currElem]);
            if (currElem < arr.Length - 1)
                printViaRecursion(arr, currElem + 1);
        }
    }
}
   
