using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phase1section4._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }
        public static void runApp()
        {
            string[] student1 = new string[10] { "swathi","Dinesh", "Raghu", "shanti", "Ramya", "Namrutha", "Divya", "kavya", "geetha", "sathish" };
            string[] subjects = new string[6] { "English", "Maths", "Science", "physics", "Chemistry", "Biology" };

            int[] marks = new int[6] { 80, 77, 87, 90, 66, 53 };

            

            Console.WriteLine("students of class 1:");
            foreach (string s in student1)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("");

            

            Console.WriteLine("Marks of Rakesh:");
            int total = 0;
            for (int i = 0; i<6; i++)
            {
                total += marks[i];
                Console.WriteLine(subjects[i]+ "=" +marks[i]);

            }
            Console.WriteLine("TotalMarks = " + total + "/600 = "+(total*100/600)+"percent");
            




        }
    }
}
