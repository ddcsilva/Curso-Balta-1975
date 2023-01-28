using System;
using System.Collections.Generic;
using System.Linq;

namespace PagamentoContext.Domain.Entidades
{
    public class Assinatura
    {
        private IList<Pagamento> _pagamentos;

        public Assinatura(DateTime? dataExpiracao)
        {
            DataCriacao = DateTime.Now;
            DataUltimaAtualizacao = DateTime.Now;
            DataExpiracao = dataExpiracao;
            Ativo = true;

            _pagamentos = new List<Pagamento>();
        }

        public DateTime DataCriacao { get; private set; }
        public DateTime DataUltimaAtualizacao { get; private set; }
        public DateTime? DataExpiracao { get; private set; }
        public bool Ativo { get; private set; }
        public IReadOnlyCollection<Pagamento> Pagamentos { get => _pagamentos.ToArray(); }

        public void AdicionarPagamento(Pagamento pagamento)
        {
            _pagamentos.Add(pagamento);
        }

        public void Ativar() {
            Ativo = true;
            DataUltimaAtualizacao = DateTime.Now;
        }

        public void Inativar() {
            Ativo = false;
            DataUltimaAtualizacao = DateTime.Now;
        }
    }
}