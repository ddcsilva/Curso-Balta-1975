using Flunt.Validations;
using PagamentoContext.Domain.Enums;
using PagamentoContext.Domain.ValueObjects;

namespace PagamentoContext.Domain.Contracts
{
    public class CriarDocumentoContract : Contract<Documento>
    {
        public CriarDocumentoContract(Documento documento)
        {
            Requires()
                .IsTrue(Validate(documento), "Documento.Numero", "Documento inválido");
        }

        private bool Validate(Documento documento)
        {
            if (documento.TipoDocumento == TipoDocumentoEnum.CNPJ && documento.Numero.Length == 14)
                return true;

            if (documento.TipoDocumento == TipoDocumentoEnum.CNPJ && documento.Numero.Length == 11)
                return true;
            
            return false;
        }
    }
}