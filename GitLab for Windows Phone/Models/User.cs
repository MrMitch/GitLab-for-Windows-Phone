using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitLab_for_Windows_Phone.Models
{
    public class User
    {
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

        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Bio { get; set; }
        public string ExternUid { get; set; }
        public Uri AvatarUri { get; set; }
        public bool CanCreateProjets { get; set; }
        public bool CanCreateGroups { get; set; }
    }
}
