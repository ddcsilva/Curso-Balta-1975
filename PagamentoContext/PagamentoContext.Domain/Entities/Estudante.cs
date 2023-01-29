using System;
using System.Collections.Generic;
using System.Linq;
using PagamentoContext.Domain.Contracts;
using PagamentoContext.Domain.ValueObjects;
using PagamentoContext.Shared.Entities;

namespace PagamentoContext.Domain.Entities
{
    public class Estudante : BaseEntity
    {
        private IList<Assinatura> _assinaturas;

        public Estudante(NomeCompleto nomeCompleto, Documento documento, Email email)
        {
            NomeCompleto = nomeCompleto;
            Documento = documento;
            Email = email;

            _assinaturas = new List<Assinatura>();

            AddNotifications(nomeCompleto, documento, email);
        }

        public NomeCompleto NomeCompleto { get; set; }
        public Documento Documento { get; private set; }
        public Email Email { get; private set; }
        public Endereco Endereco { get; private set; }
        public IReadOnlyCollection<Assinatura> Assinaturas { get => _assinaturas.ToArray(); }

        public void AdicionarAssinatura(Assinatura assinatura)
        {
            var possuiAssinaturaAtiva = false;

            foreach (var item in _assinaturas)
            {
                if (item.Ativo)
                    possuiAssinaturaAtiva = true;
            }

            AddNotifications(new AdicionarAssinaturaContract(assinatura, possuiAssinaturaAtiva));

            if (IsValid)
                _assinaturas.Add(assinatura);
        }
    }
}