using System.Runtime.Serialization;

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
        public TreeElementTypes Type { get; set; }

        [DataMember(Name = "mode")]
        public int Mode { get; set; }
    }
}
