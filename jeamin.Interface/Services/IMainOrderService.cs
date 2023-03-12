using jeamin.Entities;
using jeamin.Entities.Search;
using jeamin.Entities.SQLEntities;
using jeamin.Interface.Services.DomainServices;
using jeamin.Models;
using jeamin.Models.ExcelModels;
using jeamin.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Interface.Services
{
    public interface IMainOrderService : IDomainService<MainOrder, MainOrderSearch>
    {
        Task<bool> UpdateStaff(MainOrder item);
        Task<bool> UpdateMainOrder(List<int> listId, int status, int userId);
        Task<bool> CreateOrder(List<MainOrder> listData, bool isAnother);
        Task<bool> Payment(int id, int paymentType, int paymentMethod, decimal amount, string note);
        Task<MainOrder> PriceAdjustment(MainOrder item);
        Task<AmountStatistic> GetTotalOrderPriceByUID(int UID);
        MainOrdersInfor GetMainOrdersInfor(int UID, int orderType);
        MainOrdersAmount GetMainOrdersAmount(int UID, int orderType);
        Task<bool> UpdateStatus(int ID, int status);
        Task<bool> UpdateIsCheckNotiPrice(MainOrder mainOrder);
        void UpdateMainOrderFromSql(string commandText);
        List<NumberOfOrders> GetNumberOfOrders(MainOrderSearch mainOrderSearch);
        byte[] GetMainOrdersExcel(MainOrderSearch mainOrderSearch);
        CountAllOrder GetCountAllOrder(MainOrderSearch mainOrderSearch);
        PriceInMonth GetPriceInMonth(MainOrderSearch mainOrderSearch);
        Task<bool> UpdateMainOrderWeight(int id, decimal weight);
        Task<bool> UpdateMainOrderDelivery(int id, decimal deliveryPrice);
    }
}
