using System;
using PagamentoContext.Domain.Contracts;
using PagamentoContext.Domain.ValueObjects;
using PagamentoContext.Shared.Entities;

namespace PagamentoContext.Domain.Entities
{
    public abstract class Pagamento : BaseEntity
    {
        protected Pagamento(DateTime dataPagamento, DateTime dataExpiracao, decimal total, decimal totalPago, string proprietario, Documento documento, Endereco endereco, Email email)
        {
            Numero = Guid.NewGuid().ToString().Replace("-", "").Substring(0, 10).ToUpper();
            DataPagamento = dataPagamento;
            DataExpiracao = dataExpiracao;
            Total = total;
            TotalPago = totalPago;
            Proprietario = proprietario;
            Documento = documento;
            Endereco = endereco;
            Email = email;

            AddNotifications(new CriarPagamentoContract(this));
        }

        public string Numero { get; private set; }
        public DateTime DataPagamento { get; private set; }
        public DateTime DataExpiracao { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPago { get; private set; }
        public string Proprietario { get; private set; }
        public Documento Documento { get; private set; }
        public Endereco Endereco { get; private set; }
        public Email Email { get; private set; }
    }
}