using System;

namespace PagamentoContext.Domain.Entidades
{
    public abstract class Pagamento
    {
        protected Pagamento(DateTime dataPagamento, DateTime dataExpiracao, decimal total, decimal totalPago, string proprietario, string documento, string endereco, string email)
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
        }

        public string Numero { get; private set; }
        public DateTime DataPagamento { get; private set; }
        public DateTime DataExpiracao { get; private set; }
        public decimal Total { get; private set; }
        public decimal TotalPago { get; private set; }
        public string Proprietario { get; private set; }
        public string Documento { get; private set; }
        public string Endereco { get; private set; }
        public string Email { get; private set; }
    }
}