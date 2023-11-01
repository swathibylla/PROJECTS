using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace mutexdemo
{
    
    
     

            class MutexDemo1
        {
            private static Mutex mutex = new Mutex();
            private const int numhits = 1;
            private const int numThreads = 4;
            private static void ThreadProcess()
            {
                for (int i = 0; i < numhits; i++)
                {
                    UseMethod1();
                }
            }
            private static void UseMethod1()
            {
                mutex.WaitOne();   // Wait until it is safe to enter.  
                Console.WriteLine("{0} has entered ",
                    Thread.CurrentThread.Name);
            // Place code to access non-reent
            Thread.Sleep(500);    // Wait until it is safe to enter.  
            Console.WriteLine("{0} is leaving ",
                Thread.CurrentThread.Name);
            mutex.ReleaseMutex();    // Release the Mutex.  
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < numThreads; i++)
            {
                Thread t = new Thread(new ThreadStart(ThreadProcess));
                t.Name = String.Format("Thread{0}", i + 1);
                t.Start();
            }
            Console.Read();
        }
        }
}
