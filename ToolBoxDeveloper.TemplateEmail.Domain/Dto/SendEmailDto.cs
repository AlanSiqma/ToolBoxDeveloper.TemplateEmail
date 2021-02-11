using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ToolBoxDeveloper.TemplateEmail.Domain.Dto
{
    public class SendEmailDto
    {
        public SendEmailDto()
        {

        }
        public SendEmailDto(string destination, string sender, string subject, Dictionary<string, string> payload, string idTemplate, string user)
        {
            this.Destinations = new List<string>();

            this.Destinations.Add(destination);
            this.Sender = sender;
            this.Subject = subject;
            this.Payload = payload;
            this.IdTemplate = idTemplate;
            this.User = user;
        }
        public bool ValidateEmails()
        {
            bool result = true;

            foreach (var item in this.Destinations)
            {
                if (this.ValidateEmail(item) == false)
                    result = false;
            }

            foreach (var item in this.CCDestinations)
            {
                if (!this.ValidateEmail(item) == false)
                    result = false;
            }

            foreach (var item in this.BCCDestinations)
            {
                if (this.ValidateEmail(item) == false)
                    result = false;
            }

            return result;
        }
        public SendEmailDto SetHtml(string html)
        {
            this.Html = html;
            return this;
        }
        public SendEmailDto SetContentEmail()
        {
            List<string> variables = new List<string>();
         
            foreach (var item in this.Html.Split(Environment.NewLine).ToList().Select(x => (x.Split("{").Where(c => c.Contains("}")).Select(c => c.Substring(0, c.IndexOf("}"))))))
            {
                foreach (string itemInternal in item)
                {
                    if (!string.IsNullOrEmpty(itemInternal.Trim()))
                        variables.Add(itemInternal);
                }
            }

            foreach (string item in variables)
                this.Html = this.Html.Replace("{" + item + "}", this.Payload[item].ToString());

            return this;
        }
        public string To
        {
            get
            {
                string to = string.Empty;

                foreach (var item in this.Destinations)
                {
                    if (item.Equals(this.Destinations.FirstOrDefault()))
                        to = item;
                    else
                        to += $",{item}";
                }

                return to;
            }
        }
        public string Sender { get; set; }
        public List<string> Destinations { get; set; }
        public List<string> BCCDestinations { get; set; }
        public List<string> CCDestinations { get; set; }
        public string Subject { get; set; }
        public Dictionary<string, string> Payload { get; set; }
        public string IdTemplate { get; set; }
        public string Html { get; set; }
        public string User { get; set; }
        private bool ValidateEmail(string email)
        {
            try
            {
                if (new Regex(@"\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}").IsMatch(email))
                    return true;
                else
                    return false;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
