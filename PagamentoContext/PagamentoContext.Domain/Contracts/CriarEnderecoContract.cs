using Flunt.Validations;
using PagamentoContext.Domain.ValueObjects;

namespace PagamentoContext.Domain.Contracts
{
    public class CriarEnderecoContract : Contract<Endereco>
    {
        public CriarEnderecoContract(Endereco endereco)
        {
            Requires()
                .IsGreaterOrEqualsThan(endereco.Rua, 3, "Endereco.Rua", "Rua deve conter pelo menos 3 caracteres")
                .IsGreaterOrEqualsThan(endereco.Cidade, 3, "Endereco.Cidade", "Cidade deve conter pelo menos 3 caracteres")
                .IsGreaterOrEqualsThan(endereco.Pais, 3, "Endereco.Pais", "Pais deve conter pelo menos 3 caracteres")
                .IsGreaterOrEqualsThan(endereco.Cep, 3, "Endereco.Cep", "Cep deve conter pelo menos 3 caracteres");
        }
    }
}