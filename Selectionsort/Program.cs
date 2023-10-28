using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phase1section4._23
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
            students[3] = "Mangula";
            students[4] = "Harsha";
            students[5] = "Sandeep";
            

            int n = 8;
            string temp;
            int smallest;

            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (students[j].CompareTo(students[smallest]) < 0)
                    {
                        smallest = j;
                    }
                }
                temp = students[smallest];
                students[smallest] = students[i];
                students[i] = temp;
            }

            foreach (string s in students)
            {
                Console.WriteLine(s);
            }
        }
    }
}



      