using PagamentoContext.Domain.Enums;
using PagamentoContext.Shared.ValueObjects;

namespace PagamentoContext.Domain.ValueObjects
{
    public class Documento : ValueObject
    {
        public Documento(string nome, TipoDocumentoEnum tipoDocumento)
        {
            Nome = nome;
            TipoDocumento = tipoDocumento;
        }

        public string Nome { get; private set; }
        public TipoDocumentoEnum TipoDocumento { get; private set; }
    }
}
