using System.ComponentModel.DataAnnotations;

namespace mvc_web_app_ca1.Models
{
    public class DimensionsModel
    {
        [Required]
        public double Volume { get; set; }
        [Required]
        public double Density { get; set; }
        
        public enum ShippingCat
        {
            Low,
            Medium,
            High
        }
    }
}
