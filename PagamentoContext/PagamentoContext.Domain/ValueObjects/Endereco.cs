using PagamentoContext.Domain.Contracts;
using PagamentoContext.Shared.ValueObjects;

namespace PagamentoContext.Domain.ValueObjects
{
    public class Endereco : ValueObject
    {
        public Endereco(string rua, string numero, string vizinhanca, string cidade, string estado, string pais, string cep)
        {
            Rua = rua;
            Numero = numero;
            Vizinhanca = vizinhanca;
            Cidade = cidade;
            Estado = estado;
            Pais = pais;
            Cep = cep;

            AddNotifications(new CriarEnderecoContract(this));
        }

        public string Rua { get; private set; }
        public string Numero { get; private set; }
        public string Vizinhanca { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string Pais { get; private set; }
        public string Cep { get; private set; }
    }
}