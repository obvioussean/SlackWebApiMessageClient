using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace SlackWebApiMessageClient
{
    public class SlackClient
    {
        public SlackClient(string token, HttpClientHandler handler = null)
        {
            Token = token;
            HttpClient = handler == null ? new HttpClient() : new HttpClient(handler);
        }

        private string Token { get; set; }

        private HttpClient HttpClient { get; set; }

        public Task<HttpResponseMessage> SendMessageAsync(Message message)
        {
            if (message == null)
            {
                return null;
            }

            var formUrlEncodedContent = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("token", Token)
            };

            // Serialize to json so that only the assigned values get serialized.
            // We do not want any unassigned value being sent to Slack.
            // Deserialize into a dictionary and add each value to the form.
            // NOTE: This may just be me not knowing how to do this better.
            var json = JsonConvert.SerializeObject(message);
            var messageDictionary = JObject.Parse(json);
            foreach (var entry in messageDictionary)
            {
                formUrlEncodedContent.Add(new KeyValuePair<string, string>(entry.Key, entry.Value.ToString()));
            }

            return HttpClient.PostAsync("https://slack.com/api/chat.postMessage", new FormUrlEncodedContent(formUrlEncodedContent));
        }
    }
}
