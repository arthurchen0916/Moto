using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Moto.MVC.Models
{
    public class Account
    {
        [DisplayName("使用者帳號")]
        [Required(ErrorMessage = "帳號為必填欄位")]
        public string Name { get; set; }

        [DisplayName("使用者密碼")]
        [Required(ErrorMessage = "密碼為必填項")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string LoginErrorMessage { get; set; }
    }
}