#pragma checksum "C:\Users\ASUS\source\repos\MovieApp\Views\Shared\Components\Genres\Default.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "06d7cd99f3bff3ed5383b757e1d6bbf92089a959905cb41b27533d46d32cfbb0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Genres_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Genres/Default.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\ASUS\source\repos\MovieApp\Views\_ViewImports.cshtml"
using MovieApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\source\repos\MovieApp\Views\_ViewImports.cshtml"
using MovieApp.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\source\repos\MovieApp\Views\_ViewImports.cshtml"
using MovieApp.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"06d7cd99f3bff3ed5383b757e1d6bbf92089a959905cb41b27533d46d32cfbb0", @"/Views/Shared/Components/Genres/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"d67bfcbb5bc7233516c3a74d665f96e6625434f9fe0359fefa6cc10784766734", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Genres_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Genre>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"list-group\" style=\"padding: 20px;width: 100%;margin-top: 20px;\">\r\n    <a href=\"/movies/list/\" class=\"btn btn-outline-secondary\" style=\"margin: 5px;\">All Films</a>\r\n");
#nullable restore
#line 5 "C:\Users\ASUS\source\repos\MovieApp\Views\Shared\Components\Genres\Default.cshtml"
     foreach (var genre in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a");
            BeginWriteAttribute("href", " href=\"", 250, "\"", 284, 2);
            WriteAttributeValue("", 257, "/movies/list/", 257, 13, true);
#nullable restore
#line 7 "C:\Users\ASUS\source\repos\MovieApp\Views\Shared\Components\Genres\Default.cshtml"
WriteAttributeValue("", 270, genre.GenreId, 270, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-secondary\" style=\"margin: 5px;\">");
#nullable restore
#line 7 "C:\Users\ASUS\source\repos\MovieApp\Views\Shared\Components\Genres\Default.cshtml"
                                                                                                Write(genre.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 8 "C:\Users\ASUS\source\repos\MovieApp\Views\Shared\Components\Genres\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Genre>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
