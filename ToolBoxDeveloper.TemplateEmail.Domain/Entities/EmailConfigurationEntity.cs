using System;
using ToolBoxDeveloper.TemplateEmail.Domain.Dto;

namespace ToolBoxDeveloper.TemplateEmail.Domain.Entities
{
    public class EmailConfigurationEntity : BaseEntity
    {
        public EmailConfigurationEntity()
        {
           
        }
        public EmailConfigurationEntity(string host, int port, string userName, string password)
        {
          
            this.Host = host;
            this.Port = port;
            this.UserName = userName;
            this.Password = password;
        }

        public string Host { get; set; }
        public int Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public override string ToString()
        {
            return "EmailConfigurationEntity";
        }

        public EmailConfigurationEntity BuildDto(EmailConfigurationDto dto)
        {
            this.Host = dto.Host;
            this.Port = dto.Port;
            this.UserName = dto.UserName;
            this.Password = dto.Password;

            return this;
        }
    }
}
