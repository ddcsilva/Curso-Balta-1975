using System;
using Flunt.Validations;
using PagamentoContext.Domain.Entities;

namespace PagamentoContext.Domain.Contracts
{
    public class AdicionarAssinaturaContract : Contract<Assinatura>
    {
        public AdicionarAssinaturaContract(Assinatura assinatura, bool possuiAssinaturaAtiva)
        {
            Requires()
                .IsFalse(possuiAssinaturaAtiva, "Estudante.Assinaturas", "Você já tem uma assinatura ativa")
                .AreNotEquals(0, assinatura.Pagamentos.Count, "Estudante.Assinatura.Pagamentos", "Esta assinatura não possui pagamentos");
        }
    }
}