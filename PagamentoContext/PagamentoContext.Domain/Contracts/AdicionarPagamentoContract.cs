using System;
using Flunt.Validations;
using PagamentoContext.Domain.Entities;

namespace PagamentoContext.Domain.Contracts
{
    public class AdicionarPagamentoContract : Contract<Pagamento>
    {
        public AdicionarPagamentoContract(Pagamento pagamento)
        {
            Requires()
                .IsGreaterThan(DateTime.Now, pagamento.DataPagamento, "Pagamento.DataPagamento", "A data do pagamento deve ser futura");
        }
    }
}