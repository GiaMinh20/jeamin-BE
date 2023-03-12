using Microsoft.AspNetCore.Mvc;
using jeamin.Interface.Services;
using jeamin.Request;
using jeamin.Utilities;
using System.ComponentModel;
using System.Net;

namespace jeamin.API.Controllers
{
    [Route("api/search")]
    [ApiController]
    [Description("Tìm kiếm sản phẩm")]
    public class SearchController : ControllerBase
    {
        private readonly ISearchService searchService;
        public SearchController(ISearchService searchService)
        {
            this.searchService = searchService;
        }

        [HttpPost]
        public AppDomainResult SearchContent(SearchRequest searchRequest)
        {
            return searchService.SearchContent(searchRequest.Site, searchRequest.Content);
        }
    }
}
