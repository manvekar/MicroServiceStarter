namespace microServiceStarter.Web.WebMVC.ViewModels
{
    public record Header
    {
        public string Controller { get; init; }
        public string Text { get; init; }
    }
}