using System.Collections.Generic;
using System.Threading.Tasks;
using ToolBoxDeveloper.TemplateEmail.Domain.Dto;

namespace ToolBoxDeveloper.TemplateEmail.Domain.Contracts.Services
{
    public interface IEmailConfigurationService
    {
        Task<List<EmailConfigurationDto>> GetConfigurations();
        Task<bool> CreateOrUpdate(EmailConfigurationDto dto);
        Task<bool> Delete(string id);

        Task<EmailConfigurationDto> GetById(string id);
    }
}
