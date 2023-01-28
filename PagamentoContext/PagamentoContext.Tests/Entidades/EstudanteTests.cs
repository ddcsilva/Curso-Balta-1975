using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PagamentoContext.Domain.Entidades;

namespace PagamentoContext.Tests
{
    [TestClass]
    public class EstudanteTests
    {
        [TestMethod]
        public void AdicionarAssinatura()
        {
            var assinatura = new Assinatura(DateTime.Now.AddDays(5));
            var estudante = new Estudante("Danilo", "Silva", "12345678912", "danilo@email.com");
            estudante.AdicionarAssinatura(assinatura);
        }
    }
}
