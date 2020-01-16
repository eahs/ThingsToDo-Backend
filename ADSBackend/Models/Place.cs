using System.ComponentModel.DataAnnotations;

namespace ADSBackend.Models
{
    public class Place
    {
        [Key]
        public int PlaceId { get; set; }

        public int PlaceTypeId { get; set; }
        public PlaceType PlaceType { get; set; }

        [Required]
        [Display(Name = "Place Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Location Name")]
        public string Location { get; set; }

        [Required]
        [Display(Name = "Activity Name")]
        public string Activity { get; set; }

        [Display(Name = "Activity Description")]
        public string Description { get; set; }

        [Required]
        [Display(Name = "Location Address")]
        public string Address { get; set; }

        [Display(Name = "Hours of Operation")]
        public string Hours { get; set; }

        [Display(Name = "Activity Cost")]
        public string Cost { get; set; }

        [Required]
        [Display(Name = "Location Latitude")]
        public string Latitude { get; set; }

        [Required]
        [Display(Name = "Location Longitude")]
        public string Longitude { get; set; }

        [Display(Name = "Image URL")]
        public string Image { get; set; }
    }
}
