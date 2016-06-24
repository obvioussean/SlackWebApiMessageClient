using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SlackWebApiMessageClient
{
    [DataContract]
    public class Message
    {
        public Message(string channel, string username)
        {
            Attachments = new List<Attachment>();
            Channel = channel;
            Username = username;
        }

        [DataMember(Name = "channel", EmitDefaultValue = false)]
        public string Channel { get; private set; }

        [DataMember(Name = "username", EmitDefaultValue = false)]
        public string Username { get; private set; }

        [DataMember(Name = "as_user", EmitDefaultValue = false)]
        public bool AsUser { get; private set; }

        [DataMember(Name = "icon_url", EmitDefaultValue = false)]
        public string IconUrl { get; set; }

        [DataMember(Name = "icon_emoji", EmitDefaultValue = false)]
        public string IconEmoji { get; set; }

        [DataMember(Name = "link_names", EmitDefaultValue = false)]
        public int LinkNames { get; private set; }

        [DataMember(Name = "unfurl_links", EmitDefaultValue = false)]
        public bool UnfurlLinks { get; private set; }

        [DataMember(Name = "unfurl_media", EmitDefaultValue = false)]
        public bool UnfurlMedia { get; private set; }
        
        [DataMember(Name = "text", EmitDefaultValue = false)]
        public string Text { get; set; }

        [DataMember(Name = "parse", EmitDefaultValue = false)]
        public string Parse { get; set; }

        [DataMember(Name = "mrkdwn", EmitDefaultValue = false)]
        public bool Markdown { get; set; }

        [DataMember(Name = "attachments", EmitDefaultValue = false)]
        public IList<Attachment> Attachments { get; set; }
    }
}
