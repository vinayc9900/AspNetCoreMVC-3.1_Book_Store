#pragma checksum "D:\MVC Practice\BookStore\WebGentle_BookStore\WebGentle_BookStore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f0f017fd4354ae11908b0dbcd1efb214882bc1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f0f017fd4354ae11908b0dbcd1efb214882bc1f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"611ca1d46faea3cb91794e6382ede8007fea872c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\MVC Practice\BookStore\WebGentle_BookStore\WebGentle_BookStore\Views\Home\Index.cshtml"
   
    //ViewData["Title"] = "Home";
    dynamic data = ViewBag.data;


#line default
#line hidden
#nullable disable
            WriteLiteral("    <section class=\"jumbotron text-center\">\r\n\r\n        <div class=\"container\">\r\n            <h1>Wel come to Book Store</h1>\r\n\r\n");
            WriteLiteral("\r\n            <p class=\"lead text-muted\">\r\n                This ia an Book Store Appliacation where we can search the Book\r\n");
            WriteLiteral("                ");
#nullable restore
#line 25 "D:\MVC Practice\BookStore\WebGentle_BookStore\WebGentle_BookStore\Views\Home\Index.cshtml"
           Write(data.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                ");
#nullable restore
#line 26 "D:\MVC Practice\BookStore\WebGentle_BookStore\WebGentle_BookStore\Views\Home\Index.cshtml"
           Write(data.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                Id=");
#nullable restore
#line 27 "D:\MVC Practice\BookStore\WebGentle_BookStore\WebGentle_BookStore\Views\Home\Index.cshtml"
              Write(ViewBag.Type.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                Author=");
#nullable restore
#line 28 "D:\MVC Practice\BookStore\WebGentle_BookStore\WebGentle_BookStore\Views\Home\Index.cshtml"
                  Write(ViewBag.Type.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </p>
            <a href=""#"" class=""btn btn-primary"">Search Books</a>
        </div>
        <div class=""py-5 bg-light"">
            <h3 class=""h3"">Top Books</h3>
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-4"">
                        <div class=""card"">
");
            WriteLiteral(@"                            <p>Animation Books</p>
                            <div class=""card-body"">
                                <p class=""card-text"">
                                    This is for Book info
                                </p>
                                
                            </div>
                            <div class=""btn-group"">
                                <a href=""#"" class=""btn btn-sm btn-outline-secondary"">More..</a>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-4"">
                        <div class=""card"">
");
            WriteLiteral(@"                            <p class=""card-text"">Old Books</p>
                            <div class=""card-body"">
                                <p>Book 1</p>
                                <p>Book 2</p>
                                <p>Book 3</p>
                            </div>
                            <div class=""card-footer"">
                                <p>More Info...</p>
                            </div>
                        </div>
                    </div>
                    <div class=""col-md-4"">
                        <div class=""card"">
");
            WriteLiteral(@"                            <p>New Books</p>
                            <div class=""card-body"">
                                <p>Book 1</p>
                                <p>Book 2</p>
                                <p>Book 3</p>
                            </div>
                            <div class=""card-footer"">
                                <p>More Info...</p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>
");
            DefineSection("scripts", async() => {
                WriteLiteral(" \r\n\r\n<script>\r\n    $(document).ready(function () {\r\n        //alert(\"Hi..\");\r\n    });\r\n</script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
