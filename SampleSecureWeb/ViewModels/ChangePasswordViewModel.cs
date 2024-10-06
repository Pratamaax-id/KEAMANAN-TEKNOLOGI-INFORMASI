using System;
using System.ComponentModel.DataAnnotations;

namespace SampleSecureWeb.ViewModels
{
    public class ChangePasswordViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        public string? CurrentPassword { get; set; }  

        [Required]
        [MinLength(12, ErrorMessage = "Kata sandi baru harus memiliki panjang setidaknya 12 karakter.")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$", ErrorMessage = "Kata sandi baru harus mengandung setidaknya satu huruf besar, satu huruf kecil, dan satu angka.")]
        [DataType(DataType.Password)]
        public string? NewPassword { get; set; } 

        [Required]
        [Compare("NewPassword", ErrorMessage = "Kata sandi tidak cocok.")]
        [DataType(DataType.Password)]
        public string? ConfirmNewPassword { get; set; }  
    }
}
