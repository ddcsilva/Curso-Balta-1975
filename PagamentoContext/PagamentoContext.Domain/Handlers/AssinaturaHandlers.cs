using System;
using Flunt.Notifications;
using PagamentoContext.Domain.Commands;
using PagamentoContext.Domain.Entities;
using PagamentoContext.Domain.Enums;
using PagamentoContext.Domain.Repositories;
using PagamentoContext.Domain.Services;
using PagamentoContext.Domain.ValueObjects;
using PagamentoContext.Shared.Handlers;

namespace PagamentoContext.Domain.Handlers
{
    public class AssinaturaHandler : Notifiable<Notification>, IHandler<CriarAssinaturaBoletoCommand>
    {
        private readonly IEstudanteRepository _repository;
        private readonly IEmailService _emailService;

        public AssinaturaHandler(IEstudanteRepository repository, IEmailService emailService)
        {
            _repository = repository;
            _emailService = emailService;
        }

        public ICommandResult Handle(CriarAssinaturaBoletoCommand command)
        {
            // Fail Fast Validations
            command.Validar();
            if (!command.IsValid)
            {
                AddNotifications(command);
                return new CommandResult(false, "Não foi possível realizar sua assinatura");
            }

            // Verificar se Documento já está cadastrado
            if (_repository.ExisteDocumento(command.Documento))
                AddNotification("Documento", "Este CPF já está em uso");

            // Verificar se E-mail já está cadastrado
            if (_repository.ExisteEmail(command.Email))
                AddNotification("Email", "Este E-mail já está em uso");

            // Gerar os VOs
            var nome = new NomeCompleto(command.Nome, command.Sobrenome);
            var documento = new Documento(command.Documento, TipoDocumentoEnum.CPF);
            var email = new Email(command.Email);
            var endereco = new Endereco(command.Rua, command.Numero, command.Vizinhanca, command.Cidade, command.Estado, command.Pais, command.Cep);

            // Gerar as Entidades
            var estudante = new Estudante(nome, documento, email);
            var assinatura = new Assinatura(DateTime.Now.AddMonths(1));
            var pagamento = new PagamentoBoleto(
                command.CodigoBarras,
                command.NumeroBoleto,
                command.DataPagamento,
                command.DataExpiracao,
                command.Total,
                command.TotalPago,
                command.Pagante,
                new Documento(command.DocumentoPagante, command.TipoDocumentoPagante),
                endereco,
                email
            );

            // Agrupar as Validações
            AddNotifications(nome, documento, email, endereco, estudante, assinatura, pagamento);

            // Checar as notificações
            if (!IsValid)
                return new CommandResult(false, "Não foi possível realizar sua assinatura");

            // Salvar as Informações
            _repository.CriarAssinatura(estudante);

            // Enviar E-mail de boas vindas
            _emailService.Enviar(estudante.NomeCompleto.ToString(), estudante.Email.Endereco, "bem vindo ao curso", "Sua assinatura foi criada");

            // Retornar informações
            return new CommandResult(true, "Assinatura realizada com sucesso");
        }
    }
}