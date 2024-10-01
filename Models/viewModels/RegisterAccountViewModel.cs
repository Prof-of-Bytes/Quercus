using System.ComponentModel.DataAnnotations;
namespace Quercus.Models{

    public class RegisterAccountViewModel{

        [Required(ErrorMessage = "Please enter a vaild usernmae")]
        [StringLength(128)]
        public string Username { get; set; } = string.Empty;

        [Required(ErrorMessage = "Please enter a valid password")]
        [DataType(DataType.Password)]
        [Compare("ConfirmPass")]
        public string Password {get; set;} = string.Empty;

        [Required(ErrorMessage = "Check password confirm field")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        public string ConfirmPass {get; set;} = string.Empty;   

    }
}