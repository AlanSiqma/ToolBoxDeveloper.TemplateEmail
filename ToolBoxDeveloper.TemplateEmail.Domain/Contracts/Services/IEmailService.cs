using System.Threading.Tasks;
using ToolBoxDeveloper.TemplateEmail.Domain.Dto;

namespace ToolBoxDeveloper.TemplateEmail.Domain.Contracts.Services
{
    public interface IEmailService
    {
        Task<string> SendEmailFromTemplate(SendEmailDto dto);
    }
}
