using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace OpenClassRoomsActiviteASP1
{
    [Table("Livres")]
    public class Livre
    {
        [Key]
        public string Email { get; set; }
        [Required, MaxLength(80)]
        public string Titre { get; set; }
        [Required]
        public DateTime DateDeParution { get; set; }
        [Required]
        public virtual Auteur Nom { get; set; }
        public virtual Client Client { get; set; }
    }
}