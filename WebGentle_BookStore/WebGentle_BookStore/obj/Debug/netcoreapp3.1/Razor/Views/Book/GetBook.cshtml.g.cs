#pragma checksum "D:\MVC Practice\BookStore\WebGentle_BookStore\WebGentle_BookStore\Views\Book\GetBook.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dcdc5d9a9c1ffd38a3274667602d8de126e3121d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Book_GetBook), @"mvc.1.0.view", @"/Views/Book/GetBook.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dcdc5d9a9c1ffd38a3274667602d8de126e3121d", @"/Views/Book/GetBook.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1420fa44011a45da99217667f4d69ffd0e458935", @"/Views/_ViewImports.cshtml")]
    public class Views_Book_GetBook : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block w-100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("800"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("400"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral(@"

<div class=""container"">
    <h3 class=""display-4"">Book Details</h3>
    <div class=""row"">
        <div class=""col-md-6"">
            <div id=""carouselExampleIndicators"" class=""carousel slide"" data-ride=""carousel"">
                <ol class=""carousel-indicators"">
");
#nullable restore
#line 15 "D:\MVC Practice\BookStore\WebGentle_BookStore\WebGentle_BookStore\Views\Book\GetBook.cshtml"
                     for (int i = 0; i < Model.Gallery.Count(); i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"");
#nullable restore
#line 17 "D:\MVC Practice\BookStore\WebGentle_BookStore\WebGentle_BookStore\Views\Book\GetBook.cshtml"
                                                                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"");
            BeginWriteAttribute("class", " class=\"", 537, "\"", 564, 1);
#nullable restore
#line 17 "D:\MVC Practice\BookStore\WebGentle_BookStore\WebGentle_BookStore\Views\Book\GetBook.cshtml"
WriteAttributeValue("", 545, i==0?"active":"", 545, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></li>\r\n");
#nullable restore
#line 18 "D:\MVC Practice\BookStore\WebGentle_BookStore\WebGentle_BookStore\Views\Book\GetBook.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"1\"></li>\r\n                    <li data-target=\"#carouselExampleIndicators\" data-slide-to=\"2\"></li>\r\n                </ol>\r\n                <div class=\"carousel-inner\">\r\n");
#nullable restore
#line 24 "D:\MVC Practice\BookStore\WebGentle_BookStore\WebGentle_BookStore\Views\Book\GetBook.cshtml"
                     for (int i = 0; i < Model.Gallery.Count(); i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div");
            BeginWriteAttribute("class", " class=\"", 968, "\"", 1024, 1);
#nullable restore
#line 26 "D:\MVC Practice\BookStore\WebGentle_BookStore\WebGentle_BookStore\Views\Book\GetBook.cshtml"
WriteAttributeValue("", 976, i==0 ? "carousel-item active":"carousel-item", 976, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "dcdc5d9a9c1ffd38a3274667602d8de126e3121d6657", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "D:\MVC Practice\BookStore\WebGentle_BookStore\WebGentle_BookStore\Views\Book\GetBook.cshtml"
                                                WriteLiteral(Model.Gallery[i].Url);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
#nullable restore
#line 28 "D:\MVC Practice\BookStore\WebGentle_BookStore\WebGentle_BookStore\Views\Book\GetBook.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 28 "D:\MVC Practice\BookStore\WebGentle_BookStore\WebGentle_BookStore\Views\Book\GetBook.cshtml"
AddHtmlAttributeValue("", 1169, Model.Gallery[i].Name, 1169, 22, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n");
#nullable restore
#line 30 "D:\MVC Practice\BookStore\WebGentle_BookStore\WebGentle_BookStore\Views\Book\GetBook.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                </div>
                <a class=""carousel-control-prev"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""prev"">
                    <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Previous</span>
                </a>
                <a class=""carousel-control-next"" href=""#carouselExampleIndicators"" role=""button"" data-slide=""next"">
                    <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
                    <span class=""sr-only"">Next</span>
                </a>
            </div>
        </div>
        <div class=""col-md-6"">
            <div class=""row"">
                <div class=""col-md-12"">
                    <h1>");
#nullable restore
#line 52 "D:\MVC Practice\BookStore\WebGentle_BookStore\WebGentle_BookStore\Views\Book\GetBook.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    <p>By- ");
#nullable restore
#line 57 "D:\MVC Practice\BookStore\WebGentle_BookStore\WebGentle_BookStore\Views\Book\GetBook.cshtml"
                      Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-md-12\">\r\n                    <p class=\"description\">");
#nullable restore
#line 62 "D:\MVC Practice\BookStore\WebGentle_BookStore\WebGentle_BookStore\Views\Book\GetBook.cshtml"
                                      Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                </div>
            </div>

            <div class=""row"">
                <div class=""col-md-4"">
                    <a class=""btn btn-outline-primary"" data-toggle=""modal"" data-target=""#exampleModal"">
                        Read now
                    </a>
                </div>
            </div>

            <hr />
            <ul class=""list-group"">
                <li class=""list-group-item""><span class=""font-weight-bold"">Category- </span><b>");
#nullable restore
#line 76 "D:\MVC Practice\BookStore\WebGentle_BookStore\WebGentle_BookStore\Views\Book\GetBook.cshtml"
                                                                                          Write(Model.Category);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></li>\r\n                <li class=\"list-group-item\"><span class=\"font-weight-bold\">Total Pages- </span><b>");
#nullable restore
#line 77 "D:\MVC Practice\BookStore\WebGentle_BookStore\WebGentle_BookStore\Views\Book\GetBook.cshtml"
                                                                                             Write(Model.TotalPages);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></li>\r\n                <li class=\"list-group-item\"><span class=\"font-weight-bold\">Language- </span><b>");
#nullable restore
#line 78 "D:\MVC Practice\BookStore\WebGentle_BookStore\WebGentle_BookStore\Views\Book\GetBook.cshtml"
                                                                                          Write(Model.Language);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</b></li>
            </ul>
        </div>

        
        <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
            <div class=""modal-dialog modal-lg"" role=""document"">
                <div class=""modal-content"">
                    <div class=""modal-header"">
                       
                        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                            <span aria-hidden=""true"">&times;</span>
                        </button>
                    </div>
                    <div class=""modal-body"">
");
            WriteLiteral("                        <iframe");
            BeginWriteAttribute("src", " src=\"", 4345, "\"", 4368, 1);
#nullable restore
#line 94 "D:\MVC Practice\BookStore\WebGentle_BookStore\WebGentle_BookStore\Views\Book\GetBook.cshtml"
WriteAttributeValue("", 4351, Model.BookPdfUrl, 4351, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""w-100""></iframe>
                    </div>
                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    
                    </div>
                </div>
            </div>
        </div>
       
        <hr />
        <div id=""similarBooks"">
            <div class=""h4"">Similar Books</div>
            <div class=""row"">
");
#nullable restore
#line 108 "D:\MVC Practice\BookStore\WebGentle_BookStore\WebGentle_BookStore\Views\Book\GetBook.cshtml"
                 for (int i = 0; i < 5; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-md-4"">
                        <div class=""card mb-4 shadow-sm"">
                            <svg class=""bd-placeholder-img  card-img-top"" width=""100%"" height=""50"" style=""background-color:cornflowerblue""></svg>
                            <div class=""card-body"">
                                <h3 class=""card-title"">Title</h3>
                                <p class=""card-text"">Description</p>

                                <div class=""d-flex justify-content-between align-content-center"">
                                    <div class=""btn-group"">
                                        <a href=""#"" class=""btn btn-sm btn-outline-secondary"">View Details...</a>

                                    </div>
                                    <small class=""text-muted"">Author</small>
                                </div>
                            </div>
                        </div>

                    </div>
");
#nullable restore
#line 128 "D:\MVC Practice\BookStore\WebGentle_BookStore\WebGentle_BookStore\Views\Book\GetBook.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
