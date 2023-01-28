using Flunt.Validations;
using PagamentoContext.Domain.ValueObjects;

namespace PagamentoContext.Domain.Contracts
{
    public class CriarEmailContract : Contract<Email>
    {
        public CriarEmailContract(Email email)
        {
            Requires()
                .IsEmail(email.Endereco, "Email.Endereco", "E-mail inválido");
        }
    }
}