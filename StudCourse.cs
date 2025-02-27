using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Entity01
{
    public class StudCourse
    {
        [Key]
        public int stud_ID { get; set; }
        public int Course_ID { get; set; }
        public decimal Grade { get; set; }
    }
}
