using System;
using System.Collections.Generic;
using System.Linq;
using PagamentoContext.Domain.ValueObjects;
using PagamentoContext.Shared.Entities;

namespace PagamentoContext.Domain.Entities
{
    public class Estudante : BaseEntity
    {
        private IList<Assinatura> _assinaturas;

        public Estudante(NomeCompleto nomeCompleto, string sobrenome, Documento documento, Endereco email)
        {
            NomeCompleto = nomeCompleto;
            Documento = documento;
            Email = email;

            _assinaturas = new List<Assinatura>();

            AddNotifications(nomeCompleto, documento, email);
        }

        public NomeCompleto NomeCompleto { get; set; }
        public Documento Documento { get; private set; }
        public Endereco Email { get; private set; }
        public Endereco Endereco { get; private set; }
        public IReadOnlyCollection<Assinatura> Assinaturas { get => _assinaturas.ToArray(); }

        public void AdicionarAssinatura(Assinatura assinatura)
        {
            // Se já tiver uma assinatura ativa, cancela

            // Cancela todas as outras assinaturas e coloca esta como principal
            var possuiAssinaturaAtiva = false;

            foreach (var item in _assinaturas)
            {
                if (item.Ativo)
                    possuiAssinaturaAtiva = true;
            }

            if (possuiAssinaturaAtiva)
                AddNotification("Estudante.Assinaturas", "Você já tem uma assinatura ativa");
        }
    }
}