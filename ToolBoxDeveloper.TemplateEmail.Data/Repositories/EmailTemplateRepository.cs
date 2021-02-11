using ToolBoxDeveloper.TemplateEmail.Data.Repositories.Base;
using ToolBoxDeveloper.TemplateEmail.Domain.Contracts.Repositories;
using ToolBoxDeveloper.TemplateEmail.Domain.Contracts.Settings;
using ToolBoxDeveloper.TemplateEmail.Domain.Entities;

namespace ToolBoxDeveloper.TemplateEmail.Data.Repositories
{
    public class EmailTemplateRepository: RepositoryBase<EmailTemplateEntity>, IEmailTemplateRepository
    {
        public EmailTemplateRepository(IDatabaseSetting settings): base(settings)
        {

        }
    }
}
