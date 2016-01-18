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
        public async Task<ActionResult> Index()
        {
            using (var dal = new Dal())
            {
                var viewModel = new LivresViewModel
                {
                    listeLivres = await dal.ObtenirListeDeTousLesLivresAsync(),
                    qteLivres = await dal.ObtenirQteLivresAsync()
                };

                if (viewModel.qteLivres == 0)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        dal.AjouterLivre("Titre" + i, "Auteur" + i, DateTime.Now, null, "truc@truc.com" + i);
                        dal.AjouterClient("Client" + i, "Email" + i, null);
                        dal.AjouterAuteur("Auteur" + i);
                    }
                }

                return View(viewModel);
            }
        }

        public async Task<ActionResult> Auteurs()
        {
            using (var dal = new Dal())
            {
                var viewModel = new AuteursViewModel
                {
                    listeAuteurs = await dal.ObtenirListeDeTousLesAuteursAsync(),
                    qteAuteurs = await dal.ObtenirQteAuteursAsync()
                };

                return View(viewModel);
            }
        }
    }
}