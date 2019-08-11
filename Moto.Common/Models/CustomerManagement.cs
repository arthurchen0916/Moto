using System.ComponentModel;

namespace Moto.Common.Models
{
    public class CustomerManagement
    {
        [DisplayName("手機號碼：")]
        public string Phone_Number { get; set; }

        [DisplayName("住家電話：")]
        public string Tel_Number { get; set; }

        [DisplayName("姓名：")]
        public string Name { get; set; }

        [DisplayName("車牌號碼：")]
        public string License_Plate { get; set; }

        [DisplayName("地址：")]
        public string Address { get; set; }

    }
}
