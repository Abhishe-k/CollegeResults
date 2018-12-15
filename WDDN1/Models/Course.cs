using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WDDN1.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [ForeignKey("Branch")]
        public int BranchId { get; set; }
        public string CourseName { get; set; }
        public int sem { get; set; }

        public virtual Branch Branch { get; set; }



    }
}