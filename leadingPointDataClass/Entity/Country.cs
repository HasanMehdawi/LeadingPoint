using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace leadingPointDataClass.Entity
{
    public class Country
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<City> licity { get; set; }
        public List<Employee> liemployees { get; set; }
    }
}
