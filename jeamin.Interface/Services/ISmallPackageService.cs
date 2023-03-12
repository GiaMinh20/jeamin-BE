using jeamin.Entities;
using jeamin.Entities.Search;
using jeamin.Interface.Services.DomainServices;
using jeamin.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Interface.Services
{
    public interface ISmallPackageService : IDomainService<SmallPackage, SmallPackageSearch>
    {
        Task<List<SmallPackage>> ExportForBarCode(int UID, string BarCode, int Type);

        Task<List<SmallPackage>> ExportForUserName(int UID, int OrderID, int StatusType, int OrderType);

        Task<bool> UpdateIsLost(SmallPackage item);

        Task<List<SmallPackage>> CheckBarCode(List<SmallPackage> items, bool isAssign);

        Task<AppDomainImportResult> ImportTemplateFile(Stream stream, int? bigPackageId, string createdBy);

        Task<SmallPackage> GetByOrderTransactionCode(string code);

        Task<List<SmallPackage>> GetAllByMainOrderId(int mainOrderId);
        Task<List<SmallPackage>> GetAllByTransportationOrderId(int transportationOrderId);
        Task<List<SmallPackage>> GetInVietNamByMainOrderId(int mainOrderId);
    }
}
