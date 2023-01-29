namespace PagamentoContext.Domain.Services
{
    public interface IEmailService
    {
        void Enviar(string destino, string email, string assunto, string corpo);
    }
}