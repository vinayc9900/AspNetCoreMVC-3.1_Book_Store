#pragma checksum "D:\MVC Practice\BookStore\WebGentle_BookStore\WebGentle_BookStore\Views\Shared\_bookThumbnail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d22096459e991154bb9211ed1e01c8d2ffce3768"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__bookThumbnail), @"mvc.1.0.view", @"/Views/Shared/_bookThumbnail.cshtml")]
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
#line 1 "D:\MVC Practice\BookStore\WebGentle_BookStore\WebGentle_BookStore\Views\_ViewImports.cshtml"
using WebGentle_BookStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d22096459e991154bb9211ed1e01c8d2ffce3768", @"/Views/Shared/_bookThumbnail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1420fa44011a45da99217667f4d69ffd0e458935", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__bookThumbnail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route", "bookDetailsRoute", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-sm btn-outline-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<img");
            BeginWriteAttribute("src", " src=\"", 26, "\"", 125, 1);
#nullable restore
#line 4 "D:\MVC Practice\BookStore\WebGentle_BookStore\WebGentle_BookStore\Views\Shared\_bookThumbnail.cshtml"
WriteAttributeValue("", 32, string.IsNullOrEmpty(Model.CoverImageUrl)? "/images/books/noimage.jpg":Model.CoverImageUrl, 32, 93, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-thumbnail\" style=\"max-height:160px;\" />\r\n<div class=\"card-body\">\r\n    <h3 class=\"card-title\">");
#nullable restore
#line 6 "D:\MVC Practice\BookStore\WebGentle_BookStore\WebGentle_BookStore\Views\Shared\_bookThumbnail.cshtml"
                       Write(string.IsNullOrEmpty(Model.Title)? "Name is not available":Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <p class=\"card-text\">");
#nullable restore
#line 7 "D:\MVC Practice\BookStore\WebGentle_BookStore\WebGentle_BookStore\Views\Shared\_bookThumbnail.cshtml"
                     Write(string.IsNullOrEmpty(Model.Description)? "Description is not available":Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n    <div class=\"d-flex justify-content-between align-content-center\">\r\n        <div class=\"btn-group\">\r\n");
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d22096459e991154bb9211ed1e01c8d2ffce37685117", async() => {
                WriteLiteral("View Details...");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Route = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 13 "D:\MVC Practice\BookStore\WebGentle_BookStore\WebGentle_BookStore\Views\Shared\_bookThumbnail.cshtml"
                                              WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("        </div>\r\n        <small class=\"text-muted\">");
#nullable restore
#line 24 "D:\MVC Practice\BookStore\WebGentle_BookStore\WebGentle_BookStore\Views\Shared\_bookThumbnail.cshtml"
                              Write(string.IsNullOrEmpty(Model.Author)? "NA":Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookModel> Html { get; private set; }
    }
}
#pragma warning restore 1591