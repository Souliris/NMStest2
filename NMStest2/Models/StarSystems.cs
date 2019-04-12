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

        public Planet Planet1 { get; set; }
        public Planet Planet2 { get; set; }
        public Planet Planet3 { get; set; }
        public Planet Planet4 { get; set; }
        public Planet Planet5 { get; set; }
        public Planet Planet6 { get; set; }
        public Planet Planet7 { get; set; }
        public Planet Planet8 { get; set; }
        public Planet Planet9 { get; set; }

    }
}
