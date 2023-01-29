using System;
using Flunt.Notifications;
using Flunt.Validations;
using PagamentoContext.Domain.Enums;
using PagamentoContext.Domain.ValueObjects;
using PagamentoContext.Shared.Commands;

namespace PagamentoContext.Domain.Commands
{
    public class CriarAssinaturaCartaoCreditoCommand : Notifiable<Notification>, ICommand
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Documento { get; set; }
        public string Email { get; set; }
        public string NomeTitularCartao { get; set; }
        public string NumeroCartao { get; set; }
        public string NumeroUltimaTransacao { get; set; }
        public string NumeroPagamento { get; set; }
        public DateTime DataPagamento { get; set; }
        public DateTime DataExpiracao { get; set; }
        public decimal Total { get; set; }
        public decimal TotalPago { get; set; }
        public string Pagante { get; set; }
        public string DocumentoPagante { get; set; }
        public TipoDocumentoEnum TipoDocumentoPagante { get; set; }
        public string EmailPagante { get; set; }
        public string Rua { get; set; }
        public string Numero { get; set; }
        public string Vizinhanca { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public string Cep { get; set; }

        public void Validar()
        {
            AddNotifications(new Contract<CriarAssinaturaCartaoCreditoCommand>()
                .Requires()
                .IsGreaterOrEqualsThan(Nome, 3, "Nome", "Nome deve conter pelo menos 3 caracteres")
                .IsGreaterOrEqualsThan(Sobrenome, 3, "Sobrenome", "Sobrenome deve conter pelo menos 3 caracteres")
                .IsLowerOrEqualsThan(Nome, 40, "Nome", "Nome deve conter até 40 caracteres")            
            );
        }
    }
}