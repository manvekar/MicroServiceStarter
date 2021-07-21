using Microsoft.AspNetCore.Mvc.Rendering;
using microServiceStarter.Web.WebMVC.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace microServiceStarter.Web.WebMVC.Services
{
    public interface ICatalogService
    {
        Task<Catalog> GetCatalogItems(int page, int take, int? brand, int? type);
        Task<IEnumerable<SelectListItem>> GetBrands();
        Task<IEnumerable<SelectListItem>> GetTypes();
    }
}
