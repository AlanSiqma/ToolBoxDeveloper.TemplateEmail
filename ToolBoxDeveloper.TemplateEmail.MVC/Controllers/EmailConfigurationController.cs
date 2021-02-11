using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ToolBoxDeveloper.TemplateEmail.Domain.Contracts.Services;
using ToolBoxDeveloper.TemplateEmail.Domain.Dto;

namespace ToolBoxDeveloper.TemplateEmail.MVC.Controllers
{
    public class EmailConfigurationController : Controller
    {
        private readonly IEmailConfigurationService _emailConfigurationService;
        public EmailConfigurationController(IEmailConfigurationService emailConfigurationService)
        {
            this._emailConfigurationService = emailConfigurationService;
        }
        // GET: EmailTemplateController
        public async Task<ActionResult> Index()
        {
            var list = await this._emailConfigurationService.GetConfigurations();

            return View(list);
        }


        // GET: EmailTemplateController/Create
        public ActionResult Create()
        {
            return View(new EmailConfigurationDto());
        }

        // POST: EmailTemplateController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(EmailConfigurationDto dto)
        {
            try
            {
                await this._emailConfigurationService.CreateOrUpdate(dto);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmailTemplateController/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            var dto = await this._emailConfigurationService.GetById(id);

            return View(dto);
        }

        // POST: EmailTemplateController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(EmailConfigurationDto dto)
        {
            try
            {
                await this._emailConfigurationService.CreateOrUpdate(dto);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EmailTemplateController/Delete/5
                
        public async Task<ActionResult> Delete(string id)
        {
            try
            {
                var dto = await this._emailConfigurationService.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
