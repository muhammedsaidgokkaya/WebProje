using System.ComponentModel.DataAnnotations;

namespace WebProje.Models
{
    public class AdminUser
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
