using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace leadingPointDataClass.Entity
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string FName { get; set; }
        [Required]
        public string SName { get; set; }
        [Required]
        public string MName { get; set; }
        [Required]
        public string LName { get; set; }
        [Required]

        public DateTime BDate { get; set; }
        [Required]
        [RegularExpression(@"\w+@\w+.com",ErrorMessage ="Email must be in form example@gmail.com")]
        public string Email { get; set; }
        public double Salary { get; set; }
        [ForeignKey("project")]
        public int Project_Id { get; set; }
        public Project project { get; set; }
        [ForeignKey("country")]
        public int Country_Id { get; set; }
        public Country country { get; set; }
        [ForeignKey("city")]
        public int City_Id { get; set; }
        public City city { get; set; }
        [ForeignKey("Gender")]
        public int Gender_Id { get; set; }
        public Lookup Gender { get; set; }

        [ForeignKey("Position")]
        public int Position_Id { get; set; }
        public Lookup Position { get; set; }

        [NotMapped]
        public IFormFile Image { get; set; }
        public string ImagePath { set; get; }

    }
}
