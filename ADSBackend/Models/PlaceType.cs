using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ADSBackend.Models
{
    public class PlaceType
    {
        [Key]
        public int PlaceTypeId { get; set; }

        [Display(Name="Place Category")]
        public string Category { get; set; }

        public List<Place> Places { get; set; }
    }
}
