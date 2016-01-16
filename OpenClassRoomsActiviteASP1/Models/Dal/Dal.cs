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
    }
}