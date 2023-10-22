using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phase1section3._8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doApp();
        }
        static void doApp()
        {
            DateTime currentDate = DateTime.Now;
            Console.WriteLine("current Date and Time:" + currentDate);

            int year = currentDate.Year;
            int month = currentDate.Month;
            int day = currentDate.Day;
            int hour = currentDate.Hour;
            int minute = currentDate.Minute;
            int second = currentDate.Second;

            Console.WriteLine("year:" + year);
            Console.WriteLine("Month:" + month);
            Console.WriteLine("Day:"+ day);
            Console.WriteLine("Hour:"+ hour);
            Console.WriteLine("Minute:"+minute);
            Console.WriteLine("second:"+ second);

            string formattedDate = currentDate.ToString("dd-MM-yyyy  HH:MM:SS");
            Console.WriteLine("Formatted Date: "+ formattedDate);
        }
    }
}
