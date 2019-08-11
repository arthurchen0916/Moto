using System.ComponentModel;
using System;

namespace Moto.Common.Models
{
    public class TransactionRecord
    {
        [DisplayName("日期：")]
        public DateTime Date { get; set; }

        [DisplayName("姓名：")]
        public string Name { get; set; }

        [DisplayName("金額：")]
        public int Amount { get; set; }

        [DisplayName("品項：")]
        public string Detail { get; set; }

        [DisplayName("備註：")]
        public string Memo { get; set; }

    }
}



