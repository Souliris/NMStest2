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
        public Resource planetResource1 { get; set; }
        public Resource planetResource2 { get; set; }
        public Resource planetResource3 { get; set; }
        public Resource planetResource4 { get; set; }
        public bool HasAcientBones { get; set; }
        public bool HasSalvageScrap { get; set; }



    }
}
