using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GitLab_for_Windows_Phone.Models
{
    [DataContract]
    public class Avatar
    {
        [DataMember(Name = "url")]
        public Uri Url { get; set; }
    }
}
