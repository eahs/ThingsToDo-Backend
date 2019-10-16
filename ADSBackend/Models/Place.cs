using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ADSBackend.Models
{
    public class Place
    {
        [Key]
        public int PlaceId;

        [DisplayName("Place Name")]
        public String Name;
    }
}
