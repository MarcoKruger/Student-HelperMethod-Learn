using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Student
    {
        public int StudentId { get; set; }

        [Required]
        [Display(Name = "Student Name")]
        public string StudentName { get; set; }

        [Required]
        [Display(Name = "Student ID Number")]
        public int StudentIdNumber { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Student Email")]
        public string StudentEmail { get; set; }

        [Required]
        [Display(Name = "Student Gender")]
        public StudentAge StudentGender { get; set; }


    }
    public enum StudentAge
    {
        Male,
        Female
    }
}