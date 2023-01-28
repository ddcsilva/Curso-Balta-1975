using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PagamentoContext.Domain.Entities;
using PagamentoContext.Domain.ValueObjects;

namespace PagamentoContext.Tests.Entiti
{
    [TestClass]
    public class EstudanteTests
    {
        [TestMethod]
        public void AdicionarAssinatura()
        {
            // var assinatura = new Assinatura(DateTime.Now.AddDays(5));
            // var estudante = new Estudante("Danilo", "Silva", "12345678912", "danilo@email.com");
            // estudante.AdicionarAssinatura(assinatura);

            var nomeCompleto = new NomeCompleto("Danilo", "Silva");
            foreach (var not in nomeCompleto.Notifications)
            {
                System.Console.WriteLine(not.Message);
            }
        }
    }
}
