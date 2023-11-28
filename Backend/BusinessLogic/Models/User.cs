using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HZS.Models{
    [Table("Users")]
    public class User{
        public Guid Id { get; set;}
        [Required]
        public string Username { get; set; } = default!;
        [Required]
        public string Password { get; set; } = default!;
        [Required]
        public string FirstName { get; set; } = default!;
        [Required]
        public string LastName { get; set; } = default!;
        [Required]
        public string Email { get; set; } = default!;
        public int Xp { get; set; } = 0;

        public List<Post> posts = new();
    }
}