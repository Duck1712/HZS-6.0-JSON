namespace HZS.Models{
    public class Post{
        public Guid Id { get; set; }
        public String Title { get; set; }
        public String Content { get; set; }
        public String Sport { get; set; }
        public Guid UserId { get; set; }
    }
}