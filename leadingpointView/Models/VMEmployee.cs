using leadingPointDataClass.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace leadingpointView.Models
{
    public class VMEmployee
    {
        public Employee employee { get; set; }
        public Project project { get; set; }
        public List<Country> licountries { get; set; }
        public List<Lookup> gender { get; set; }
        public List<Lookup> pisition { get; set; }
    }
}
