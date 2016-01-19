using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;

namespace OpenClassRoomsActiviteASP1
{
    public class AfficherController : Controller
    {
        public ActionResult Index()
        {
            using (var dal = new Dal())
            {

                var viewModel = new LivresViewModel
                {                   
                    listeLivres = dal.ObtenirListeDeTousLesLivres(),
                    qteLivres = dal.ObtenirQteLivres()
                };

                /*if (viewModel.qteLivres == 0)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        dal.AjouterLivre("Titre" + i, "Auteur" + i, DateTime.Now, null, "truc@truc.com" + i);
                        dal.AjouterClient("Client" + i, "Email" + i);
                        dal.AjouterAuteur("Auteur" + i);
                    }
                }*/

                return View(viewModel);
            }
        }

        public ActionResult Auteurs(int? id)
        {
            using (var dal = new Dal())
            {
                AuteursViewModel viewModel;

                if (id.HasValue)
                {
                    int localId = id.Value;
                    ViewBag.AuteurId = localId;
                    viewModel = new AuteursViewModel
                    {
                        listeAuteurs = dal.ObtenirLivresParAuteurId(localId)
                    };
                }
                else
                {
                    viewModel = new AuteursViewModel
                    {
                        listeAuteurs = dal.ObtenirListeDeTousLesAuteurs(),
                    };
                }

                return View(viewModel);
            }
        }

        public ActionResult Livre(int id)
        {
            using (var dal = new Dal())
            {
                LivreParId viewModel = null;
                var livreParId = dal.ObtenirLivreParLivreId(id);

                if (livreParId != null)
                {
                    viewModel = new LivreParId
                    {
                        Titre = livreParId.Titre != null ? livreParId.Titre : null,
                        DateDeParution = livreParId.DateDeParution != null ? livreParId.DateDeParution : DateTime.MinValue,
                        Emprunteur = livreParId.Client != null ? livreParId.Client.Nom : null
                    };
                }
                return View(viewModel);
            }
        }
    }
}