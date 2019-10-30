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

        [Required]
        [Display(Name = "Activity Name")]
        public String Activity { get; set; }

        [Display(Name = "Activity Description")]
        public String Description { get; set; }

        [Required]
        [Display(Name = "Location Address")]
        public String Address { get; set; }
    }
}
