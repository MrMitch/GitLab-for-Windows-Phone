using System;
using System.Runtime.Serialization;

namespace GitLab_for_Windows_Phone.Models
{
    [DataContract]
    public class Note
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "body")]
        public string Body { get; set; }

        [DataMember(Name = "author")]
        public User Author { get; set; }

        [DataMember(Name = "created_at")]
        public DateTimeOffset CreationDate { get; set; }
    }
}
