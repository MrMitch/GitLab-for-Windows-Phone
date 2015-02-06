using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GitLab_for_Windows_Phone.Models
{
    public class User
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "username")]
        public string Username { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "avatar_url")]
        public Uri AvatarUri { get; set; }

        [DataMember(Name = "is_admin")]
        public bool IsAdmin{ get; set; }

        // admin



        [DataMember(Name = "bio")]
        public string Bio { get; set; }

        [DataMember(Name = "extern_uid")]
        public string ExternUid { get; set; }

        [DataMember(Name = "can_create_project")]
        public bool CanCreateProjet { get; set; }

        [DataMember(Name = "can_create_group")]
        public bool CanCreateGroup { get; set; }


        /*
         
        "id": 1,
        "username": "john_smith",
        "email": "john@example.com",
        "name": "John Smith",
        "state": "active",
        "created_at": "2012-05-23T08:00:58Z",
        "bio": null,
        "skype": "",
        "linkedin": "",
        "twitter": "",
        "website_url": "",
        "extern_uid": "john.smith",
        "provider": "provider_name",
        "theme_id": 1,
        "color_scheme_id": 2,
        "is_admin": false,
        "avatar_url": "http://localhost:3000/uploads/user/avatar/1/cd8.jpeg",
        "can_create_group": true
         */

    }
}
