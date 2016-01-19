using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OpenClassRoomsActiviteASP1
{
    [RoutePrefix("Rechercher")]
    public class RechercherController : Controller
    {
        [Route("Livre/{id:maxlength(20)?}")]
        public ActionResult Livre(string id = "")
        {
            using (var dal = new Dal())
            {
                var listeLivresOuAuteurs = dal.RechercherLivreOuAuteur(id);

                return View(listeLivresOuAuteurs);
            }
        }
    }
}