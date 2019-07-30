using System;

namespace Moto.Common.Entities
{
    public partial class Brand : BaseEntity
    {
        public string Brand_code { get; set; }
        public string Brand_name { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public string Name { get; set; }
        public DateTime Update_date { get; set; }
    }
}