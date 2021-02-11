using Microsoft.Extensions.DependencyInjection;
using ToolBoxDeveloper.TemplateEmail.Data.Repositories;
using ToolBoxDeveloper.TemplateEmail.Business.Services;
using ToolBoxDeveloper.TemplateEmail.Domain.Contracts.Repositories;
using ToolBoxDeveloper.TemplateEmail.Domain.Contracts.Services;

namespace ToolBoxDeveloper.TemplateEmail.IoC.Injection
{
    public static class InjectionConfigurations
    {
        public static IServiceCollection AddInjection(this IServiceCollection services)
        {
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IEmailTemplateService, EmailTemplateService>();
            services.AddScoped<IEmailConfigurationService, EmailConfigurationService>();

            services.AddScoped<IEmailConfigurationRepository, EmailConfigurationRepository>();
            services.AddScoped<IEmailTemplateRepository, EmailTemplateRepository>();

            return services;
        }
    }
}
