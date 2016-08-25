using Newtonsoft.Json;

namespace Lhotka.SlackClient
{
  public class User
  {
    [JsonProperty("id")]
    public string Id { get; set; }
    [JsonProperty("name")]
    public string Name { get; set; }
    [JsonProperty("deleted")]
    public bool Deleted { get; set; }
    [JsonProperty("color")]
    public string Color { get; set; }
    [JsonProperty("first_name")]
    public string FirstName { get; set; }
    [JsonProperty("last_name")]
    public string LastName { get; set; }
    [JsonProperty("real_name")]
    public string RealName { get; set; }
    [JsonProperty("email")]
    public string Email { get; set; }
    [JsonProperty("skype")]
    public string Skype { get; set; }
    [JsonProperty("phone")]
    public string Phone { get; set; }
    [JsonProperty("image_24")]
    public string Image_24 { get; set; }
    [JsonProperty("image_32")]
    public string Image_32 { get; set; }
    [JsonProperty("image_48")]
    public string Image_48 { get; set; }
    [JsonProperty("image_72")]
    public string Image_72 { get; set; }
    [JsonProperty("image_192")]
    public string Image_192 { get; set; }
    [JsonProperty("is_admin")]
    public bool IsAdmin { get; set; }
    [JsonProperty("is_owner")]
    public bool IsOwner { get; set; }
    [JsonProperty("has_2fa")]
    public bool Has2FA { get; set; }
    [JsonProperty("has_files")]
    public bool HasFiles { get; set; }
  }
}