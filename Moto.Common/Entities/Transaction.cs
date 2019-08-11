using System;

namespace Moto.Common.Entities
{
    public partial class Transaction : BaseEntity
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int Amount { get; set; }
        public string Detail { get; set; }
        public string Memo { get; set; }
        public DateTime Update_Date { get; set; }
    }
}
