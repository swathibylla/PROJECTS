using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teacher
{
  
    
        public class Teacher
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string ClassAndSection { get; set; }

            public override string ToString()
            {
                return $"{Id},{Name},{ClassAndSection}";
            }
        }
}
