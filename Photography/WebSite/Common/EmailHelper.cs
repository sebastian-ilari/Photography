using System;
using System.Net;
using System.Net.Mail;
using System.Configuration;

namespace Common
{
    public class EmailHelper
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }

        public EmailHelper(string name, string emailAddress, string subject, string message)
        {
            this.Name = name;
            this.EmailAddress = emailAddress;
            this.Subject = subject;
            this.Message = message;
        }
        
        public void Send()
        {
            MailAddress fromAddress;
            MailAddress toAddress;
            
            // For security reasons Gmail doesn't allow to send an email with a different From address
            fromAddress = toAddress = new MailAddress(ConfigurationManager.AppSettings["emailConfiguration"], "Photography website");

            try
            {
                SmtpClient smtp = new SmtpClient();

                MailMessage message = new MailMessage(fromAddress, toAddress);
                message.Subject = this.Subject;
                message.Body = this.BuildEmail(this.Name, this.EmailAddress, this.Message);
                message.IsBodyHtml = true;

                smtp.Send(message);
            }
            catch (SmtpFailedRecipientsException exception)
            {
                throw exception;
            }
            catch (SmtpException exception)
            {
                throw exception;
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        private string BuildEmail(string name, string address, string message)
        {
            return string.Format("<html><div>From: {0}</div><div>Email address: {1}</div><div style='margin-top: 20px;'>{2}</div></html>", 
                                        this.Name, this.EmailAddress, this.Message);
        }
    }
}
