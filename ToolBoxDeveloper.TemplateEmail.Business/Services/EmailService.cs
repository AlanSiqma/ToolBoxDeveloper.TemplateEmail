using System;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using ToolBoxDeveloper.TemplateEmail.Domain.Contracts.Repositories;
using ToolBoxDeveloper.TemplateEmail.Domain.Contracts.Services;
using ToolBoxDeveloper.TemplateEmail.Domain.Dto;
using ToolBoxDeveloper.TemplateEmail.Domain.Entities;

namespace ToolBoxDeveloper.TemplateEmail.Business.Services
{
    public class EmailService : IEmailService
    {
        private readonly IEmailConfigurationRepository _emailConfigurationRepository;

        private readonly IEmailTemplateRepository _emailTemplateRepository;

        public EmailService(IEmailConfigurationRepository emailConfigurationRepository, IEmailTemplateRepository emailTemplateRepository)
        {
            this._emailConfigurationRepository = emailConfigurationRepository;
            this._emailTemplateRepository = emailTemplateRepository;
        }
        public async Task<string> SendEmailFromTemplate(SendEmailDto dto)
        {
            if (!dto.ValidateEmails())
                return $"Email  inválido";

            try
            {
                if (dto.Html.Equals(string.Empty))
                    dto.SetHtml(((await this._emailTemplateRepository.Get(x => x.Id.Equals(dto.IdTemplate) && x.IsActive.Equals(true))).FirstOrDefault()).Body);

                this.SendEmail(dto.SetContentEmail());

                return $"Mensagem enviada para {dto.To} às {DateTime.Now.ToString()}.";
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }
        }
        private void SendEmail(SendEmailDto dto)
        {
            EmailConfigurationEntity  configuration = this._emailConfigurationRepository.Get(x => x.UserName.Equals(dto.User)).Result.FirstOrDefault();

            MailMessage mailMessage = new MailMessage(from: dto.Sender, to: dto.To, subject: dto.Subject, body: dto.Html)
            {
                IsBodyHtml = true
            };

            foreach (string item in dto.CCDestinations)
                mailMessage.CC.Add(item);

            foreach (string item in dto.BCCDestinations)
                mailMessage.Bcc.Add(item);

            SmtpClient client = new SmtpClient(host: configuration.Host, port: configuration.Port)
            {
                EnableSsl = true,
            };

            client.UseDefaultCredentials = false;

            client.Credentials = new NetworkCredential(userName: configuration.UserName, password: configuration.Password);

            client.Send(mailMessage);
        }
    }

}
