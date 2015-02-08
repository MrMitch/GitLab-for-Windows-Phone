using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GitLab_for_Windows_Phone.Models
{
    [DataContract]
    public class Issue
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "iid")]
        public int RelativeId{ get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "labels")]
        public List<string> Labels { get; set; }

        [DataMember(Name = "state")]
        public string Status { get; set; }

        [DataMember(Name = "created_at")]
        public DateTimeOffset CreationDate { get; set; }

        [DataMember(Name = "updated_at")]
        public DateTimeOffset LastUpdateDate { get; set; }

        [DataMember(Name = "author")]
        public User Author { get; set; }


        [IgnoreDataMember]
        public bool IsClosed
        {
            get { return Status == "closed"; }
        }
    }
}
