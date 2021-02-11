using System;
using System.Collections.Generic;
using ToolBoxDeveloper.TemplateEmail.Package.Contracts;
using ToolBoxDeveloper.TemplateEmail.Package.Dto;
using ToolBoxDeveloper.TemplateEmail.Package.Proxies;

namespace ToolBoxDeveloper.TemplateEmail.Sample
{
    class Program
    {
        private static IEmailProxy _proxy = new EmailProxy(new Package.Settings.EmailProxySetting() { Url= "https://localhost:44347/api/email" });
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Iniciando exemplo");
                Console.WriteLine("************************************");

                Dictionary<string, string> payload = new Dictionary<string, string>();
                payload.Add("Text", "Teste 1");
                payload.Add("TesteDoido", "Validação");

                SendEmailDto dto = new SendEmailDto(sender: "alansiqma@gmail.com",
                                                    destination: "alan.siqueira.maia@hotmail.com",
                                                    subject: "Teste1",
                                                    payload: payload, 
                                                    idTemplate: "601b023a092ae3eafea1234b",
                                                    user: "templateemail51@gmail.com");

                var validate = _proxy.SendEmailFromTemplate(dto).Result;

                Console.WriteLine(validate ? "Email enviado com sucesso!" : "Email não enviado");
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                Console.WriteLine("************************************");
                Console.ReadLine();
            }
        }
    }
}
