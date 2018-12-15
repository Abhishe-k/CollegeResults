using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WDDN1.Models
{
    public class Student
    {
        [Key Column(Order = 1)]
        public int StudentID { get; set; }
        [ForeignKey("branch")]
        public int BranchId { get; set; }
        public int sem { get; set; }

        public string Fullname { get; set; }

        public DateTime? Dob { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public virtual Branch branch { get; set; }

    }
}