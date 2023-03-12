using jeamin.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeamin.Interface.Services
{
    public interface ISearchService
    {
        AppDomainResult SearchContent(int site, string content);
    }
}
