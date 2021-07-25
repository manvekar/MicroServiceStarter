#pragma checksum "C:\MYP\microServiceStarter\MicroServiceStarter\src\Web\WebMVC\Views\Order\_OrderItems.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6bccb4fecb9446afed17c46e7f68c3a78f192712"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order__OrderItems), @"mvc.1.0.view", @"/Views/Order/_OrderItems.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\MYP\microServiceStarter\MicroServiceStarter\src\Web\WebMVC\Views\_ViewImports.cshtml"
using microServiceStarter.Web.WebMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\MYP\microServiceStarter\MicroServiceStarter\src\Web\WebMVC\Views\_ViewImports.cshtml"
using microServiceStarter.Web.WebMVC.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\MYP\microServiceStarter\MicroServiceStarter\src\Web\WebMVC\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bccb4fecb9446afed17c46e7f68c3a78f192712", @"/Views/Order/_OrderItems.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cca3251dd018aca9b259caedd33103ec48d4954e", @"/Views/_ViewImports.cshtml")]
    public class Views_Order__OrderItems : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<microServiceStarter.Web.WebMVC.ViewModels.Order>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<section class=\"esh-orders_new-section\">\r\n    <article class=\"esh-orders_new-titles row\">\r\n        <section class=\"esh-orders_new-title col-12\">Order details</section>\r\n    </article>\r\n\r\n");
#nullable restore
#line 9 "C:\MYP\microServiceStarter\MicroServiceStarter\src\Web\WebMVC\Views\Order\_OrderItems.cshtml"
     for (int i = 0; i < Model.OrderItems.Count; i++)
    {
        var item = Model.OrderItems[i];


#line default
#line hidden
#nullable disable
            WriteLiteral("        <article class=\"esh-orders_new-items esh-orders_new-items--border row\">\r\n            <section class=\"esh-orders_new-item col-md-4 hidden-md-down\">\r\n                <img class=\"esh-orders_new-image\"");
            BeginWriteAttribute("src", " src=\"", 557, "\"", 579, 1);
#nullable restore
#line 15 "C:\MYP\microServiceStarter\MicroServiceStarter\src\Web\WebMVC\Views\Order\_OrderItems.cshtml"
WriteAttributeValue("", 563, item.PictureUrl, 563, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 619, "\"", 643, 1);
#nullable restore
#line 16 "C:\MYP\microServiceStarter\MicroServiceStarter\src\Web\WebMVC\Views\Order\_OrderItems.cshtml"
WriteAttributeValue("", 627, item.PictureUrl, 627, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=", 644, "", 687, 1);
#nullable restore
#line 16 "C:\MYP\microServiceStarter\MicroServiceStarter\src\Web\WebMVC\Views\Order\_OrderItems.cshtml"
WriteAttributeValue("", 650, "orderitems[" + i + "].PictureUrl", 650, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </section>\r\n            <section class=\"esh-orders_new-item esh-orders_new-item--middle col-4\">\r\n                ");
#nullable restore
#line 19 "C:\MYP\microServiceStarter\MicroServiceStarter\src\Web\WebMVC\Views\Order\_OrderItems.cshtml"
           Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 872, "\"", 897, 1);
#nullable restore
#line 20 "C:\MYP\microServiceStarter\MicroServiceStarter\src\Web\WebMVC\Views\Order\_OrderItems.cshtml"
WriteAttributeValue("", 880, item.ProductName, 880, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=", 898, "", 942, 1);
#nullable restore
#line 20 "C:\MYP\microServiceStarter\MicroServiceStarter\src\Web\WebMVC\Views\Order\_OrderItems.cshtml"
WriteAttributeValue("", 904, "orderitems[" + i + "].ProductName", 904, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </section>\r\n            <section class=\"esh-orders_new-item esh-orders_new-item--middle col-1\">\r\n                $ ");
#nullable restore
#line 23 "C:\MYP\microServiceStarter\MicroServiceStarter\src\Web\WebMVC\Views\Order\_OrderItems.cshtml"
             Write(item.UnitPrice.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1142, "\"", 1165, 1);
#nullable restore
#line 24 "C:\MYP\microServiceStarter\MicroServiceStarter\src\Web\WebMVC\Views\Order\_OrderItems.cshtml"
WriteAttributeValue("", 1150, item.UnitPrice, 1150, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=", 1166, "", 1208, 1);
#nullable restore
#line 24 "C:\MYP\microServiceStarter\MicroServiceStarter\src\Web\WebMVC\Views\Order\_OrderItems.cshtml"
WriteAttributeValue("", 1172, "orderitems[" + i + "].UnitPrice", 1172, 36, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </section>\r\n            <section class=\"esh-orders_new-item esh-orders_new-item--middle col-1\">\r\n                ");
#nullable restore
#line 27 "C:\MYP\microServiceStarter\MicroServiceStarter\src\Web\WebMVC\Views\Order\_OrderItems.cshtml"
           Write(item.Units);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1387, "\"", 1406, 1);
#nullable restore
#line 28 "C:\MYP\microServiceStarter\MicroServiceStarter\src\Web\WebMVC\Views\Order\_OrderItems.cshtml"
WriteAttributeValue("", 1395, item.Units, 1395, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("name", " name=", 1407, "", 1445, 1);
#nullable restore
#line 28 "C:\MYP\microServiceStarter\MicroServiceStarter\src\Web\WebMVC\Views\Order\_OrderItems.cshtml"
WriteAttributeValue("", 1413, "orderitems[" + i + "].Units", 1413, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </section>\r\n            <section class=\"esh-orders_new-item esh-orders_new-item--middle col-2\">$ ");
#nullable restore
#line 30 "C:\MYP\microServiceStarter\MicroServiceStarter\src\Web\WebMVC\Views\Order\_OrderItems.cshtml"
                                                                                Write(Math.Round(item.Units * item.UnitPrice, 2).ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>\r\n        </article>\r\n");
#nullable restore
#line 32 "C:\MYP\microServiceStarter\MicroServiceStarter\src\Web\WebMVC\Views\Order\_OrderItems.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</section>

<section class=""esh-orders_new-section esh-orders_new-section--right"">
    <article class=""esh-orders_new-titles row"">
        <section class=""esh-orders_new-title col-9""></section>
        <section class=""esh-orders_new-title col-2"">Total</section>
    </article>

    <article class=""esh-orders_new-items row"">
        <section class=""esh-orders_new-item col-9""></section>
        <section class=""esh-orders_new-item esh-orders_new-item--mark col-2"">
            $ ");
#nullable restore
#line 44 "C:\MYP\microServiceStarter\MicroServiceStarter\src\Web\WebMVC\Views\Order\_OrderItems.cshtml"
         Write(Model.Total.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 2207, "\"", 2227, 1);
#nullable restore
#line 45 "C:\MYP\microServiceStarter\MicroServiceStarter\src\Web\WebMVC\Views\Order\_OrderItems.cshtml"
WriteAttributeValue("", 2215, Model.Total, 2215, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" name=\"Total\"/>\r\n        </section>\r\n    </article>\r\n</section>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<microServiceStarter.Web.WebMVC.ViewModels.Order> Html { get; private set; }
    }
}
#pragma warning restore 1591