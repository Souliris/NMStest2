using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NMStest.Models
{
    public class StarSystems
    {
        [Key]
        public int SystemId { get; set; }

        [Required, StringLength(100)]
        public string SystemName { get; set; }


        public string StarType { get; set; }
        public string EconomyType { get; set; }
        public string ConflictType { get; set; }
        public ICollection<Planet> Planets { get; set; }

        
    }
}
