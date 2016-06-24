using System.Runtime.Serialization;

namespace SlackWebApiMessageClient
{
    [DataContract]
    public class Field
    {
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        [DataMember(Name = "short", EmitDefaultValue = false)]
        public bool Short { get; set; }
    }
}
