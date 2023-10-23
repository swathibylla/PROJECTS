using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace student
{
    class Student
    {
        public string Name { get; set; }
        public int Rollno { get; set; }
        public string Address { get; set; }
        public string course { get; set; }

        public override string ToString()
        {
            return $"Name: {Name},Rollno:{Rollno},Address:{Address},course:{course}";
        }
    }
    class program
    {

        static void Main(string[] args)
        {
            bool fileNotFound = false;
            string dataFilePath = @"C:\\Users\\swath\\source\\repos\\studentDetails\\Student Details.txt\";
            string[] lines = null;
            try
            {
                lines = File.ReadAllLines(@"C:\Users\swath\source\repos\studentDetails\Student Details.txt");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("student data file not found.");
                fileNotFound = true;
            }
            catch (Exception e)
            {
                Console.WriteLine($"An error occured: {e.Message}");
            }
            finally
            {
                if (!fileNotFound)
                {
                    if (lines != null)
                    {
                        foreach (string line in lines)
                        {
                            string[] parts = line.Split(',');
                            if (parts.Length >= 4)
                            {
                                string name = parts[0].Trim();
                                if (int.TryParse(parts[1].Trim(), out int Rollno))
                                {
                                    string Address = parts[2].Trim();
                                    string Course = parts[3].Trim();

                                    Student student = new Student
                                    {
                                        Name = name,
                                        Rollno = Rollno,
                                        Address = Address,
                                        course = Course
                                    };
                                    DisplayStudentInfo(student);

                                }
                            }
                        }
                    }

                }
                Console.WriteLine("Student Details:");
                Console.WriteLine("Name:Dinesh");
                Console.WriteLine("RollNo: 101");
                Console.WriteLine("Address: Hyderbad");
                Console.WriteLine("Student courses:  Html,Java"); ;
                Console.ReadKey();
            }
        }
        static void DisplayStudentInfo(Student student)
        {
            string studentInfo = student.ToString();
            Console.WriteLine("Student details:");
            Console.WriteLine(studentInfo);
        }
    }
}


   


        
        
        

    


