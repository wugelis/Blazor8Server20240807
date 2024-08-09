using System.ComponentModel.DataAnnotations;

namespace Blazor8Server20240807.Models
{
    /// <summary>
    /// 登入請求定義
    /// </summary>
    public class LoginRequest
    {
        [Required]
        [Display(Name = "使用者名稱")]
        public string Username { get; set; }
        [Required]
        [Display(Name = "密碼")]
        public string Password { get; set; }
        [Required]
        [Display(Name = "電子郵件")]
        public string EMail { get; set; }
    }
}
