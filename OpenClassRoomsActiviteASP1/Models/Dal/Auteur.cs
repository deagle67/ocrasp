using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenClassRoomsActiviteASP1
{
    [Table("Auteurs")]
    public class Auteur
    {
        public int Id { get; set; }
        [Required, MaxLength(80)]
        public string Nom { get; set; }
    }
}