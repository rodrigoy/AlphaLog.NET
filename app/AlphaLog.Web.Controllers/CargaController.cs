using System;
using System.Collections.Generic;
using System.Web.Mvc;
using AlphaLog.Core;
using AlphaLog.Core.DataInterfaces;
using SharpArch.Web.NHibernate;

namespace AlphaLog.Web.Controllers
{
    public class CargaController : Controller
    {
        private Dictionary<string, SelectList> returns = new Dictionary<string, SelectList>();

        private ITodosProdutos todosProdutos;
        private ITodasCargas todasCargas;

        public CargaController(ITodosProdutos todosProdutos, ITodasCargas todasCargas)
        {
            this.todosProdutos = todosProdutos;
            this.todasCargas = todasCargas;
        }

        [Transaction][AcceptVerbs(HttpVerbs.Get)]
        public ActionResult Index()
        {
            returns.Add("produtos", new SelectList(this.todosProdutos.GetAll(), "Id", "Nome"));
            returns.Add("padraoQuant", new SelectList(new List<String>() { "16", "30" }));
            return View(returns);
        }
        
        [Transaction][AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Criar(string pallet, int produtoId, long quantidade)
        {
            var produto = todosProdutos.Get(produtoId);
            todasCargas.SaveOrUpdate(new Carga(pallet, produto, quantidade));
            
            // Session não é Test Friendly
            if (Session != null) Session.Add("message","Recebi: Pallet:" + pallet + ", produto: " + produtoId + ", quantidade: " + quantidade);

            return RedirectToAction("Index");
        }
    }
}
