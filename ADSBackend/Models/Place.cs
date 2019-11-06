using System.ComponentModel.DataAnnotations;

namespace ADSBackend.Models
{
    public class Place
    {
        [Key]
        public int PlaceId { get; set; }

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

        [Required]
        [Display(Name = "Location Coordinates")]
        public string Coordinates { get; set; }
    }
}
