using System;
using ToolBoxDeveloper.TemplateEmail.Domain.Entities;

namespace ToolBoxDeveloper.TemplateEmail.Domain.Dto
{
    public class EmailTemplateDto
    {

        public EmailTemplateDto()
        {

        }
        public EmailTemplateDto(EmailTemplateEntity entity)
        {
            this.Id = entity.Id;
            this.Body = entity.Body;
            this.IsActive = entity.IsActive;
        }

        public string Id { get; set; }

        public string Body { get; set; }

        public bool IsActive { get; set; }

        internal void SetBody(string body)
        {
            this.Body = body;
        }

        public void GenerateId()
        {
            this.Id = Guid.NewGuid().ToString();
        }
    }
}
