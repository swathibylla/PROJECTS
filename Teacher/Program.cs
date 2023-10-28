using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Teacher
{


    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Users\swath\Documents\projects\Teacher details.txt";
            if (File.Exists(filePath))
            {
                string Teacherdetails = File.ReadAllText(@"C:\Users\swath\Documents\projects\Teacher details.txt");

                Console.WriteLine("Teacherdetails:");
                Console.WriteLine(Teacherdetails);
            }
            else
            {
                Console.WriteLine("The specified file does not exist.");
            }

            while (true)
            {
                Console.WriteLine("1.Add Teacher details");
                Console.WriteLine("2.Update Teacher details ");
                Console.WriteLine("3.Exit");
                Console.WriteLine("Enter the choice:");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddTeacherdetails(@"C:\Users\swath\Documents\projects\Teacher details.txt");
                        break;
                    case 2:
                        UpdateTeacherdetails(@"C:\Users\swath\Documents\projects\Teacher details.txt");
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

            }
        }
        public static void AddTeacherdetails(string filePath)
        {
            Console.Write("Enter Teacher Id:");
            int id = int.Parse(Console.ReadLine());
            Console.Write("Enter Teacher Name:");
            string name = Console.ReadLine();
            Console.Write("Enter Teacher ClassAndSection:");
            string ClassAndSection = Console.ReadLine();

            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine($"{id},{name},{ClassAndSection}");
            }
            Console.WriteLine("Teachers record added successfully.");
        }
        static void UpdateTeacherdetails(string filePath)
        {
            Console.Write("Enter Teacher Id to update:");
            int idToUpdate = int.Parse(Console.ReadLine());
            Console.WriteLine("Id to update:" + idToUpdate);
            string[] lines = File.ReadAllLines(filePath);
            bool found = false;



            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split('.');
                if (parts.Length >= 3 && int.TryParse(parts[0], out int currentId) && currentId == idToUpdate)
                {
                    Console.WriteLine("Enter new Teacher Name:");
                    string newName = Console.ReadLine();
                    Console.Write("Enter new Teacher ClassAndSection:");
                    string newClassAndSection = Console.ReadLine();

                    lines[i] = $"{idToUpdate},{newName},{newClassAndSection}";
                    File.WriteAllLines(filePath, lines);
                    Console.WriteLine("Teacher record updated successfully.");
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Teacher details not found.");
            }
            else
            {
                Console.WriteLine("Invalid Teacher Id");
            }
        }
    }
}





