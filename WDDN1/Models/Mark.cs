﻿
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WDDN1.Models
{
    public class Mark
    {
         
        [Key Column(Order=1)]
        public int StudentId { get; set; }
        
        [Key Column(Order = 2)]
        public int CourseId { get; set; }

        public double marks { get; set; }
        public virtual Student student { get; set; }
        public virtual Course course { get; set; }
    }
}