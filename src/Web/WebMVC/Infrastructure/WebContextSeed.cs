using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using microServiceStarter.Web.WebMVC;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Serilog;
using System;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace WebMVC.Infrastructure
{
    public class WebContextSeed
    {
        public static void Seed(IApplicationBuilder applicationBuilder, IWebHostEnvironment env)
        {
            var log = Serilog.Log.Logger;

            var settings = (AppSettings)applicationBuilder
                .ApplicationServices.GetRequiredService<IOptions<AppSettings>>().Value;

            var useCustomizationData = settings.UseCustomizationData;
            var contentRootPath = env.ContentRootPath;
            var webroot = env.WebRootPath;

            if (useCustomizationData)
            {
                GetPreconfiguredCSS(contentRootPath, webroot, log);
            }
        }

        static void GetPreconfiguredCSS(string contentRootPath, string webroot, ILogger log)
        {
            try
            {
                string overrideCssFile = Path.Combine(contentRootPath, "Setup", "override.css");
                if (!File.Exists(overrideCssFile))
                {
                    log.Error("Override css file '{FileName}' does not exists.", overrideCssFile);
                    return;
                }

                string destinationFilename = Path.Combine(webroot, "css", "override.css");
                File.Copy(overrideCssFile, destinationFilename, true);
            }
            catch (Exception ex)
            {
                log.Error(ex, "EXCEPTION ERROR: {Message}", ex.Message);
            }
        }
    }
}
