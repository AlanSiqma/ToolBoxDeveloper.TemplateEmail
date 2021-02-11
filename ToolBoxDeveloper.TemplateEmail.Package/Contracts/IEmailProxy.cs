using System.Threading.Tasks;
using ToolBoxDeveloper.TemplateEmail.Package.Dto;

namespace ToolBoxDeveloper.TemplateEmail.Package.Contracts
{
    public interface IEmailProxy
    {
        Task<bool> SendEmailFromTemplate(SendEmailDto dto);
    }
}
