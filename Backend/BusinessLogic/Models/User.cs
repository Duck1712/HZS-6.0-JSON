namespace HZS.Models{
    public class User{
        public Guid Id { get; set;}
        public String Username { get; set; }
        public String Password { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public int Xp { get; set; }
    }
}