using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace studentdata
{
    class Student
    {
        public int Rollno { get; set; }
        public string Name { get; set; }
        public string Courses { get; set; }
        public string Address { get; set; }
    }
    internal class program
    {
        static void Main(string[] args)
        {
            List<Student> students = ReadStudentDataFromFile(@"C:\Users\swath\source\repos\Student Details.txt");
            if (students.Count > 0)
            {
                Console.WriteLine("Student Data sorted by Name:");
                students = students.OrderBy(s => s.Name).ToList();
                foreach (var student in students)
                {
                    Console.WriteLine($"{student.Rollno}:{student.Name},Courses:{student.Courses},Address:{student.Address}");
                }
                Console.WriteLine("Enter a student name to search:");
                string searchName = Console.ReadLine();
                Student foundStudent = students.FirstOrDefault(s => s.Name.Equals(searchName, StringComparison.OrdinalIgnoreCase));
                if(foundStudent != null)
                {
                    Console.WriteLine($"Student Found:{foundStudent.Rollno}:{foundStudent.Name},Courses:{foundStudent.Courses},Address:{foundStudent.Address}");

                }
                else
                {
                    Console.WriteLine("student not found.");
                }
            }
        }

        private static List<Student> ReadStudentDataFromFile(string filePath )
        {
            List<Student> students = new List<Student>();
            try
            {
                
                
                if(File.Exists(@"C:\Users\swath\source\repos\Student Details.txt"))
                {
                    using (StreamReader reader = new StreamReader(@"C:\Users\swath\source\repos\Student Details.txt"))
                    {
                        string line;
                        while((line = reader.ReadLine()) != null)
                        {
                            Console.WriteLine(line);
                            if(line.StartsWith("Student Rollno"))
                            {
                                Student student = new Student();
                                student.Rollno = int.Parse(line.Split(':')[1].Trim());
                                Console.WriteLine($"Student Rollno: {student.Rollno}");


                                student.Name = reader.ReadLine().Split(':')[1].Trim();
                                Console.WriteLine($"Student Name: {student.Name}");


                                student.Courses = reader.ReadLine().Split(':')[1].Trim();
                                Console.WriteLine($"Student Courses:{student.Courses}");


                                student.Address = reader.ReadLine().Split(':')[1].Trim();
                                Console.WriteLine($"Student Address :{student.Address}");

                                students.Add(student);

                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("file not found at:" + filePath);
                }
                Console.WriteLine("---------------------------------");

                Console.WriteLine("Enter student Details");
                Console.WriteLine("Enter student RollNo:101");
                 Console.WriteLine("Name:Dinesh");
                Console.WriteLine("Courses:Html, java");
                Console.WriteLine("Address:Hyderbad");


            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return students;
        }
    }
}
