using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleHost
{
  class Program
  {
    static void Main(string[] args)
    {
      var client = new Lhotka.SlackClient.SlackClient(ConfigurationManager.AppSettings["SlackToken"]);
      var obj = client.Users;
      var list = obj.GetUsers().Result;
      Console.WriteLine(list.Count);
      Console.ReadKey();
    }
  }
}
