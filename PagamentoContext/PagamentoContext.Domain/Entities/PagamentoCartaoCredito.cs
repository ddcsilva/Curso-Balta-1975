using System;
using PagamentoContext.Domain.Entities;
using PagamentoContext.Domain.ValueObjects;

public class PagamentoCartaoCredito : Pagamento
{
    public PagamentoCartaoCredito(string nomeTitularCartao, 
                                  string numeroCartao, 
                                  string numeroUltimaTransacao, 
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
        NomeTitularCartao = nomeTitularCartao;
        NumeroCartao = numeroCartao;
        NumeroUltimaTransacao = numeroUltimaTransacao;
    }

    public string NomeTitularCartao { get; private set; }
    public string NumeroCartao { get; private set; }
    public string NumeroUltimaTransacao { get; private set; }
}