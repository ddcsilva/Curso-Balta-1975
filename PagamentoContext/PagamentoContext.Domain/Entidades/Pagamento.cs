using System;

namespace PagamentoContext.Domain.Entidades
{
    public abstract class Pagamento
    {
        public string Numero { get; set; }
        public DateTime DataPagamento { get; set; }
        public DateTime DataExpiracao { get; set; }
        public decimal Total { get; set; }
        public decimal TotalPago { get; set; }
        public string Proprietario { get; set; }
        public string Documento { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
    }

    public class PagamentoBoleto : Pagamento
    {
        public string NumeroBoleto { get; set; }
        public string CodigoBarras { get; set; }
    }

    public class PagamentoCartaoCredito : Pagamento
    {
        public string NomeTitularCartao { get; set; }
        public string NumeroCartao { get; set; }
        public string NumeroUltimaTransacao { get; set; }
    }

    public class PagamentoPayPal : Pagamento
    {
        public string CodigoTransacao { get; set; }
    }
}