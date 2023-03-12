using jeamin.Entities.Configuration;
using jeamin.Entities.DomainEntities;
using jeamin.Interface.Services.DomainServices;
using jeamin.Utilities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Interface.Services.Configuration
{
    public interface IEmailConfigurationService : IDomainService<EmailConfigurations, BaseSearch>
    {
        Task<EmailSendConfigure> GetEmailConfig();
        EmailContent GetEmailContent();
        Task Send(string subject, string body, string[] Tos);
        Task Send(string subject, string body, string[] Tos, string[] CCs);
        Task Send(string subject, string body, string[] Tos, string[] CCs, string[] BCCs);
        Task Send(string subject, string[] Tos, string[] CCs, string[] BCCs, EmailContent emailContent);
        Task SendMail(string subject, string Tos, string[] CCs, string[] BCCs, EmailContent emailContent);
    }
}
