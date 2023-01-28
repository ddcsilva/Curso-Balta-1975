using Flunt.Validations;
using PagamentoContext.Domain.ValueObjects;

namespace PagamentoContext.Domain.Contracts
{
    public class CriarNomeCompletoContract : Contract<NomeCompleto>
    {
        public CriarNomeCompletoContract(NomeCompleto nomeCompleto)
        {
            Requires()
                .IsGreaterOrEqualsThan(nomeCompleto.Nome, 3, "NomeCompleto.Nome", "Nome deve conter pelo menos 3 caracteres")
                .IsGreaterOrEqualsThan(nomeCompleto.Sobrenome, 3, "NomeCompleto.Sobrenome", "Sobrenome deve conter pelo menos 3 caracteres")
                .IsLowerOrEqualsThan(nomeCompleto.Nome, 40, "NomeCompleto.Nome", "Nome deve conter até 40 caracteres");
        }
    }
}