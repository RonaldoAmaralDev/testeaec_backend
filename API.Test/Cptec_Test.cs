using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;
using SDKAPI;
using System.Threading.Tasks;
using System.Linq;

namespace API_Test
{
    [TestClass]
    public class Cptec_Test
    {

        [TestMethod]
        public async Task Test01()
        {
            using var api = new API();
            var cidadesResponse = await api.CptecCidade();

            Assert.IsNotNull(cidadesResponse);
            Assert.IsTrue(cidadesResponse.Cidades.Any());
        }

        [TestMethod]
        public async Task Test02()
        {
            using var api = new API();
            var cidadesResponse = await api.CptecCidade("rio");

            Assert.IsNotNull(cidadesResponse);
            Assert.IsTrue(cidadesResponse.Cidades.Any());
        }

        [TestMethod]
        public async Task Test03()
        {
            var cidadeCodigoRj = 241;
            using var api = new API();
            var climaResponse = await api.CptecClimaPrevisao(cidadeCodigoRj);

            Assert.IsNotNull(climaResponse);
            Assert.IsTrue(climaResponse.Cidade.Contains("rio", StringComparison.InvariantCultureIgnoreCase));
        }

        [TestMethod]
        public async Task Test04()
        {
            var cidadeCodigoRioPretoMg = 4413;
            using var api = new API();
            var climaResponse = await api.CptecClimaPrevisao(cidadeCodigoRioPretoMg, 5);

            Assert.IsNotNull(climaResponse);
            Assert.IsTrue(climaResponse.Cidade.Contains("rio", StringComparison.InvariantCultureIgnoreCase));
        }

        [TestMethod]
        public async Task Test05()
        {
            using var api = new API();
            var climaResponse = await api.CptecClimaCapital();

            Assert.IsNotNull(climaResponse);
            Assert.IsTrue(climaResponse.Climas.Any());
        }

        [TestMethod]
        public async Task Test06()
        {
            var codigo = "SBBR";

            using var api = new API();
            var climaResponse = await api.CptecClimaAeroporto(codigo);

            Assert.IsNotNull(climaResponse);
            Assert.IsTrue(climaResponse.Climas.Any());
            Assert.IsTrue(climaResponse.Climas.Count() == 1);
        }

        [TestMethod]
        public async Task Test07()
        {
            var cidadeCodigoRj = 241;

            using var api = new API();
            var climaResponse = await api.CptecClimaPrevisao(cidadeCodigoRj);

            Assert.IsNotNull(climaResponse);
            Assert.IsTrue(climaResponse.Cidade.Contains("rio", StringComparison.InvariantCultureIgnoreCase));
            Assert.IsTrue(climaResponse.Clima.Any());
        }

        [TestMethod]
        public async Task Test08()
        {
            var cidadeCodigoRj = 241;
            var dias = 2;

            using var api = new API();
            var climaResponse = await api.CptecClimaPrevisao(cidadeCodigoRj, dias);

            Assert.IsNotNull(climaResponse);
            Assert.IsTrue(climaResponse.Cidade.Contains("rio", StringComparison.InvariantCultureIgnoreCase));
            Assert.IsTrue(climaResponse.Clima.Any());
            Assert.AreEqual(dias, climaResponse.Clima.Count());
        }

        [TestMethod]
        public async Task Test09()
        {
            var cidadeCodigoRj = 241;

            using var api = new API();
            var climaResponse = await api.CptecOndas(cidadeCodigoRj);

            Assert.IsNotNull(climaResponse);
            Assert.IsNotNull(climaResponse.Cidade.Contains("rio", StringComparison.InvariantCultureIgnoreCase));
        }

        [TestMethod]
        public async Task Test10()
        {
            var cidadeCodigoRj = 241;
            var dias = 2;

            using var api = new API();
            var climaResponse = await api.CptecOndas(cidadeCodigoRj, dias);

            Assert.IsNotNull(climaResponse);
            Assert.IsNotNull(climaResponse.Cidade.Contains("rio", StringComparison.InvariantCultureIgnoreCase));
            Assert.IsTrue(climaResponse.Ondas.Any());
            Assert.AreEqual(dias, climaResponse.Ondas.Count());
        }


    }
}
