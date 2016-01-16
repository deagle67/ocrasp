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
            var dal = new Dal();

            var viewModel = new LivresViewModel
            {
                listeLivres = await dal.ObtenirListeDeTousLesLivresAsync(),
                qteLivres = await dal.ObtenirQteLivresAsync()
            };

            return View(viewModel);
        }

        public async Task<ActionResult> Auteurs()
        {
            var dal = new Dal();

            var viewModel = new AuteursViewModel
            {
                listeAuteurs = await dal.ObtenirListeDeTousLesAuteursAsync(),
                qteAuteurs = await dal.ObtenirQteAuteursAsync()
            };

            return View(viewModel);
        }
    }
}