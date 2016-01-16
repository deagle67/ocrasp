using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace OpenClassRoomsActiviteASP1
{
    [Table("Livres")]
    public class Livre
    {
        public int Id { get; set; }
        [Required, MaxLength(80)]
        public string Titre { get; set; }
        [Required]
        public DateTime DateDeParution { get; set; }
        [Required]
        public Auteur AuteurDuLivre { get; set; }
    }
}