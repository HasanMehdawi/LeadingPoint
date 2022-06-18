using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace leadingPointDataClass.Entity
{
    public class Lookup
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [ForeignKey("lookupCategory")]
        public int lookUpCategory_ID { get; set; }
        public LookupCategory lookupCategory { get; set; }


        [InverseProperty("Gender")]
        public List<Employee> employeesGender { get; set; }

        [InverseProperty("Position")]
        public List<Employee> employeesPosition { get; set; }

    }
}
