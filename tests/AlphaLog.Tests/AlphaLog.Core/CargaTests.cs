using NUnit.Framework;
using AlphaLog.Core;

namespace Tests.AlphaLog.Core
{
    [TestFixture]
    public class CargaTests
    {
        [Test]
        public void DeveCalcularPeso ()
        {
            var produto = new Produto("Teste", 100, 30);
            var carga = new Carga("1234", produto, 50);

            Assert.AreEqual(carga.PesoCalculado, 5000D);

        }
    }
}
