using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;

namespace OpenClassRoomsActiviteASP1
{
    public class Dal : IDal
    {
        private BddContext bdd;

        public Dal()
        {
            bdd = new BddContext();
        }

        public void Dispose()
        {
            if(bdd != null)
            {
                bdd.Dispose();
            }        
        }

        public async Task<List<Auteur>> ObtenirListeDeTousLesAuteursAsync()
        {
            var listeAuteurs = await bdd.Auteurs.ToListAsync();
            return listeAuteurs;
        }

        public async Task<List<Client>> ObtenirListeDeTousLesClientsAsync()
        {
            var listeClients = await bdd.Clients.ToListAsync();
            return listeClients;
        }

        public async Task<List<Emprunt>> ObtenirListeDeTousLesEmpruntsAsync()
        {
            var listeEmprunts = await bdd.Emprunts.ToListAsync();
            return listeEmprunts;
        }

        public async Task<List<Livre>> ObtenirListeDeTousLesLivresAsync()
        {
            var listeLivres = await bdd.Livres.ToListAsync();
            return listeLivres;
        }

        public async Task<int> ObtenirQteAuteursAsync()
        {
            var qteAuteurs = await bdd.Auteurs.CountAsync();
            return qteAuteurs;
        }

        public async Task<int> ObtenirQteClientsAsync()
        {
            var qteClients = await bdd.Clients.CountAsync();
            return qteClients;
        }

        public async Task<int> ObtenirQteLivresAsync()
        {
            var qteLivres = await bdd.Livres.CountAsync();
            return qteLivres;
        }

        public async Task<int> ObtenirQteLivresEmpruntesAsync()
        {
            var qteLivresEmpruntes = await bdd.Emprunts.CountAsync();
            return qteLivresEmpruntes;
        }

        public void AjouterAuteur(string Nom)
        {
            bdd.Auteurs.Add(new Auteur { Nom = Nom } );
            bdd.SaveChanges();
        }

        public void AjouterClient(string Nom, string Email)
        {
            bdd.Clients.Add(new Client { Nom = Nom, Email = Email });
            bdd.SaveChanges();
        }

        public void AjouterLivre(string Titre, string Auteur, DateTime DateDeParution)
        {
            Auteur auteur = new Auteur { Nom = Auteur };
            bdd.Livres.Add(new Livre { Titre = Titre, AuteurDuLivre = auteur, DateDeParution = DateDeParution });
            bdd.SaveChanges();
        }
    }
}