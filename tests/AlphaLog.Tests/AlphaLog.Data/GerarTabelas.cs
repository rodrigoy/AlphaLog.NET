using AlphaLog.Core;
using AlphaLog.Data.NHibernateMaps;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using NUnit.Framework;
using SharpArch.Data.NHibernate;
using SharpArch.Testing.NHibernate;

namespace Tests.AlphaLog.Data
{
    [TestFixture]
    public class GerarTabelas
    {
        private ISession session;
        private Configuration configuration;

        [SetUp]
        public void Setup()
        {
            string[] mappingAssemblies = RepositoryTestsHelper.GetMappingAssemblies();

            configuration = NHibernateSession.Init(new SimpleSessionStorage(),
                mappingAssemblies,
                new AutoPersistenceModelGenerator().Generate(),
                "../../../../app/AlphaLog.Web/NHibernate.config");

            session = NHibernateSession.GetDefaultSessionFactory().OpenSession();

        }
        
        [Test]
        public void Executar()
        {
            SchemaExport();
            CarregarProdutos();
            session.Close();
        }

        private void SchemaExport() 
        {
            new SchemaExport(configuration)
                .SetOutputFile(@"C:\Users\rodrigoy\Documents\Visual Studio 2008\Projects\AlphaLog\schema.sql")
                .Execute(true, true, false, session.Connection, null);

        }

        private void CarregarProdutos()
        {
            Criar(new Produto("Cesta Básica Tipo A", 28.0, 45));
            Criar(new Produto("Cesta Básica Tipo B", 23.0, 45));
            Criar(new Produto("Cesta Básica Tipo C", 19.0, 45));
            Criar(new Produto("Cesta de Natal", 12.0, 45));
        }

        private void Criar(Produto produto)
        {
            session.Persist(produto);
        }
    }
}
