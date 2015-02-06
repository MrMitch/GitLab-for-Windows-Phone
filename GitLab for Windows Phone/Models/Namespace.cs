using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GitLab_for_Windows_Phone.Models
{
    public class Namespace
    {
        [DataMember(Name = "id")]
        public int Id { get; set; }

        [DataMember(Name = "name")]
        public string Name { get; set; }

        [DataMember(Name = "owner_id")]
        public int OwnerId { get; set; }

        [DataMember(Name = "path")]
        public string Path { get; set; }

        [DataMember(Name = "created_at")]
        public DateTimeOffset CreationDate { get; set; }


        public bool Equals(Namespace ns)
        {
            if (ns == null)
            {
                return false;
            }

            return ns.Id == Id;
        }

        /// <summary>
        /// Détermine si l'objet spécifié est identique à l'objet actuel.
        /// </summary>
        /// <returns>
        /// true si l'objet spécifié est égal à l'objet actif ; sinon, false.
        /// </returns>
        /// <param name="obj">Objet à comparer avec l'objet actif.</param><filterpriority>2</filterpriority>
        public override bool Equals(object obj)
        {
            var ns = obj as Namespace;
            return Equals(ns);
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}
