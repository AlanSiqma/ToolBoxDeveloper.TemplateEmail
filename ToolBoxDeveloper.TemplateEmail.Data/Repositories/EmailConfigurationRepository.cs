using ToolBoxDeveloper.TemplateEmail.Data.Repositories.Base;
using ToolBoxDeveloper.TemplateEmail.Domain.Contracts.Repositories;
using ToolBoxDeveloper.TemplateEmail.Domain.Contracts.Settings;
using ToolBoxDeveloper.TemplateEmail.Domain.Entities;

namespace ToolBoxDeveloper.TemplateEmail.Data.Repositories
{
    public class EmailConfigurationRepository:RepositoryBase<EmailConfigurationEntity>, IEmailConfigurationRepository
    {
        public EmailConfigurationRepository(IDatabaseSetting settings):base(settings)
        {

        }
    }
}
