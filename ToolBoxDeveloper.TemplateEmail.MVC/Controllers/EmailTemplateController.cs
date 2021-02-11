using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ToolBoxDeveloper.TemplateEmail.Domain.Contracts.Services;
using ToolBoxDeveloper.TemplateEmail.Domain.Dto;

namespace ToolBoxDeveloper.TemplateEmail.MVC.Controllers
{
    public class EmailTemplateController : Controller
    {
        private readonly IEmailTemplateService _emailTemplateService;
        public EmailTemplateController(IEmailTemplateService emailTemplateService)
        {
            this._emailTemplateService = emailTemplateService;
        }
        // GET: EmailTemplateController
        public async Task<ActionResult> Index()
        {
            var list = await this._emailTemplateService.GetTemplates();

            return View(list);
        }


        // GET: EmailTemplateController/Create
        public ActionResult Create()
        {
            return View(new EmailTemplateDto());
        }

        // POST: EmailTemplateController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async  Task<ActionResult> Create(EmailTemplateDto dto)
        {
            try
            {
                await this._emailTemplateService.CreateOrUpdate(dto);

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
            var dto = await this._emailTemplateService.GetById(id);

            return View(dto);
        }

        // POST: EmailTemplateController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(EmailTemplateDto dto)
        {
            try
            {
                await this._emailTemplateService.CreateOrUpdate(dto);

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
                var dto = await this._emailTemplateService.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
