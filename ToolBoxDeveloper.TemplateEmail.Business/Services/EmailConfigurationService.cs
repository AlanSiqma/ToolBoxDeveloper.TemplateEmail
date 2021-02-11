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
    public class EmailConfigurationService: IEmailConfigurationService
    {
        private readonly IEmailConfigurationRepository _emailConfigurationRepository;
        public EmailConfigurationService(IEmailConfigurationRepository emailConfigurationRepository)
        {
            this._emailConfigurationRepository = emailConfigurationRepository;
        }
        public async Task<List<EmailConfigurationDto>> GetConfigurations()
        {
            List<EmailConfigurationDto> result;
            try
            {
                var entities = await this._emailConfigurationRepository.Get();
                result = entities.Select(x => new EmailConfigurationDto(x)).ToList();
            }
            catch (Exception)
            {
                result = new List<EmailConfigurationDto>();
            }

            return result;
        }

        public async Task<bool> CreateOrUpdate(EmailConfigurationDto dto)
        {
            if (string.IsNullOrEmpty(dto.Id))
                return await Create(dto);
            else
                return await Update(dto);
        }

        private async Task<bool> Update(EmailConfigurationDto dto)
        {
            var result = true;
            try
            {
                await this._emailConfigurationRepository.Update(dto.Id, new EmailConfigurationEntity().BuildDto(dto));
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }

        private async Task<bool> Create(EmailConfigurationDto dto)
        {
            var result = true;
            try
            {
                //dto.GenerateId();

                await this._emailConfigurationRepository.Create(new EmailConfigurationEntity().BuildDto(dto));
            }
            catch (Exception)
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
                var entity = (await this._emailConfigurationRepository.Get(x => x.Id.Equals(id))).FirstOrDefault();

                await this._emailConfigurationRepository.Remove(entity);
            }
            catch (Exception)
            {
                result = false;
            }

            return result;
        }
        public async Task<EmailConfigurationDto> GetById(string id)
        {
            EmailConfigurationDto result;
            try
            {
                var entity = (await this._emailConfigurationRepository.Get(x => x.Id.Equals(id))).FirstOrDefault();

                result = new EmailConfigurationDto(entity);

            }
            catch (Exception)
            {
                result = new EmailConfigurationDto();
            }

            return result;
        }
    }
}
