using PagamentoContext.Domain.Entities;

namespace PagamentoContext.Domain.Repositories
{
    public interface IEstudanteRepository
    {
        bool ExisteDocumento(string docuento);
        bool ExisteEmail(string docuento);

        void CriarAssinatura(Estudante estudante);
    }
}