﻿using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace OpenClassRoomsActiviteASP1
{
    [Table("Clients")]
    public class Client
    {
        public Client()
        {
            this.Livres = new HashSet<Livre>();
        }
        [Key, Required]
        public string Email { get; set; }
        [Required, MaxLength(80)]
        public string Nom { get; set; }
        public ICollection<Livre> Livres { get; set; }
    }
}