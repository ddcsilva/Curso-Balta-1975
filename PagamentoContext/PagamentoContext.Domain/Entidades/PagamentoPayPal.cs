using System;
using PagamentoContext.Domain.Entidades;

public class PagamentoPayPal : Pagamento
{
    public PagamentoPayPal(string codigoTransacao, 
                           DateTime dataPagamento, 
                           DateTime dataExpiracao, 
                           decimal total, 
                           decimal totalPago, 
                           string proprietario, 
                           string documento, 
                           string endereco, 
                           string email) : base (dataPagamento, 
                                                 dataExpiracao, 
                                                 total, 
                                                 totalPago, 
                                                 proprietario, 
                                                 documento, 
                                                 endereco, 
                                                 email)
    {
        CodigoTransacao = codigoTransacao;
    }

    public string CodigoTransacao { get; private set; }
}