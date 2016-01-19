using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClassRoomsActiviteASP1
{
    interface IDal : IDisposable
    {
        int ObtenirQteClients();
        int ObtenirQteLivres();
        int ObtenirQteAuteurs();

        List<Livre> ObtenirListeDeTousLesLivres();
        List<string> ObtenirListeDeTousLesAuteurs();
        List<Client> ObtenirListeDeTousLesClients();

        List<string> ObtenirLivresParAuteurId(int id);
        Livre ObtenirLivreParLivreId(int id);

        void AjouterAuteur(string Nom);
        void AjouterClient(string nom, string email);
        void AjouterLivre(string titre, string auteur, DateTime dateDeParution, Client client, string email);
    }
}
