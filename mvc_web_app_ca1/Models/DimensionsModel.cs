using System.ComponentModel.DataAnnotations;

namespace mvc_web_app_ca1.Models
{
    public class DimensionsModel
    {
       
        public double Volume { get; set; }
       
        public double Density { get; set; }
        
        public enum ShippingCat
        {
            Low,
            Medium,
            High
        }

        public string category { get; set; }

       public DimensionsModel(PackageModel p)
        {
            Volume = p.Lenght * p.Height * p.Width;
            Density = p.Weight / Volume;
            if (Density >= 100)
            {
                var category = ShippingCat.High;
            } 
            else if  (Density < 100)
            {
                var category = ShippingCat.Medium;
            }

            else if (Density < 1)
            {
                var category = ShippingCat.Medium;
            }
            
        }
    }
}
