using System;
using System.Runtime.Serialization;

namespace GitLab_for_Windows_Phone.Models
{
    public class Session
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "username")]
        public string Username { get; set; }

        [DataMember(Name = "email")]
        public string Email { get; set; }

        [DataMember(Name = "private_token")]
        public string Token { get; set; }

        [DataMember(Name = "is_admin")]
        public bool IsAdmin { get; set; }

        [DataMember(Name = "created_at")]
        public DateTimeOffset CreationDate { get; set; }

        [DataMember(Name = "blocked")]
        public bool IsBlocked { get; set; }

        /*
         {
          "id": 1,
          "username": "john_smith",
          "email": "john@example.com",
          "name": "John Smith",
          "private_token": "dd34asd13as",
          "blocked": false,
          "created_at": "2012-05-23T08:00:58Z",
          "bio": null,
          "skype": "",
          "linkedin": "",
          "twitter": "",
          "website_url": "",
          "dark_scheme": false,
          "theme_id": 1,
          "is_admin": false,
          "can_create_group": true,
          "can_create_team": true,
          "can_create_project": true
        }
         
         */
    }
}
