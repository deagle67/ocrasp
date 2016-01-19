using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace OpenClassRoomsActiviteASP1
{
    [Table("Auteurs")]
    public class Auteur
    {
        public Auteur()
        {
            this.Livre = new HashSet<Livre>();
        }

        public int AuteurId { get; set; }
        [Required, MaxLength(80)]
        public string Nom { get; set; }
        public virtual ICollection<Livre> Livre { get; set; }
    }
}