using ToolBoxDeveloper.TemplateEmail.Domain.Contracts.Settings;

namespace ToolBoxDeveloper.TemplateEmail.Domain.Settings
{
    public class DatabaseSettings : IDatabaseSetting
    {
        public string CollectionName { get; set; }

        public string ConnectionString { get; set; }

        public string DatabaseName { get; set; }
    }
}
