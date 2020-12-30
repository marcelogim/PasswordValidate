using System.ComponentModel.DataAnnotations;

namespace PasswordValidate.Model
{
    public class PasswordValidateReqModel
    {
        [Required]
        public string Password { get; set; }
    }
}
