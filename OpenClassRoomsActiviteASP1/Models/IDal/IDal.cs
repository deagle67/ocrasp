using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClassRoomsActiviteASP1
{
    interface IDal : IDisposable
    {
        Task<int> ObtenirQteClientsAsync();
        Task<int> ObtenirQteLivresAsync();
        Task<int> ObtenirQteAuteursAsync();

        Task<List<Livre>> ObtenirListeDeTousLesLivresAsync();
        Task<List<Auteur>> ObtenirListeDeTousLesAuteursAsync();
        Task<List<Client>> ObtenirListeDeTousLesClientsAsync();

        void AjouterAuteur(string Nom);
        void AjouterClient(string nom, string email, Livre livre);
        void AjouterLivre(string titre, string auteur, DateTime dateDeParution, Client client, string email);
    }
}
