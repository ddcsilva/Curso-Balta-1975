using System;
using System.Linq.Expressions;
using PagamentoContext.Domain.Entities;

namespace PagamentoContext.Domain.Queries
{
    public static class EstudanteQueries
    {
        public static Expression<Func<Estudante, bool>> ObterInfomacaoEstudante(string documento)
        {
            return x => x.Documento.Numero == documento;
        }
    }
}