using System.Collections.Generic;
using System.Threading.Tasks;
using ToolBoxDeveloper.TemplateEmail.Domain.Dto;

namespace ToolBoxDeveloper.TemplateEmail.Domain.Contracts.Services
{
    public interface IEmailTemplateService
    {
        Task<List<EmailTemplateDto>> GetTemplates();

        Task<bool> CreateOrUpdate(EmailTemplateDto dto);

        Task<bool> Delete(string id);
        Task<EmailTemplateDto> GetById(string id);
    }
}
