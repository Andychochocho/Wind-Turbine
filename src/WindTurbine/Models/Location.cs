using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WindTurbine.Models
{
    [Table("Locations")]
    public class Location
    {
        [Key]
        public int Locationid { get; set; }
        public string Name { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
