using Microsoft.AspNetCore.Mvc.Rendering;
using microServiceStarter.Web.WebMVC.ViewModels.Pagination;
using System.Collections.Generic;

namespace microServiceStarter.Web.WebMVC.ViewModels.CatalogViewModels
{
    public class IndexViewModel
    {
        public IEnumerable<CatalogItem> CatalogItems { get; set; }
        public IEnumerable<SelectListItem> Brands { get; set; }
        public IEnumerable<SelectListItem> Types { get; set; }
        public int? BrandFilterApplied { get; set; }
        public int? TypesFilterApplied { get; set; }
        public PaginationInfo PaginationInfo { get; set; }
    }
}
