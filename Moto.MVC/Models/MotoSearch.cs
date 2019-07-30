using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Moto.MVC.Models
{
    public class MotoSearch
    {
        [DisplayName("品牌：")]
        public string Brand_code { get; set; }
        public string Brand_name { get; set; }

        [DisplayName("排氣量：")]
        [DataType(DataType.Currency)]
        public string cc { get; set; }        

        [DisplayName("建議售價：")]
        [DataType(DataType.Currency)]
        public string Factory_price { get; set; }

        [DisplayName("年份：")]
        public string Year { get; set; }

        [DisplayName("ABS：")]
        public string ABS { get; set; }


    }
}

