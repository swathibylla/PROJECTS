using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace studentfile
{
    internal class Program
    {
         public static void Main(string[] args)
        {

            CreateAndWriteTXTFile();
            OpenAndReadTXTFile();
            Console.Read();
        }

        private static void OpenAndReadTXTFile()
        {
            bool ans = File.Exists(@"C:\Users\swath\Documents\projects\Student Details.txt");
            if(ans == true)
            {
                try
                {
                    FileStream s = new FileStream(@"C:\Users\swath\Documents\projects\Student Details.txt", FileMode.Open, FileAccess.Read);
                    StreamReader reading = null;
                    try
                    {
                        reading = new StreamReader(s);
                        string readme = reading.ReadToEnd();
                        Console.WriteLine(readme);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    finally
                    {
                        s.Close();
                        s.Dispose();
                        reading.Close();
                        reading.Dispose();
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("e.Message");
                }
            }
            else
            {
                Console.WriteLine("File does not exist on the location");
            }
           
        }
        private static void CreateAndWriteTXTFile()
        {
            FileStream s = new FileStream(@"C:\Users\swath\Documents\projects\Student Details.txt", FileMode.Create, FileAccess.Write);
            StreamWriter writing = new StreamWriter(s);
            try
            {
                writing.WriteLine("Student Details:");
                writing.WriteLine(" Name:Dinesh");
                writing.WriteLine(" RollNo: 101");
                writing.WriteLine("Address: Hyderbad");
                writing.WriteLine("Student courses:  Html,Java");

            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                writing.Flush();
                writing.Close();
                writing.Dispose();
                s.Close();
                s.Dispose();
            }
        }
    }
}
