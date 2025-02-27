using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Entity01
{
    public class CourseInst
    {
        [Key]
        public int instID { get; set; }
        public int CourseID { get; set; }
        public string evaluate { get; set; }
    }
}
