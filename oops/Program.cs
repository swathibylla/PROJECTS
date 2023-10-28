using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            List<Teacher> teachers = new List<Teacher>();
            List<Subject> subjects = new List<Subject>();

            students.Add(new Student { Name = "Dinesh", ClassAndSection = "Class A" });
            students.Add(new Student { Name = "Shruthi", ClassAndSection = "Class A" });
            students.Add(new Student { Name = "kavya", ClassAndSection = "Class B" });

            teachers.Add(new Teacher { Name = "prasad", ClassAndSection = "Class A" });
            teachers.Add(new Teacher { Name = "vani", ClassAndSection = "Class A" });
            teachers.Add(new Teacher { Name = "Bhanu", ClassAndSection = "Class B" });

            subjects.Add(new Subject { Name = "science", SubjectNo = "SCI1", Teacher = teachers[0] });
            subjects.Add(new Subject { Name = "Maths", SubjectNo = "MATH4", Teacher = teachers[1]  });
            subjects.Add(new Subject { Name = "English", SubjectNo = "ENG3", Teacher = teachers[2] });



            DisplayStudentsInClass(students, "Class A");
            DisplayStudentsInClass(students, "Class B");

            DisplaySubjectsByTeacher(subjects, teachers[0]);
            DisplaySubjectsByTeacher(subjects, teachers[1]);
            DisplaySubjectsByTeacher(subjects, teachers[2]);
        }

        static void DisplayStudentsInClass(List<Student> students, string classToDisplay)
        {
            Console.WriteLine($"students in {classToDisplay}:");
            foreach(var student in students)
            {
                if(student.ClassAndSection == classToDisplay)
                {
                    Console.WriteLine(student.Name);
                }
            }
        }
        static void DisplaySubjectsByTeacher(List<Subject> subjects, Teacher teacherToDisplay)
        {
            Console.WriteLine($"Subjects taught by {teacherToDisplay.Name}:");
            foreach(var subject in subjects)
            {
                if(subject.Teacher == teacherToDisplay)
                {
                    Console.WriteLine($"{subject.Name} ({subject.SubjectNo})");
                }
            }
        }
    }
}
