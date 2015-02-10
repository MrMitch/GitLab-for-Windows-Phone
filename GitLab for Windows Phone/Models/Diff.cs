using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GitLab_for_Windows_Phone.Models
{
    [DataContract]
    public class FileDiff
    {
        [DataMember(Name = "diff")]
        public string Content { get; set; }

        [DataMember(Name = "new_path")]
        public string NewPath { get; set; }

        [DataMember(Name = "old_path")]
        public string OldPath { get; set; }

        [DataMember(Name = "renamed_file")]
        public bool WasRenamed { get; set; }

        [DataMember(Name = "deleted_file")]
        public bool WasDeleted { get; set; }

        [DataMember(Name = "new_file")]
        public bool WasNew { get; set; }
    }
}
