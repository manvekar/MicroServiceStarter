using System.Security.Principal;

namespace microServiceStarter.Web.WebMVC.Services
{
    public interface IIdentityParser<T>
    {
        T Parse(IPrincipal principal);
    }
}
