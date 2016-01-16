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
        Task<int> ObtenirQteLivresEmpruntesAsync();

        Task<List<Livre>> ObtenirListeDeTousLesLivresAsync();
        Task<List<Auteur>> ObtenirListeDeTousLesAuteursAsync();
        Task<List<Client>> ObtenirListeDeTousLesClientsAsync();
        Task<List<Emprunt>> ObtenirListeDeTousLesEmpruntsAsync();

        void AjouterAuteur(string Nom);
        void AjouterClient(string Nom, string Email);
        void AjouterLivre(string Titre, string Auteur, DateTime DateDeParution);
    }
}
