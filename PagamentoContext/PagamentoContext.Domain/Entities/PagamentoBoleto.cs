using System;
using PagamentoContext.Domain.Entities;
using PagamentoContext.Domain.ValueObjects;

public class PagamentoBoleto : Pagamento
{
    public PagamentoBoleto(string numeroBoleto, 
                           string codigoBarras, 
                           DateTime dataPagamento, 
                           DateTime dataExpiracao, 
                           decimal total, 
                           decimal totalPago, 
                           string proprietario, 
                           Documento documento, 
                           Endereco endereco, 
                           Endereco email) : base (dataPagamento, 
                                                 dataExpiracao, 
                                                 total, 
                                                 totalPago, 
                                                 proprietario, 
                                                 documento, 
                                                 endereco, 
                                                 email)
    {
        NumeroBoleto = numeroBoleto;
        CodigoBarras = codigoBarras;
    }

    public string NumeroBoleto { get; private set; }
    public string CodigoBarras { get; private set; }
}