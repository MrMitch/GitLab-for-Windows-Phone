using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GitLab_for_Windows_Phone.Models
{
    [DataContract]
    public class Commit
    {
        [DataMember(Name = "id")]
        public string Id { get; set; }

        [DataMember(Name = "short_id")]
        public string ShortId { get; set; }

        [DataMember(Name = "title")]
        public string Title { get; set; }

        [DataMember(Name = "author_name")]
        public string AuthorName { get; set; }

        [DataMember(Name = "author_email")]
        public string AuthorEmail { get; set; }

        [DataMember(Name = "created_at")]
        public DateTimeOffset Date { get; set; }

        [DataMember(Name = "message")]
        public string Message { get; set; }

        [IgnoreDataMember]
        public string AuthorInfo
        {
            get { return !String.IsNullOrWhiteSpace(AuthorName) ? AuthorName : AuthorEmail; }
        }

        [IgnoreDataMember]
        public string Description
        {
            get { return String.Equals(Message.Trim(), Title.Trim(), StringComparison.CurrentCultureIgnoreCase) ? string.Empty : Message; }
        }

        /*
         {
            "id": "4016ed8e63856df7eb44306bdb315476f40aabe0",
            "short_id": "4016ed8e",
            "title": "FragmentEditionViewmodel.IsReadOnly \u0026 FieldEditionViewModel.IsReadOnly",
            "author_name": "Mickael GOETZ",
            "author_email": "contact@mickael-goetz.com",
            "created_at": "2015-01-29T18:00:12.000+01:00",
            "message": "FragmentEditionViewmodel.IsReadOnly \u0026 FieldEditionViewModel.IsReadOnly\n"
        }
         */
    }
}
