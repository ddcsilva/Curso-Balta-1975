using PagamentoContext.Shared.ValueObjects;

namespace PagamentoContext.Domain.ValueObjects
{
    public class Email : ValueObject
    {
        public Email(string endereco)
        {
            this.endereco = endereco;
        }

        public string endereco { get; set; }
    }
}