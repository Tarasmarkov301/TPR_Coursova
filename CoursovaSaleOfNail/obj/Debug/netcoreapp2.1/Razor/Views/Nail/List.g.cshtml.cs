#pragma checksum "C:\Users\User\source\repos\CoursovaSaleOfNail\CoursovaSaleOfNail\Views\Nail\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97758aba6767efbc424ce0f8ce9f9b5bc3bbed4b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Nail_List), @"mvc.1.0.view", @"/Views/Nail/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Nail/List.cshtml", typeof(AspNetCore.Views_Nail_List))]
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
#line 1 "C:\Users\User\source\repos\CoursovaSaleOfNail\CoursovaSaleOfNail\Views\Nail\List.cshtml"
using CoursovaSaleOfNail.Data.Models.PageModel;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97758aba6767efbc424ce0f8ce9f9b5bc3bbed4b", @"/Views/Nail/List.cshtml")]
    public class Views_Nail_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NailAndClient>
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
#line 3 "C:\Users\User\source\repos\CoursovaSaleOfNail\CoursovaSaleOfNail\Views\Nail\List.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(100, 176, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ba40dcaa2f246a0b5d9e655493da15c", async() => {
                BeginContext(106, 163, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <title>?????????????? ????????????????</title>\r\n    <link href=\"https://localhost:44310/Styles/Site.css\" rel=\"stylesheet\" type=\"text/css\" />\r\n");
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
            BeginContext(276, 37, true);
            WriteLiteral("\r\n<header class=\"header_class\">\r\n    ");
            EndContext();
            BeginContext(313, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "73822712e463474d8654d1eb1ff6c904", async() => {
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
            BeginContext(377, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 13 "C:\Users\User\source\repos\CoursovaSaleOfNail\CoursovaSaleOfNail\Views\Nail\List.cshtml"
      
        if (Model.name != "") {

#line default
#line hidden
            BeginContext(420, 170, true);
            WriteLiteral("            <div class =\"go_home\"><form action=\"https://localhost:44310/Client/goToClient\"  method=\"post\">\r\n             <input class =\"go_home\" type=\"submit\" name=\"name\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 590, "\"", 609, 1);
#line 16 "C:\Users\User\source\repos\CoursovaSaleOfNail\CoursovaSaleOfNail\Views\Nail\List.cshtml"
WriteAttributeValue("", 598, Model.name, 598, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(610, 18, true);
            WriteLiteral(">\r\n</form></div>\r\n");
            EndContext();
#line 18 "C:\Users\User\source\repos\CoursovaSaleOfNail\CoursovaSaleOfNail\Views\Nail\List.cshtml"
        }
    

#line default
#line hidden
            BeginContext(646, 11, true);
            WriteLiteral("</header>\r\n");
            EndContext();
            BeginContext(657, 2264, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b899364efccb45499c64bba483e9f416", async() => {
                BeginContext(682, 660, true);
                WriteLiteral(@"
    <div class=""col-1-5left"">
            <form action=""https://localhost:44310/Nail/findNail"" method=""get"" id=""For find"">
                <label for=""name of nail"">?????????? ??????????:</label><br> <input type=""text"" id=""name of nail"" name=""name""><br>
                <label for=""price of nail"">?????????????????????? ????????:</label><br> <input type=""range"" name=""maxPrice"" id=""price of nail"" min=""0"" max=""1500"" step=""5"" oninput=""this.nextElementSibling.value = this.value"">
                <output>750</output><br>
                <button type=""submit"" form=""For find"" value=""Submit"">????????????</button>
            </form>
    </div>
                <div class=""col-3-5"">
");
                EndContext();
#line 31 "C:\Users\User\source\repos\CoursovaSaleOfNail\CoursovaSaleOfNail\Views\Nail\List.cshtml"
                     foreach (var nail in Model.nails) {


#line default
#line hidden
                BeginContext(1402, 70, true);
                WriteLiteral("                    <div class=\"col-1-5img\">\r\n                        ");
                EndContext();
                BeginContext(1472, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8b704c95e5344fc0bc199697a9961287", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 1496, "~/Img/", 1496, 6, true);
#line 34 "C:\Users\User\source\repos\CoursovaSaleOfNail\CoursovaSaleOfNail\Views\Nail\List.cshtml"
AddHtmlAttributeValue("", 1502, nail.foto, 1502, 10, false);

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
                BeginContext(1534, 37, true);
                WriteLiteral("<br>\r\n                        <label>");
                EndContext();
                BeginContext(1572, 9, false);
#line 35 "C:\Users\User\source\repos\CoursovaSaleOfNail\CoursovaSaleOfNail\Views\Nail\List.cshtml"
                          Write(nail.name);

#line default
#line hidden
                EndContext();
                BeginContext(1581, 77, true);
                WriteLiteral("</label>\r\n                        <br>\r\n                        <label>????????: ");
                EndContext();
                BeginContext(1659, 10, false);
#line 37 "C:\Users\User\source\repos\CoursovaSaleOfNail\CoursovaSaleOfNail\Views\Nail\List.cshtml"
                                Write(nail.price);

#line default
#line hidden
                EndContext();
                BeginContext(1669, 189, true);
                WriteLiteral("</label><br>\r\n                        <form action=\"https://localhost:44310/Nail/oneNail\" method=\"get\" id=\"For one\">\r\n                        <button type=\"submit\" name =\"id\" form=\"For one\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1858, "\"", 1878, 1);
#line 39 "C:\Users\User\source\repos\CoursovaSaleOfNail\CoursovaSaleOfNail\Views\Nail\List.cshtml"
WriteAttributeValue("", 1866, nail.number, 1866, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1879, 83, true);
                WriteLiteral(">????????????????????</button>\r\n                        </form>\r\n                    </div>\r\n");
                EndContext();
#line 42 "C:\Users\User\source\repos\CoursovaSaleOfNail\CoursovaSaleOfNail\Views\Nail\List.cshtml"
                    
                    }

#line default
#line hidden
                BeginContext(2007, 907, true);
                WriteLiteral(@"
                            
                        </div>
                <div class=""col-1-5right"">
                    <form method=""post"" action=""https://localhost:44310/Nail/enter"" id=""For enter"">
                        <label for=""Your name"">????'?? ??????????????????????:</label><br> <input type=""text"" id=""Your name"" name=""user_name""><br>
                        <label for=""Your password"">???????????? ??????????????????????:</label><br> <input type=""password"" id=""Your password"" name=""user_password""><br>
                        <button type=""submit"" form=""For enter"" value=""Submit"">??????????</button><br>
                    </form>
                    <form method=""post"" action=""https://localhost:44310/Registration/Registration"" id=""For registration"">
                        <button type=""submit"" form=""For registration"" value=""Submit"">??????????????????????????????</button>
                    </form>
              </div>
");
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
            BeginContext(2921, 67, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NailAndClient> Html { get; private set; }
    }
}
#pragma warning restore 1591
