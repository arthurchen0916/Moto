using System.ComponentModel;

namespace Moto.Common.Models
{
    public class MotoSearch
    {
        [DisplayName("品牌：")]
        public string Brand_code { get; set; }
        public string Brand_name { get; set; }

        [DisplayName("排氣量：")]
        public string cc_s { get; set; }
        public string cc_e { get; set; }

        [DisplayName("建議售價：")]
        public string Factory_price { get; set; }
        public string Factory_price2 { get; set; }

        [DisplayName("年份：")]
        public string Year { get; set; }

        [DisplayName("ABS：")]
        public string ABS { get; set; }


    }
}

