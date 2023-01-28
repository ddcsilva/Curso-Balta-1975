using PagamentoContext.Domain.Contracts;
using PagamentoContext.Shared.ValueObjects;

namespace PagamentoContext.Domain.ValueObjects
{
    public class NomeCompleto : ValueObject
    {
        public NomeCompleto(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;

            AddNotifications(new CriarNomeCompletoContract(this));
        }

        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
    }
}
