using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace OpenClassRoomsActiviteASP1
{
    [Table("Livres")]
    public class Livre
    {
        public int LivreId { get; set; }
        [Required, MaxLength(80)]
        public string Titre { get; set; }
        [Required]
        public System.DateTime DateDeParution { get; set; }
        public int AuteurAuteurId { get; set; }
        public string ClientEmail { get; set; }

        public virtual Auteur Auteur { get; set; }
        public virtual Client Client { get; set; }
    }
}