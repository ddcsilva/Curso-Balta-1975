using PagamentoContext.Domain.Contracts;
using PagamentoContext.Domain.Enums;
using PagamentoContext.Shared.ValueObjects;

namespace PagamentoContext.Domain.ValueObjects
{
    public class Documento : ValueObject
    {
        public Documento(string numero, TipoDocumentoEnum tipoDocumento)
        {
            Numero = numero;
            TipoDocumento = tipoDocumento;

            AddNotifications(new CriarDocumentoContract(this));
        }

        public string Numero { get; private set; }
        public TipoDocumentoEnum TipoDocumento { get; private set; }
    }
}
