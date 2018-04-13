using System;
using System.ComponentModel.DataAnnotations;

namespace lost_woods.Models
{
    public class Trail : BaseEntity
    {
        [Key]
        public long id {get;set;}

        [Required]
        [MinLength(2)]
        [Display(Name = "Trail Name")]
        public string name {get; set;}

        [Required]
        [MinLength(10)]
        [Display(Name = "Description")]

        public string description {get;set;}

        [Required]
        [Display(Name = "Length (miles)")]
        public float length {get;set;}

        [Required]
        [Display(Name = "Elevation Gain (feet)")]
        public float elevation {get;set;}

        [Required]
        [Range(-180,180)]
        [Display(Name = "Longitude")]
        public float longitude {get;set;}

        [Required]
        [Range(-90,90)]
        [Display(Name = "Latitude")]
        public float latitude {get;set;}

    }
}