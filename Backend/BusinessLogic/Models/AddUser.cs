namespace HZS.Models{
    public class AddUser{
        public Guid Id { get; set; }
        public string Username { get; set; } = default!;
        public string Password { get; set; } = default!;
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string Email { get; set; } = default!;
    }
}