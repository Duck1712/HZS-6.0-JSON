using System.Text.Json.Serialization;

namespace HZS.Models{
    public class PutUser{
        [JsonIgnoreAttribute]
        public Guid Id { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String Email { get; set; }
    }
}