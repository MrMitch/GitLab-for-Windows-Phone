using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace GitLab_for_Windows_Phone.Models
{
    [DataContract]
    public class TreeElement
    {
        [DataContract]
        public enum TreeElementTypes
        {
            [EnumMember]
            Unknow,
            [EnumMember(Value = "tree")]
            Folder,
            [EnumMember(Value = "blob")]
            File
        }

        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "type")]
        [JsonConverter(typeof(StringEnumConverter))]
        public TreeElementTypes Type { get; set; }

        [DataMember(Name = "mode")]
        public int Mode { get; set; }
    }
}
