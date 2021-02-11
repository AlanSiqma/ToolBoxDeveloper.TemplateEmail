using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ToolBoxDeveloper.TemplateEmail.Package.Contracts;
using ToolBoxDeveloper.TemplateEmail.Package.Dto;
using ToolBoxDeveloper.TemplateEmail.Package.Settings;

namespace ToolBoxDeveloper.TemplateEmail.Package.Proxies
{
    public class EmailProxy : IEmailProxy
    {
        private readonly EmailProxySetting _emailProxySetting;
        private static readonly HttpClient client = new HttpClient();
        public EmailProxy(EmailProxySetting emailProxySetting)
        {
            this._emailProxySetting = emailProxySetting;
        }
        public async Task<bool> SendEmailFromTemplate(SendEmailDto dto)
        {
            bool result = false;

            try
            {
                var serialize = JsonSerializer.Serialize(dto);

                var content = new StringContent(serialize.ToString(), Encoding.UTF8, "application/json");

                var response = client.PostAsync(this._emailProxySetting.Url, content).Result;

                var responseString = await response.Content.ReadAsStringAsync();

                result = response.IsSuccessStatusCode;// bool.Parse(responseString);

            }
            catch (System.Exception)
            {
                result = false;
            }


            return result;
        }
    }
}
