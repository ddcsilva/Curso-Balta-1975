using PagamentoContext.Domain.Entities;
using PagamentoContext.Domain.Repositories;

namespace PagamentoContext.Tests.Mocks
{
    public class EstudanteFakeRepository : IEstudanteRepository
    {
        public void CriarAssinatura(Estudante estudante)
        {

        }

        public bool ExisteDocumento(string documento)
        {
            if (documento == "99999999999")
                return true;

            return false;
        }

        public bool ExisteEmail(string email)
        {
            if (email == "hello@balta.io")
                return true;

            return false;
        }
    }
}