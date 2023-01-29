using System;
using PagamentoContext.Domain.Enums;
using PagamentoContext.Domain.ValueObjects;

namespace PagamentoContext.Domain.Commands
{
    public class CriarAssinaturaBoletoCommand
    {
        public CriarAssinaturaBoletoCommand()
        {

        }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Documento { get; set; }
        public string Email { get; set; }
        public string NumeroBoleto { get; set; }
        public string CodigoBarras { get; set; }
        public string NumeroPagamento { get; set; }
        public DateTime DataPagamento { get; set; }
        public DateTime DataExpiracao { get; set; }
        public decimal Total { get; set; }
        public decimal TotalPago { get; set; }
        public string Pagante { get; set; }
        public string DocumentoPagante { get; set; }
        public TipoDocumentoEnum TipoDocumentoPagante { get; set; }
        public Email EmailPagante { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Vizinhanca { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string Cep { get; set; }
    }
}