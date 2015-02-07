using System;
using System.Runtime.Serialization;

namespace GitLab_for_Windows_Phone.Models
{
    [DataContract]
    public class Project
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "name_with_namespace")]
        public string FullName { get; set; }

        [DataMember(Name = "description")]
        public string Description { get; set; }

        [DataMember(Name = "default_branch")]
        public string DefaultBranch { get; set; }

        [DataMember(Name = "public")]
        public bool IsPublic { get; set; }

        [DataMember(Name = "ssh_url_to_repo")]
        public Uri SshRepoUri { get; set; }

        [DataMember(Name = "http_url_to_repo")]
        public Uri HttpRepoUri { get; set; }

        [DataMember(Name = "web_url")]
        public Uri WebUri { get; set; }

        [DataMember(Name = "namespace")]
        public Namespace Namespace { get; set; }

        [DataMember(Name = "created_at")]
        public DateTimeOffset CreationDate { get; set; }

        [DataMember(Name = "last_activity_at")]
        public DateTimeOffset LastActivityDate { get; set; }

        [DataMember(Name = "archived")]
        public bool IsArchived { get; set; }

        /*
         
         {
            "id": 4,
            "description": null,
            "default_branch": "master",
            "public": false,
            "visibility_level": 0,
            "ssh_url_to_repo": "git@example.com:diaspora/diaspora-client.git",
            "http_url_to_repo": "http://example.com/diaspora/diaspora-client.git",
            "web_url": "http://example.com/diaspora/diaspora-client",
            "owner": {
              "id": 3,
              "name": "Diaspora",
              "created_at": "2013-09-30T13: 46: 02Z"
            },
            "name": "Diaspora Client",
            "name_with_namespace": "Diaspora / Diaspora Client",
            "path": "diaspora-client",
            "path_with_namespace": "diaspora/diaspora-client",
            "issues_enabled": true,
            "merge_requests_enabled": true,
            "wiki_enabled": true,
            "snippets_enabled": false,
            "created_at": "2013-09-30T13: 46: 02Z",
            "last_activity_at": "2013-09-30T13: 46: 02Z",
            "namespace": {
              "created_at": "2013-09-30T13: 46: 02Z",
              "description": "",
              "id": 3,
              "name": "Diaspora",
              "owner_id": 1,
              "path": "diaspora",
              "updated_at": "2013-09-30T13: 46: 02Z"
            },
            "archived": false
          }
         
         */
    }
}
