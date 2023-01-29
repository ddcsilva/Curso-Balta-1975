using Microsoft.VisualStudio.TestTools.UnitTesting;
using PagamentoContext.Domain.Commands;
using PagamentoContext.Domain.Enums;
using PagamentoContext.Domain.ValueObjects;

namespace PagamentoContext.Tests.Commands
{
    [TestClass]
    public class CriarAssinaturaCartaoCreditoCommandTests
    {
        // Red -> Testes que vão falhar, código todo vermelho
        // Green -> Arrume para que funcione o teste e consiga buildar
        // Refactor -> Refatore os testes

        [TestMethod]
        public void Deve_Retornar_Erro_Quando_Nome_Invalido()
        {
            var command = new CriarAssinaturaCartaoCreditoCommand();
            command.Nome = "";

            command.Validar();
            Assert.AreEqual(false, command.IsValid);
        }
    }
}
