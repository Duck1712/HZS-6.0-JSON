namespace HZS.Models{
    public class AddPost{
        public Guid Id { get; set; }
        public String Title { get; set; } = default!;
        public String Content { get; set; } = default!;
        public String Sport { get; set; }  = default!;
        public Guid UserId { get; set; }
        public User user { get; set; }
    }
}