using PagamentoContext.Domain.Entities;

namespace PagamentoContext.Domain.Repositories
{
    public interface IEstudanteRepository
    {
        bool DocumentoExiste(string docuento);
        bool EmailExiste(string docuento);

        void CriarAssinatura(Estudante estudante);
    }
}