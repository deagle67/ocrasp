using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenClassRoomsActiviteASP1
{
    [Table("Emprunts")]
    public class Emprunt
    {
        public int Id { get; set; }
        [Required]
        public Livre LivreEmprunte { get; set; }
        [Required]
        public Client ClientEmprunteur { get; set; }
    }
}