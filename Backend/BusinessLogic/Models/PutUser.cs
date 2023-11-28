using System.Text.Json.Serialization;

namespace HZS.Models{
    public class PutUser{
        [JsonIgnoreAttribute]
        public Guid Id { get; set; }
    }
}