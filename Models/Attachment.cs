using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SlackWebApiMessageClient
{
    [DataContract]
    public class Attachment
    {
        public Attachment()
        {
            Fields = new List<Field>();
        }

        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        [DataMember(Name = "title_link", EmitDefaultValue = false)]
        public string TitleLink { get; set; }

        [DataMember(Name = "pretext", EmitDefaultValue = false)]
        public string PreText { get; set; }

        [DataMember(Name = "text", EmitDefaultValue = false)]
        public string Text { get; set; }

        [DataMember(Name = "fallback", EmitDefaultValue = false)]
        public string Fallback { get; set; }

        [DataMember(Name = "color", EmitDefaultValue = false)]
        public string Color { get; set; }

        [DataMember(Name = "fields", EmitDefaultValue = false)]
        public IList<Field> Fields { get; set; }

        [DataMember(Name = "author_name", EmitDefaultValue = false)]
        public string AuthorName { get; set; }

        [DataMember(Name = "author_icon", EmitDefaultValue = false)]
        public string AuthorIcon { get; set; }

        [DataMember(Name = "author_link", EmitDefaultValue = false)]
        public string AuthorLink { get; set; }

        [DataMember(Name = "image_url", EmitDefaultValue = false)]
        public string ImageUrl { get; set; }

        [DataMember(Name = "thumb_url", EmitDefaultValue = false)]
        public string ThumbnailUrl { get; set; }

        [DataMember(Name = "footer", EmitDefaultValue = false)]
        public string Footer { get; set; }
        
        [DataMember(Name = "footer_icon", EmitDefaultValue = false)]
        public string FooterIcon { get; set; }

        [DataMember(Name = "ts", EmitDefaultValue = false)]
        public long Timestamp { get; set; }
        
        public bool IsTextMarkdown { get; set; }

        public bool IsPreTextMarkdown { get; set; }

        [DataMember(Name = "mrkdwn_in", EmitDefaultValue = false)]
        public IList<string> MarkdownIn
        {
            get
            {
                var markdownIn = new List<string>();
                if (this.IsTextMarkdown)
                {
                    markdownIn.Add("text");
                }

                if (this.IsPreTextMarkdown)
                {
                    markdownIn.Add("pretext");
                }

                return markdownIn;
            }
        }
    }
}
