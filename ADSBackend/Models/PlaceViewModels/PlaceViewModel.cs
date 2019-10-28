using System;
using System.ComponentModel.DataAnnotations;

namespace ADSBackend.Models.PlaceViewModels
{
    public class PlaceViewModel
    {
        [Key]
        public int PlaceId { get; set; }

        [Required]
        [Display(Name = "Place Name")]
        public String Name { get; set; }

        [Required]
        [Display(Name = "Location Name")]
        public String Location { get; set; }
    }
}
