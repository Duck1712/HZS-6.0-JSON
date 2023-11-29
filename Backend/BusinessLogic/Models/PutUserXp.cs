using System.Text.Json.Serialization;

namespace HZS.Models{
    public class PutUserXp{
        [JsonIgnoreAttribute]
        public Guid Id { get; set; }
        public int Xp { get; set; }
    }
}