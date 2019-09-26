using System;

namespace Moto.Common.Entities
{
    public partial class Model : BaseEntity
    {
        public string model { get; set; }
        public String brand_code { get; set; }
        public int Year { get; set; }
        public double cc { get; set; }
        public string Color { get; set; }
        public string Front_wheel_brakes { get; set; }
        public string Rear_wheel_brakes { get; set; }
        public bool ABS { get; set; }
        public int Factory_price { get; set; }
        public int Retail_price { get; set; }
        public DateTime update_date { get; set; }
    }
}