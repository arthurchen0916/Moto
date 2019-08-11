using System;

namespace Moto.Common.Entities
{
    public partial class Customer : BaseEntity
    {
        public string Name { get; set; }
        public string License_Plate { get; set; }
        public string Phone_Number { get; set; }
        public string Tel_Number { get; set; }
        public string Address { get; set; }
        public bool Del_Flag { get; set; }
        public DateTime Update_Date { get; set; }
    }
}