using System.Collections;
using System.Collections.Generic;
using MvcContrib.TestHelper;
using System.Web.Mvc;
using AlphaLog.Core;
using AlphaLog.Core.DataInterfaces;
using AlphaLog.Web.Controllers;
using NUnit.Framework;
using Rhino.Mocks;
using SharpArch.Testing.NUnit;

namespace Tests.AlphaLog.Web.Controllers
{
    [TestFixture]
    public class CargaControllerTest
    {
        private CargaController controller;
        
        [Test]
        public void DeveMontarTela()
        {
            controller = new CargaController(GetTodosProdutosMock(), GetTodasCargasMock());
            ViewResult result = controller.Index().AssertViewRendered().ForView("");
            
            result.ViewData.ShouldNotBeNull();
            (((IDictionary) result.ViewData.Model)["produtos"]).ShouldNotBeNull();
            (((IDictionary)result.ViewData.Model)["padraoQuant"]).ShouldNotBeNull();
        }

        [Test]
        public void DeveCriarCarga()
        {
            controller = new CargaController(GetTodosProdutosMock(), GetTodasCargasMock());
            RedirectToRouteResult result = controller.Criar("xxx", 1, 30).AssertActionRedirect().ToAction("Index");
        }

        private ITodasCargas GetTodasCargasMock()
        {
            var repository = MockRepository.GenerateMock<ITodasCargas>();
            repository.Expect(r => r.SaveOrUpdate(null)).IgnoreArguments().Return(GetCarga());
            return repository;
        }
        
        private ITodosProdutos GetTodosProdutosMock()
        {
            var repository = MockRepository.GenerateMock<ITodosProdutos>();
            repository.Expect(r => r.Get(1)).IgnoreArguments().Return(GetProduto());
            repository.Expect(r => r.GetAll()).Return(getProdutos());
            return repository;
        }

        private IList<Produto> getProdutos()
        {
            return new List<Produto>
                       {
                           new Produto("Produto 1", 10, 45),
                           new Produto("Produto 2", 20, 35)
                       };
        }

        private Carga GetCarga()
        {
            return new Carga("xxx", GetProduto(), 10);
        }

        

        private Produto GetProduto()
        {
            return new Produto("Produto 1", 10.0, 45);
        }


    }
}
