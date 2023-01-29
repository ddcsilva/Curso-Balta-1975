using Microsoft.VisualStudio.TestTools.UnitTesting;
using PagamentoContext.Domain.Enums;
using PagamentoContext.Domain.ValueObjects;

namespace PagamentoContext.Tests
{
    [TestClass]
    public class DocumentoTests
    {
        // Red -> Testes que vão falhar, código todo vermelho
        // Green -> Arrume para que funcione o teste e consiga buildar
        // Refactor -> Refatore os testes

        [TestMethod]
        public void Deve_Retornar_Erro_Quando_CNPJ_Invalido()
        {
            var documento = new Documento("123", TipoDocumentoEnum.CNPJ);
            Assert.IsFalse(documento.IsValid);
        }

        [TestMethod]
        public void Deve_Retornar_Sucesso_Quando_CNPJ_Valido()
        {
            var documento = new Documento("34110468000150", TipoDocumentoEnum.CNPJ);
            Assert.IsTrue(documento.IsValid);
        }

        [TestMethod]
        public void Deve_Retornar_Erro_Quando_CPF_Invalido()
        {
            var documento = new Documento("123", TipoDocumentoEnum.CPF);
            Assert.IsFalse(documento.IsValid);
        }

        [TestMethod]
        [DataTestMethod]
        [DataRow("10271717025")]
        [DataRow("77561783000")]
        [DataRow("01537920006")]
        public void Deve_Retornar_Sucesso_Quando_CPF_Valido(string cpf)
        {
            var documento = new Documento(cpf, TipoDocumentoEnum.CPF);
            Assert.IsTrue(documento.IsValid);
        }
    }
}
