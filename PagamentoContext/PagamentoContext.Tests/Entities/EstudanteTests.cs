using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PagamentoContext.Domain.Entities;
using PagamentoContext.Domain.Enums;
using PagamentoContext.Domain.ValueObjects;

namespace PagamentoContext.Tests.Entiti
{
    [TestClass]
    public class EstudanteTests
    {
        private readonly NomeCompleto _nomeCompleto;
        private readonly Email _email;
        private readonly Documento _documento;
        private readonly Endereco _endereco;
        private readonly Estudante _estudante;

        public EstudanteTests()
        {
            _nomeCompleto = new NomeCompleto("Bruce", "Wayne");
            _documento = new Documento("35111507795", TipoDocumentoEnum.CPF);
            _email = new Email("batman@dc.com");
            _endereco = new Endereco("Rua 1", "1234", "Bairro Legal", "Gotham", "SP", "BR", "13400000");
            _estudante = new Estudante(_nomeCompleto, _documento, _email);            

        }

        [TestMethod]
        public void ShouldReturnErrorWhenHadActiveSubscription()
        {
            var assinatura = new Assinatura(null);
            var pagamento = new PagamentoPayPal("12345678", DateTime.Now, DateTime.Now.AddDays(5), 10, 10, "WAYNE CORP", _documento, _endereco, _email);
            assinatura.AdicionarPagamento(pagamento);
            _estudante.AdicionarAssinatura(assinatura);
            _estudante.AdicionarAssinatura(assinatura);

            Assert.IsFalse(_estudante.IsValid);
        }

        [TestMethod]
        public void ShouldReturnErrorWhenSubscriptionHasNoPayment()
        {
            var assinatura = new Assinatura(null);
            _estudante.AdicionarAssinatura(assinatura);
            Assert.IsFalse(_estudante.IsValid);
        }

        [TestMethod]
        public void ShouldReturnSuccessWhenAddSubscription()
        {
            var assinatura = new Assinatura(null);
            var pagamento = new PagamentoPayPal("12345678", DateTime.Now, DateTime.Now.AddDays(5), 10, 10, "WAYNE CORP", _documento, _endereco, _email);
            assinatura.AdicionarPagamento(pagamento);
            _estudante.AdicionarAssinatura(assinatura);
            Assert.IsTrue(_estudante.IsValid);
        }
    }
}
