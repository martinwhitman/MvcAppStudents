using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MvcAppStudents.Enums;

namespace MvcAppStudents.Models
{
    public class StudentModel
    {
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public GenderEnum Gender { get; set; }
        public int Age { get; set; }
        public string Major { get; set; }
    }
}