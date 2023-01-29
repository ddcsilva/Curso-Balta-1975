using System;
using PagamentoContext.Domain.Entities;
using PagamentoContext.Domain.ValueObjects;

public class PagamentoPayPal : Pagamento
{
    public PagamentoPayPal(string codigoTransacao, 
                           DateTime dataPagamento, 
                           DateTime dataExpiracao, 
                           decimal total, 
                           decimal totalPago, 
                           string proprietario, 
                           Documento documento, 
                           Endereco endereco, 
                           Email email) : base (dataPagamento, 
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