using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using SharpArch.Web.NHibernate;

namespace AlphaLog.Web.Controllers
{
    public class ArmazemController:Controller
    {
        [Transaction] [AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Index()
        {
            return View();
        }
    }
}
