using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace phase1section5._6
{
    internal class Class1
    {
        private string name;
        private Teacher classTeacher;
        private List<Student> students;
        private List<subject> subjects;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Teacher ClassTeacher
        {
            get { return classTeacher; }
            set { classTeacher = value; }
        }

        public List<Student> Students
        {
            get { return students; }
            set { students = value; }
        }

        public List<subject> Subjects
        {
            get { return subjects; }
            set { subjects = value; }
        }
    }
}

 
