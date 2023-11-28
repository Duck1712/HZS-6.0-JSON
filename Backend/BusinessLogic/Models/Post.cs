using System.ComponentModel.DataAnnotations;

namespace HZS.Models{
    public class Post{
        public Guid Id { get; set; }
        [Required]
        public String Title { get; set; }
        [Required]
        public String Content { get; set; }
        [Required]
        public String Sport { get; set; }


        public Guid UserId { get; set; }
        
        public User user { get; set; }
    }
}