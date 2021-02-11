using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ToolBoxDeveloper.TemplateEmail.Package.Dto
{
    public class SendEmailDto
    {
        public SendEmailDto()
        {

        }
        public SendEmailDto(string destination, string sender, string subject, Dictionary<string, string> payload, string idTemplate, string user,string html = "")
        {
            this.Destinations = new List<string>();
            this.BCCDestinations = new List<string>();
            this.CCDestinations = new List<string>();

            this.Destinations.Add(destination);
            this.Sender = sender;
            this.Subject = subject;
            this.Payload = payload;
            this.IdTemplate = idTemplate;
            this.User = user;
            this.Html = html;
        }
       
        public string Sender { get; set; }
        public List<string> Destinations { get; set; }
        public void AddDestinations(string destination)
        {
            if (string.IsNullOrEmpty(destination))
                this.Destinations.Add(destination);
        }
        public List<string> BCCDestinations { get; set; }
        public void AddBCCDestinations(string destination)
        {
            if (string.IsNullOrEmpty(destination))
                this.BCCDestinations.Add(destination);
        }
        public List<string> CCDestinations { get; set; }
        public void AddCCDestinations(string destination)
        {
            if (string.IsNullOrEmpty(destination))
                this.CCDestinations.Add(destination);
        }
        public string Subject { get; set; }
        public Dictionary<string, string> Payload { get; set; }
        public string IdTemplate { get; set; }
        public string Html { get; set; }
        public string User { get; set; }
    }
}
