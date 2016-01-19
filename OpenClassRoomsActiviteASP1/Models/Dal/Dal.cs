using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Linq;

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

        public List<string> ObtenirListeDeTousLesAuteurs()
        {
            var listeAuteurs = bdd.Auteurs.Select(i => i.Nom).ToList();
            return listeAuteurs;
        }

        public List<Client> ObtenirListeDeTousLesClients()
        {
            var listeClients = bdd.Clients.Include(i => i.Livre).ToList();
            return listeClients;
        }

        public List<Livre> ObtenirListeDeTousLesLivres()
        {
            var listeLivres = bdd.Livres.Include(i => i.Auteur).ToList();
            return listeLivres;
        }

        public int ObtenirQteAuteurs()
        {
            var qteAuteurs = bdd.Auteurs.Count();
            return qteAuteurs;
        }

        public int ObtenirQteClients()
        {
            var qteClients = bdd.Clients.Count();
            return qteClients;
        }

        public int ObtenirQteLivres()
        {
            var qteLivres = bdd.Livres.Count();
            return qteLivres;
        }

        public void AjouterAuteur(string Nom)
        {
            bdd.Auteurs.Add(new Auteur { Nom = Nom } );
            bdd.SaveChanges();
        }

        public void AjouterClient(string nom, string email)
        {
            bdd.Clients.Add(new Client { Nom = nom, Email = email, Livre = null });
            bdd.SaveChanges();
        }

        public void AjouterLivre(string titre, string auteur, DateTime dateDeParution, Client client, string email)
        {
            Auteur newAuteur = new Auteur { Nom = auteur };
            bdd.Livres.Add(new Livre { Auteur = newAuteur, Client = null, Titre = titre, DateDeParution = dateDeParution, ClientEmail = null});
            bdd.SaveChanges();
        }

        public List<string> ObtenirLivresParAuteurId(int id)
        {
            var listeLivres = bdd.Livres.Where(i => i.Auteur.AuteurId.Equals(id)).Select(i => i.Titre).ToList();
            return listeLivres;
        }

        public Livre ObtenirLivreParLivreId(int id)
        {
            var livreParLivreId = bdd.Livres.Include(i => i.Client).Where(i => i.LivreId.Equals(id)).FirstOrDefault();
            return livreParLivreId;
        }
    }
}