using System.Text.Json.Serialization;

namespace Models
{
    public class UserModel
    {
        [JsonPropertyName("username")]
        public string UserName { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
    }
}
