using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace leadingPointDataClass.Entity
{
    public class LookupCategory
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<Lookup> lilookups { get; set; }
    }
}
