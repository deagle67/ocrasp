using System;
using System.Data.Entity;

namespace OpenClassRoomsActiviteASP1
{
    public class BddContext : DbContext
    {
        public DbSet<Auteur> Auteurs { get; set; }
        public DbSet<Livre> Livres { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}