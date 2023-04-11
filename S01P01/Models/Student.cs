using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace S01P01.Models
{
    public class Student
    {
        [Display(Name="Student Number")]
        public string StudentNo { get; set; }

        [Display(Name = "First Name")]
        public string Name { get; set; }

        [Display(Name = "Last Name")]
        public string Surname { get; set; }

        [Display(Name = "Email Address")]
        public string Email { get; set; }
    }
}