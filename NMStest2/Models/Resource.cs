using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NMStest.Models
{
    public class Resource
    {
        [Key]
        public int ResourceId { get; set; }
        public string resourceName { get; set; }

        
    }
}
