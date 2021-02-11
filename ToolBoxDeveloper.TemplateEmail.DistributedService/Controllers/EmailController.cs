using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ToolBoxDeveloper.TemplateEmail.Domain.Contracts.Services;
using ToolBoxDeveloper.TemplateEmail.Domain.Dto;

namespace ToolBoxDeveloper.TemplateEmail.DistributedService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;

        public EmailController(IEmailService emailService)
        {
            this._emailService = emailService;
        }

        [HttpPost]
        public async Task<ActionResult> Post(SendEmailDto dto)
        {
            await this._emailService.SendEmailFromTemplate(dto);

            return Ok();
        }
    }
}
