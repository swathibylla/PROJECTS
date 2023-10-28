using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phase1sectionn5._4
{
    struct Student
    {
        public string name;
        public string address;
        public int rollNumber;
        public string className;
        public DateTime dateOfBirth;
    }


internal class Program
    {
        static void Main(string[] args)
        {
            doApp();
        }

        public static void doApp()
        {

            Student[] students = new Student[5];


            students[0].name = "Dinesh ";
                students[1].address = "Hyderbad ";
                students[2].rollNumber = 1;
                students[3].className = "A";
                students[4].dateOfBirth = Convert.ToDateTime("1992-09-10 00:00:00");
            }

         
                
            }

        }
 
