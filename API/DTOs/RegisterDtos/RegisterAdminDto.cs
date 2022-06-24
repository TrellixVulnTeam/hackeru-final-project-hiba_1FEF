using System.ComponentModel.DataAnnotations;

namespace API.DTOs
{
    public class RegisterAdminDto
    {
        [Required]
        public string UserName { get; set; } = default!;

        [Required]
        public string Password { get; set; } = default!;
       
        [Required]
        public string  Email { get; set; } = default!;
        
    }
}