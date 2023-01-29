using Flunt.Validations;
using PagamentoContext.Domain.Entities;

namespace PagamentoContext.Domain.Contracts
{
    public class CriarPagamentoContract : Contract<Pagamento>
    {
        public CriarPagamentoContract(Pagamento pagamento)
        {
            Requires()
                .IsLowerOrEqualsThan(0, pagamento.Total, "Pagamento.Total", "O total não pode ser zero")
                .IsGreaterOrEqualsThan(pagamento.Total, pagamento.TotalPago, "Pagamento.TotalPago", "O valor pago é menor que o valor do pagamento");
        }
    }
}