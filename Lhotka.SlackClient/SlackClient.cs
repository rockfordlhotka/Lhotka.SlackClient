using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;

namespace Lhotka.SlackClient
{
  public class SlackClient
  {
    internal static string SlackToken { get; private set; }

    public SlackClient(string slackToken)
    {
      SlackToken = slackToken;
    }

    public Users Users
    { get { return new Users(); } }
  }
}
