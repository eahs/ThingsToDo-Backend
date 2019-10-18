using System;
using System.ComponentModel.DataAnnotations;

namespace ADSBackend.Models.PlaceViewModels
{
    public class PlaceViewModel
    {
        [Key]
        public int PlaceId;

        [Required]
        [Display(Name = "Place Name")]
        public String Name;

        [Required]
        [Display(Name = "Location Name")]
        public String Location;
    }
}
