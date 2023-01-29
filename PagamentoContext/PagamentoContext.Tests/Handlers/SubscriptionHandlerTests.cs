using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PagamentoContext.Domain.Commands;
using PagamentoContext.Domain.Enums;
using PagamentoContext.Domain.Handlers;
using PagamentoContext.Tests.Mocks;

namespace PaymentContext.Tests
{
    [TestClass]
    public class SubscriptionHandlerTests
    {
        // Red, Green, Refactor

        [TestMethod]
        public void ShouldReturnErrorWhenDocumentExists()
        {
            var handler = new AssinaturaHandler(new EstudanteFakeRepository(), new EmailFakeService());
            var command = new CriarAssinaturaBoletoCommand();
            command.Nome = "Bruce";
            command.Sobrenome = "Wayne";
            command.Documento = "99999999999";
            command.Email = "hello@balta.io2";
            command.CodigoBarras = "123456789";
            command.NumeroBoleto = "1234654987";
            command.NumeroPagamento = "123121";
            command.DataPagamento = DateTime.Now;
            command.DataExpiracao = DateTime.Now.AddMonths(1);
            command.Total = 60;
            command.TotalPago = 60;
            command.Pagante = "WAYNE CORP";
            command.DocumentoPagante = "12345678911";
            command.TipoDocumentoPagante = TipoDocumentoEnum.CPF;
            command.EmailPagante = "batman@dc.com";
            command.Rua = "asdas";
            command.Numero = "asdd";
            command.Vizinhanca = "asdasd";
            command.Cidade = "as";
            command.Estado = "as";
            command.Pagante = "as";
            command.Cep = "12345678";

            handler.Handle(command);
            Assert.AreEqual(false, handler.IsValid);
        }
    }
}