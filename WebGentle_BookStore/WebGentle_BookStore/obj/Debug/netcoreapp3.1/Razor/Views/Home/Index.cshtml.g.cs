#pragma checksum "D:\MVC Practice\BookStore\WebGentle_BookStore\WebGentle_BookStore\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5212cebdc069e27c532622ba90c2e8efe36a7315"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5212cebdc069e27c532622ba90c2e8efe36a7315", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

    <section class=""jumbotron text-center"">

        <div class=""container"">
            <h1>Wel come to Book Store</h1>
            <p class=""lead text-muted"">
                This ia an Book Store Appliacation where we can search the Book
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
