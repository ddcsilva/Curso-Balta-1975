using PagamentoContext.Domain.Contracts;
using PagamentoContext.Shared.ValueObjects;

namespace PagamentoContext.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string endereco)
        {
            this.Endereco = endereco;

            AddNotifications(new CriarEmailContract(this));
        }

        public string Endereco { get; private set; }
    }
}