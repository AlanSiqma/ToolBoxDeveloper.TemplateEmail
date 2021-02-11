using System;
using ToolBoxDeveloper.TemplateEmail.Domain.Entities;

namespace ToolBoxDeveloper.TemplateEmail.Domain.Dto
{
    public class EmailConfigurationDto
    {
        public EmailConfigurationDto()
        {

        }
        public EmailConfigurationDto(EmailConfigurationEntity entity)
        {
            this.Id = entity.Id;
            this.Host = entity.Host;
            this.Port = entity.Port;
            this.UserName = entity.UserName;
            this.Password = entity.Password;
        }

        public string Id { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public void GenerateId()
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
