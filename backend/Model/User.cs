using System.Text.Json.Serialization;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace backend.Model;

public class User
{
    [BsonId]
    [JsonPropertyName("UserId")]
    public string? Id { get; set; }

    [BsonElement("UserName")]
    [JsonPropertyName("UserName")]
    public string? UserName { get; set; }

    [BsonElement("Password")]
    [JsonPropertyName("Password")]
    public string? Password { get; set; }
}