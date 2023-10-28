using Phase1Section5._12;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phase1section5._12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        public static void runApp()
        {

            Teacher teacher = new Teacher();
            teacher.Name = "Mr.Dinesh";
            teacher.Address = "Hyderbad";
            teacher.DateOfJoining = DateTime.Today;

            Student student = new Student();
            student.Name = "M.Sandeep";
            student.Address = "vijayawada";
            student.DateOfJoining = DateTime.Today;

            OfficeStaff staff = new OfficeStaff();
            staff.Name = "Mr.Naveen";
            staff.Address = "Guntur";
            staff.DateOfJoining = DateTime.Today;


            Console.WriteLine(teacher.getInfo() + "\n" + teacher.getTypeOfPerson());
            Console.WriteLine(student.getInfo() + "\n" + student.getTypeOfPerson());
            Console.WriteLine(staff.getInfo() + "\n" + staff.getTypeOfPerson());
        }

    }
}

