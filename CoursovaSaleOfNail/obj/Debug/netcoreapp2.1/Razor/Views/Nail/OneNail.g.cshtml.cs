#pragma checksum "C:\Users\User\source\repos\CoursovaSaleOfNail\CoursovaSaleOfNail\Views\Nail\OneNail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff35992e63a72ee7caa81b03372acb601344e0bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Nail_OneNail), @"mvc.1.0.view", @"/Views/Nail/OneNail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Nail/OneNail.cshtml", typeof(AspNetCore.Views_Nail_OneNail))]
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
#line 1 "C:\Users\User\source\repos\CoursovaSaleOfNail\CoursovaSaleOfNail\Views\Nail\OneNail.cshtml"
using CoursovaSaleOfNail.Data.Models.PageModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff35992e63a72ee7caa81b03372acb601344e0bf", @"/Views/Nail/OneNail.cshtml")]
    public class Views_Nail_OneNail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OneNailAndClient>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Img/SaleOfNail.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("50"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("???????? ????????????????"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bogy_class"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\User\source\repos\CoursovaSaleOfNail\CoursovaSaleOfNail\Views\Nail\OneNail.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(102, 176, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b2a2f5484438441987a8ee9188409d8f", async() => {
                BeginContext(108, 43, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <title>");
                EndContext();
                BeginContext(152, 15, false);
#line 8 "C:\Users\User\source\repos\CoursovaSaleOfNail\CoursovaSaleOfNail\Views\Nail\OneNail.cshtml"
      Write(Model.nail.name);

#line default
#line hidden
                EndContext();
                BeginContext(167, 104, true);
                WriteLiteral("</title>\r\n    <link href=\"https://localhost:44310/Styles/nail.css\" rel=\"stylesheet\" type=\"text/css\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(278, 37, true);
            WriteLiteral("\r\n<header class=\"header_class\">\r\n    ");
            EndContext();
            BeginContext(315, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d8bd5de5b3c54b9993260400e533d42d", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(379, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 13 "C:\Users\User\source\repos\CoursovaSaleOfNail\CoursovaSaleOfNail\Views\Nail\OneNail.cshtml"
      
        if (Model.name != "")
        {

#line default
#line hidden
            BeginContext(431, 195, true);
            WriteLiteral("            <div class =\"go_home\" >\r\n                <form action=\"https://localhost:44310/Client/goToClient\" method=\"post\">\r\n                    <input class =\"go_home\" type=\"submit\" name=\"name\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 626, "\"", 645, 1);
#line 18 "C:\Users\User\source\repos\CoursovaSaleOfNail\CoursovaSaleOfNail\Views\Nail\OneNail.cshtml"
WriteAttributeValue("", 634, Model.name, 634, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(646, 48, true);
            WriteLiteral(">\r\n                </form>\r\n            </div>\r\n");
            EndContext();
#line 21 "C:\Users\User\source\repos\CoursovaSaleOfNail\CoursovaSaleOfNail\Views\Nail\OneNail.cshtml"
        }
    

#line default
#line hidden
            BeginContext(712, 11, true);
            WriteLiteral("</header>\r\n");
            EndContext();
            BeginContext(723, 683, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db8ed21461484268908c7f6c2f5254a2", async() => {
                BeginContext(748, 40, true);
                WriteLiteral("\r\n    <div class=\"col-2-5img\">\r\n        ");
                EndContext();
                BeginContext(788, 68, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d11bcb2799d54ddabb09c7f4950b7c34", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 812, "~/Img/", 812, 6, true);
#line 26 "C:\Users\User\source\repos\CoursovaSaleOfNail\CoursovaSaleOfNail\Views\Nail\OneNail.cshtml"
AddHtmlAttributeValue("", 818, Model.nail.foto, 818, 16, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(856, 83, true);
                WriteLiteral("\r\n    </div>\r\n    <div class=\"col-3-5right\">\r\n        <div style=\"font-size: 72px\">");
                EndContext();
                BeginContext(940, 15, false);
#line 29 "C:\Users\User\source\repos\CoursovaSaleOfNail\CoursovaSaleOfNail\Views\Nail\OneNail.cshtml"
                                Write(Model.nail.name);

#line default
#line hidden
                EndContext();
                BeginContext(955, 18, true);
                WriteLiteral("</div>\r\n          ");
                EndContext();
                BeginContext(974, 22, false);
#line 30 "C:\Users\User\source\repos\CoursovaSaleOfNail\CoursovaSaleOfNail\Views\Nail\OneNail.cshtml"
     Write(Model.nail.description);

#line default
#line hidden
                EndContext();
                BeginContext(996, 61, true);
                WriteLiteral("\r\n        <br><div style=\"float: right;\">\r\n            ??i????: ");
                EndContext();
                BeginContext(1058, 16, false);
#line 32 "C:\Users\User\source\repos\CoursovaSaleOfNail\CoursovaSaleOfNail\Views\Nail\OneNail.cshtml"
             Write(Model.nail.price);

#line default
#line hidden
                EndContext();
                BeginContext(1074, 229, true);
                WriteLiteral("<br>\r\n            <form method=\"get\" action=\"https://localhost:44310/BuyNail/writeSaleInBD\" id=\"For registration or enter\">\r\n                <button class=\"butt\" type=\"submit\" form=\"For registration or enter\" name =\"numberOfNail\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1303, "\"", 1329, 1);
#line 34 "C:\Users\User\source\repos\CoursovaSaleOfNail\CoursovaSaleOfNail\Views\Nail\OneNail.cshtml"
WriteAttributeValue("", 1311, Model.nail.number, 1311, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1330, 69, true);
                WriteLiteral(">????????????????</button>\r\n            </form>\r\n        </div>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1406, 67, true);
            WriteLiteral("\r\n<footer>\r\n    <span>???????????? ?????????????? ???????????? ??????????</span>\r\n</footer>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OneNailAndClient> Html { get; private set; }
    }
}
#pragma warning restore 1591
