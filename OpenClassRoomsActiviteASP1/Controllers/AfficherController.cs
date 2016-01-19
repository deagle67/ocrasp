using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;

namespace OpenClassRoomsActiviteASP1
{
    [RoutePrefix("Afficher")]
    [Route("{action=index}")]
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

                return View(viewModel);
            }
        }

        [Route("Auteurs/{id:int?}")]
        public ActionResult Auteurs(int id = 0)
        {
            using (var dal = new Dal())
            {
                AuteursViewModel viewModel;

                if (id > 0)
                {
                    ViewBag.AuteurId = id;
                    viewModel = new AuteursViewModel
                    {
                        listeAuteurs = dal.ObtenirLivresParAuteurId(id)
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

        [Route("Livre/{id:int?}")]
        public ActionResult Livre(int id = 0)
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