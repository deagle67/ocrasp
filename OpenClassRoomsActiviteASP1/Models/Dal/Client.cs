using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenClassRoomsActiviteASP1
{
    [Table("Clients")]
    public class Client
    {
        [Key, Required]
        public string Email { get; set; }
        [Required, MaxLength(80)]
        public string Nom { get; set; }
    }
}