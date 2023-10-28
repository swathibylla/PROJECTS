using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phase1section5._8
{
    internal class Class1
    {
        private string name;
        private Teacherclass whichTeacher;
        private List<Teacher> Teachers;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Teacherclass WhichTeacher
        {
            get { return whichTeacher; }
            set { whichTeacher = value; }
        }

        public List<Teacher> SubjectTeachers
        {
            get { return Teachers; }
            set { SubjectTeachers = value; }
        }

    }
}
