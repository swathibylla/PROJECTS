using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace multithread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CurrentThreadExample();
            Thread t1 = Thread.CurrentThread;
            t1.Name = "This method is main method is running";
            Console.WriteLine(t1.Name);
            Console.WriteLine($"Managed Main Thread id = {t1.ManagedThreadId}");//1
            Console.Read();

            //it can any method which takes object(any data type) and returns void
            ThreadStart del = new ThreadStart(Program.Print);
            //Thread t = new Thread(new ThreadStart(Program.Print));
            Thread t = new Thread(del);
            Thread tobj = new Thread(Program.Greet);


            //Thread t2 = new Thread(new ThreadStart(Program.Greet));

            t.Start();
            Console.WriteLine("----------");
            Console.WriteLine($"Managed  Print Thread id={t.ManagedThreadID}");//3

            t2.Start();
            Console.ReadLine();
        }
    }
}
