using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreEmptyWeb.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //-------3.6 öncesi--------------------
        //public string Description { get; set; }
        //public bool isPublished { get; set; }

    }
}
