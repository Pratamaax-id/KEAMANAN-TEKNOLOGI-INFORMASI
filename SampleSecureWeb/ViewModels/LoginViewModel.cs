using System;
using System.ComponentModel.DataAnnotations;

namespace SampleSecureWeb.ViewModels;

public class LoginViewModel
{
    [Required]
    public string Username { get; set; } = string.Empty;

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; } = string.Empty;
    public bool RememberLogin { get; set; }
    public string ReturnUrl { get; set; } = string.Empty;

}
