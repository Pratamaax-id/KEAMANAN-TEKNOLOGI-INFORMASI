using System;
using System.ComponentModel.DataAnnotations;

namespace SampleSecureWeb.ViewModels;

public class RegistrationViewModel
{
    [Required]
    public string? Username { get; set; }

    //KODE PASSWORD (Minimal 12 karakter & Mengandung huruf besar, huruf kecil, dan angka)
    [Required]
    [DataType(DataType.Password)]
    [MinLength(12, ErrorMessage = "Password must be at least 12 characters long.")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$", 
        ErrorMessage = "Password must contain at least one lowercase letter, one uppercase letter, and one digit.")]
    public string? Password { get; set; }


    // KODE LAMA PAK ERICK  
    // [Required]
    // [DataType(DataType.Password)]
    // public string? Password { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [Display(Name = "ConfirmPssword")]
    [Compare("Password", ErrorMessage = "The Passwprd and Confirmation Password DO NOT MATCH !!!")]
    public string? ConfirmPassword { get; set; }
}
