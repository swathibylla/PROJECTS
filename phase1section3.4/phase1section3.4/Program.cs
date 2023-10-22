using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phase1section3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            doApp();
        }
        public static void doApp()
        {
            int integervar = 42;
            double doublevar = 3.14;
            char charactervar = 'A';
            bool booleanvar = true;


            int sum = integervar + 10;
            double product = doublevar * 2;
            char nextcharacter = (char)(charactervar + 1);
            bool isGreaterThanZero = integervar > 0;

            Console.WriteLine("Integer Variable: "+ integervar);
            Console.WriteLine("double Variable: " + doublevar);

            Console.WriteLine("char Variable: " + charactervar);

            Console.WriteLine("bool Variable: " + booleanvar);




        }
    }
}
