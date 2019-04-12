using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NMStest.Models
{
    public class Planet
    {
        [Key]
        public int PlanetId { get; set; }

        public string PlanetName { get; set; }
        public string Sentinels { get; set; }
        
        public bool HasAcientBones { get; set; }
        public bool HasSalvageScrap { get; set; }

        public int SystemId { get; set; }
        public StarSystems StarSystem { get; set; }

        public ICollection<Resource> Resources { get; set; }

    }
}
