using System;
using System.Collections.Generic;
using System.Linq;

namespace PagamentoContext.Domain.Entidades
{
    public class Estudante
    {
        private IList<Assinatura> _assinaturas;

        public Estudante(string nome, string sobrenome, string documento, string email)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Documento = documento;
            Email = email;

            _assinaturas = new List<Assinatura>();

            if (nome.Length == 0)
            {
                throw new Exception("Nome inválido!");
            }
        }

        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public string Documento { get; private set; }
        public string Email { get; private set; }
        public string Endereco { get; private set; }
        public IReadOnlyCollection<Assinatura> Assinaturas { get => _assinaturas.ToArray(); }

        public void AdicionarAssinatura(Assinatura assinatura)
        {
            // Se já tiver uma assinatura ativa, cancela

            // Cancela todas as outras assinaturas e coloca esta como principal
            foreach (var item in Assinaturas)
            {
                item.Ativar();
            }

            _assinaturas.Add(assinatura);
        }
    }
}