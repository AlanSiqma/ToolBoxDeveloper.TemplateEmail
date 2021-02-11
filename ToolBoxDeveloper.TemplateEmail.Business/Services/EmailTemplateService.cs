using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToolBoxDeveloper.TemplateEmail.Domain.Contracts.Repositories;
using ToolBoxDeveloper.TemplateEmail.Domain.Contracts.Services;
using ToolBoxDeveloper.TemplateEmail.Domain.Dto;
using ToolBoxDeveloper.TemplateEmail.Domain.Entities;

namespace ToolBoxDeveloper.TemplateEmail.Business.Services
{
    public class EmailTemplateService : IEmailTemplateService
    {
        private readonly IEmailTemplateRepository _emailTemplateRepository;

        public EmailTemplateService(IEmailTemplateRepository emailTemplateRepository)
        {
            this._emailTemplateRepository = emailTemplateRepository;
        }

        public async Task<List<EmailTemplateDto>> GetTemplates()
        {
            List<EmailTemplateDto> result;
            try
            {
                var entities = await this._emailTemplateRepository.Get();
                result = entities.Select(x => new EmailTemplateDto(x)).ToList();
            }
            catch (Exception)
            {
                result = new List<EmailTemplateDto>();
            }

            return result;
        }

        public async Task<bool> CreateOrUpdate(EmailTemplateDto dto)
        {
            if (string.IsNullOrEmpty(dto.Id))
                return await Create(dto);
            else
                return await Update(dto);
        }

        private async Task<bool> Update(EmailTemplateDto dto)
        {
            var result = true;
            try
            {
                await this._emailTemplateRepository.Update(dto.Id, new EmailTemplateEntity().BuildDto(dto));
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> Create(EmailTemplateDto dto)
        {
            var result = true;
            try
            {
                await this._emailTemplateRepository.Create(new EmailTemplateEntity().BuildDto(dto));
            }
            catch (Exception ex)
            {
                result = false;
            }

            return result;
        }

        public async Task<bool> Delete(string id)
        {
            var result = true;
            try
            {
                var entity = (await this._emailTemplateRepository.Get(x => x.Id.Equals(id))).FirstOrDefault();

                await this._emailTemplateRepository.Remove(entity);
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }

        public async Task<EmailTemplateDto> GetById(string id)
        {
            EmailTemplateDto result;
            try
            {
                var entity = (await this._emailTemplateRepository.Get(x => x.Id.Equals(id))).FirstOrDefault();

                result = new EmailTemplateDto(entity);

            }
            catch (Exception)
            {
                result = new EmailTemplateDto();
            }

            return result;
        }
    }
}
