using System.Text.Json.Serialization;

namespace ActiveDirectory
{
    public class User
    {
        public int Id { get; set; }
        [JsonPropertyName("email")]
        public string email { get; set; }
        [JsonPropertyName("username")]
        public string UserName { get; set; }
        public string Password { get; set; }
        public Name Name { get; set; }
        public Address Address { get; set; }
        public string Phone { get; set; }
    }

    public class Users : List<User> { }
    public class Name
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }

    public class Address
    {
        public string City { get; set; }
        public string Street { get; set; }
        public int Number { get; set; }
        public string Zipcode { get; set; }
        public Geolocation Geolocation { get; set; }
    }

    public class Geolocation
    {
        public string Lat { get; set; }
        public string Long { get; set; }
    }
}