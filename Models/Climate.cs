using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreSqlDb.Models
{
    public class Climate
    {
        public int ClimateID { get; set; }

        [Required]
        [StringLength(30, ErrorMessage = "Maximum Length of a Name is 30 characters.")]
        [Display(Name = "Name:")]
        public string Name { get; set; }

        [Required]
        [StringLength(256, ErrorMessage = "Maximum Length of a Description is 256 characters.")]
        [Display(Name = "Description:")]
        public string Description { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Rain in Winter:")]
        public string Rain_in_Winter { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Rain Growing Season:")]
        public string Rain_during_Growing_Season { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Rain During Harvest:")]
        public string Rain_during_Harvest { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Temp in Winter:")]
        public string Temp_in_Winter { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Temp Growing Season:")]
        public string Temp_during_Growing_Season { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Temp Continentality:")]
        public string Temp_Continentality { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Temp Diurnal:")]
        public string Temp_Diurnal { get; set; }

        [Required]
        [StringLength(10)]
        [Display(Name = "Vintage Variation:")]
        public string Vintage_Variation { get; set; }

        [Required]
        [StringLength(4)]
        [Display(Name = "Close to Water:")]
        public string Proximity_to_Large_Bodies_of_Water { get; set; }
    }
}
