using System.Text.Json.Serialization;

namespace HZS.Models{
    public class PutUser{
        [JsonIgnoreAttribute]
        public Guid Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
    }
}