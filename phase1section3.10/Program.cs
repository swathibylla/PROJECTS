using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phase1section3._10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doApp();
        }
        static void doApp()
        {
            string str = "Hello, ";
            str += "world!";
            Console.WriteLine("using string: "+ str);

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Hello, ");
            stringBuilder.Append("world!");
            string result = stringBuilder.ToString();
            Console.WriteLine("using StringBuilder:" + result);

        }
    }
}
