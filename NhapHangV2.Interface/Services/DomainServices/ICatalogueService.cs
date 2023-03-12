using jeamin.Entities.DomainEntities;
using jeamin.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Interface.Services.DomainServices
{
    public interface ICatalogueService<T, E> : IDomainService<T, E> where T: AppDomainCatalogue where E : BaseSearch
    {
        T GetByCode(string code);
        Task<T> GetByCodeAsync(string code);
        Task<AppDomainImportResult> ImportTemplateFile(Stream stream, string createdBy);
    }
}
