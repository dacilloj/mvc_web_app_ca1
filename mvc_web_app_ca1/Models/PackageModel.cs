using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace mvc_web_app_ca1.Models
{
    public class PackageModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [StringLength(60)]
        public string ClientName { get; set; }

        [Required]
        [StringLength(200, MinimumLength =6)]
        public string Address { get; set; }

        [Required]
        [Range(0,100)]
        public double? Weight { get; set; }

        [Required]
        [Range(0,200)]
        public double Lenght { get; set; }
        [Required]
        public double Height { get; set; }

    }
}
