using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace mvc_web_app_ca1.Models
{
    public class PackageModel
    {
        [Required]
        [Display(Name ="ID")]
        public int? Id { get; set; }

        [Display(Name = "Enter your name")]
        [Required]
        [StringLength(60)]
        public string ClientName { get; set; } = string.Empty;

        [Display(Name = "Company Address")]
        [Required]
        [StringLength(200, MinimumLength =6)]
        public string Address { get; set; } = String.Empty;

        [Display(Name = "Weight (kg)")]
        [Range(0,100)]
        public double Weight { get; set; }

        [Display(Name = "Lenght (cm)")]

        [Range(0,200)]
        public double Lenght { get; set; }

        [Display(Name = "Height (cm)")]
        public double Height { get; set; }

        [Display(Name = "Width (cm)")]
        public double Width { get; set; }

    }
}
