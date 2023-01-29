using PagamentoContext.Domain.Services;

namespace PagamentoContext.Tests.Mocks
{
    public class EmailFakeService : IEmailService
    {
        public void Enviar(string destino, string email, string assunto, string corpo)
        {
        }
    }
}