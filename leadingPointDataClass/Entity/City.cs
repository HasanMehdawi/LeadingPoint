using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace leadingPointDataClass.Entity
{
    public class City
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [ForeignKey("country")]
        public int Country_Id { get; set; }
        public Country country { get; set; }
        public List<Employee> liemployees { get; set; }
    }
}
