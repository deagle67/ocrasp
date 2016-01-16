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

            var viewModel = new AuteursViewModel
            {
                listeAuteurs = await dal.ObtenirListeDeTousLesAuteursAsync(),
                qteAuteurs = await dal.ObtenirQteAuteursAsync()
            };

            return View(viewModel);
        }
    }

    public class AuteursViewModel
    {
        public List<Auteur> listeAuteurs;
        public int qteAuteurs;
    }
}