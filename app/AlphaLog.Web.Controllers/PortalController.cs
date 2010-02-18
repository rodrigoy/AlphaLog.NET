using System.Web.Mvc;
using AlphaLog.Core.DataInterfaces;
using SharpArch.Web.NHibernate;

namespace AlphaLog.Web.Controllers
{
    public class PortalController : Controller
    {
        private ITodasCargas todasCargas;

        public PortalController(ITodasCargas todasCargas)
        {
            this.todasCargas = todasCargas;
        }

        [Transaction] [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Index()
        {
            return View(todasCargas.GetAll());
        }

        [Transaction] [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Carga(string pallet, double pesoReal)
        {
            Session.Add("message", string.Format("Recebi do portal: pallet {0} com {1} Kg. Implemente!", pallet, pesoReal));
            //portal.entrar(pallet, pesoReal)
            return RedirectToAction("Index");
        }


    }
}
