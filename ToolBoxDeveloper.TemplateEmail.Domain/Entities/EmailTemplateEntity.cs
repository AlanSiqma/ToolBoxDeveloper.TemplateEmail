using System;
using ToolBoxDeveloper.TemplateEmail.Domain.Dto;

namespace ToolBoxDeveloper.TemplateEmail.Domain.Entities
{
    public class EmailTemplateEntity: BaseEntity
    {
        public EmailTemplateEntity()
        {
         
        }
        public EmailTemplateEntity(string html)
        {
           
            this.Body = html;
            this.IsActive = true;
        }


        public string Body { get; set; }

        public bool IsActive { get; set; }

        internal void SetBody(string body)
        {
            this.Body = body;
        }
        public override string ToString()
        {
            return "EmailTemplateEntity";
        }

        public EmailTemplateEntity BuildDto(EmailTemplateDto dto)
        {
            this.Body = dto.Body;
            this.Id = dto.Id;
            this.IsActive = dto.IsActive;
            return this;

        }
    }
}
