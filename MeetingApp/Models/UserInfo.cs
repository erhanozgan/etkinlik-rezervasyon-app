using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models;

public class UserInfo
{
    public int id { get; set; }
    [Required(ErrorMessage = "Ad alanı zorunlu")]
    public string? Name { get; set; }
    [Required(ErrorMessage = "Lütfen telefonunuzu giriniz")]
    public string? Phone { get; set; }
    [Required(ErrorMessage = "Email adresi geçersiz")]
    [EmailAddress]
    public string? Email { get; set; }
    [Required]
    public bool? WillAttent { get; set; }
}