using jeamin.Entities.Catalogue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Interface.Services.Configuration
{
    public interface ISendNotificationService
    {
        Task SendNotification(NotificationSetting notificationSetting, NotificationTemplate notiTemplate, string contentParam, string url, string urlUser, int? userId, string subject, string emailContent);
    }
}
