using System.Web.Mvc;
using System;

namespace AlphaLog.Web.Controllers
{
    [HandleError]
    public class HomeController : Controller
    {
        public ActionResult Index() {
            return View();
        }
    }
}
