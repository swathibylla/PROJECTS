﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phase1section5._8
{
    internal class Teacherclass
    {
        private string name;
        private string address;
        private string contactAddress;
        private DateTime dateOfJoining;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string ContactAddress
        {
            get { return address; }
            set { address = value; }
        }

        public DateTime DateOfJoining
        {
            get { return dateOfJoining; }
            set { dateOfJoining = value; }
        }
    }
}


  
