using System.Collections.Generic;
using AlphaLog.Core.DataInterfaces;
using AlphaLog.Data;
using log4net.Config;
using NUnit.Framework;
using SharpArch.Core.PersistenceSupport;
using AlphaLog.Core;
using SharpArch.Data.NHibernate;
using SharpArch.Testing.NUnit;
using SharpArch.Testing.NUnit.NHibernate;

namespace Tests.AlphaLog.Data
{
    [TestFixture]
    [Category("DB Tests")]
    public class ProdutoRepositoryTests : RepositoryTestsBase
    {

        protected override void LoadTestData()
        {
            Criar(new Produto("Cesta Básica Tipo A", 28.0, 45));
            Criar(new Produto("Cesta Básica Tipo B", 23.0, 45));
            Criar(new Produto("Cesta Básica Tipo C", 19.0, 45));
            Criar(new Produto("Cesta de Natal", 12.0, 45));
        }

        [Test]
        public void DeveListarTodosProdutos()
        {
            IList<Produto> produtos = produtoRepository.GetAll();

            produtos.ShouldNotBeNull();
            produtos.Count.ShouldEqual(4);
        }

        private void Criar(Produto produto)
        {
            produtoRepository.SaveOrUpdate(produto);
            FlushSessionAndEvict(produto);
        }

        private ITodosProdutos produtoRepository = new TodosProdutos();
    }
}
