using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Lhotka.SlackClient
{
  public class Users
  {
    internal Users()
    { }

    public async Task<List<User>> GetUsers()
    {
      List<User> result = null;
      var client = new HttpClient();
      var response = await client.GetAsync(string.Format("https://slack.com/api/users.list?token={0}", SlackClient.SlackToken));
      var data = await response.Content.ReadAsStringAsync();
      var graph = JsonConvert.DeserializeObject<UserResult>(data);
      if (graph.Status)
        result = graph.Members;
      return result;
    }

    private class UserResult
    {
      [JsonProperty("ok")]
      public bool Status { get; set; }
      [JsonProperty("members")]
      public List<User> Members { get; set; }
      [JsonProperty("cache_ts")]
      public string CacheTS { get; set; }
    }
  }
}
