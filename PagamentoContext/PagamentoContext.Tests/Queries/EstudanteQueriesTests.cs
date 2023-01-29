using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PagamentoContext.Domain.Entities;
using PagamentoContext.Domain.Enums;
using PagamentoContext.Domain.Queries;
using PagamentoContext.Domain.ValueObjects;

namespace PagamentoContext.Tests.Queries
{
    [TestClass]
    public class EstudanteQueriesTests
    {
        // Red, Green, Refactor
        private IList<Estudante> _estudantes;

        public EstudanteQueriesTests()
        {
            _estudantes = new List<Estudante>();
            for (var i = 0; i <= 10; i++)
            {
                _estudantes.Add(new Estudante(
                    new NomeCompleto("Aluno", i.ToString()),
                    new Documento("1111111111" + i.ToString(), TipoDocumentoEnum.CPF),
                    new Email(i.ToString() + "@balta.io")
                ));
            }
        }

        [TestMethod]
        public void ShouldReturnNullWhenDocumentNotExists()
        {
            var exp = EstudanteQueries.ObterInfomacaoEstudante("12345678911");
            var studn = _estudantes.AsQueryable().Where(exp).FirstOrDefault();

            Assert.AreEqual(null, studn);
        }

        [TestMethod]
        public void ShouldReturnStudentWhenDocumentExists()
        {
            var exp = EstudanteQueries.ObterInfomacaoEstudante("11111111111");
            var studn = _estudantes.AsQueryable().Where(exp).FirstOrDefault();

            Assert.AreNotEqual(null, studn);
        }
    }
}