using PagamentoContext.Shared.ValueObjects;

namespace PagamentoContext.Domain.ValueObjects
{
    public class NomeCompleto : ValueObject
    {
        public NomeCompleto(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;

            if (string.IsNullOrEmpty(Nome)) 
                AddNotification("NomeCompleto.Nome", "Nome inválido");
        }

        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
    }
}
