#pragma checksum "G:\Personal Projects\aspnetcoreapp\Pages\search\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "505a1f106484f635465526f571bde8cfd09498aa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(aspnetcoreapp.Pages.search.Pages_search_index), @"mvc.1.0.razor-page", @"/Pages/search/index.cshtml")]
namespace aspnetcoreapp.Pages.search
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
#line 1 "G:\Personal Projects\aspnetcoreapp\Pages\_ViewImports.cshtml"
using aspnetcoreapp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"505a1f106484f635465526f571bde8cfd09498aa", @"/Pages/search/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e70cdf4260bd324b075540e3ddbd00028c5e8dfc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_search_index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "G:\Personal Projects\aspnetcoreapp\Pages\search\index.cshtml"
 foreach(var p in Model.result)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<a");
            BeginWriteAttribute("href", " href=\"", 68, "\"", 119, 4);
            WriteAttributeValue("", 75, "/section/", 75, 9, true);
#nullable restore
#line 6 "G:\Personal Projects\aspnetcoreapp\Pages\search\index.cshtml"
WriteAttributeValue("", 84, p.thread.section.Name, 84, 22, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 106, "/", 106, 1, true);
#nullable restore
#line 6 "G:\Personal Projects\aspnetcoreapp\Pages\search\index.cshtml"
WriteAttributeValue("", 107, p.thread.id, 107, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><h3>");
#nullable restore
#line 6 "G:\Personal Projects\aspnetcoreapp\Pages\search\index.cshtml"
                                                          Write(p.thread.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3></a>\r\n");
#nullable restore
#line 7 "G:\Personal Projects\aspnetcoreapp\Pages\search\index.cshtml"
Write(p.post);

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<br>\r\n\t<a");
            BeginWriteAttribute("href", " href=\"", 170, "\"", 204, 2);
            WriteAttributeValue("", 177, "/profile/", 177, 9, true);
#nullable restore
#line 9 "G:\Personal Projects\aspnetcoreapp\Pages\search\index.cshtml"
WriteAttributeValue("", 186, p.author.Username, 186, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><small");
            BeginWriteAttribute("style", " style=\"", 212, "\"", 247, 3);
            WriteAttributeValue("", 220, "color:", 220, 6, true);
#nullable restore
#line 9 "G:\Personal Projects\aspnetcoreapp\Pages\search\index.cshtml"
WriteAttributeValue("", 226, p.author.Rank.color, 226, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 246, ";", 246, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 9 "G:\Personal Projects\aspnetcoreapp\Pages\search\index.cshtml"
                                                                                Write(p.author.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></a>\r\n\t<small>, </small>\r\n\t<small class=\"text-muted\">");
#nullable restore
#line 11 "G:\Personal Projects\aspnetcoreapp\Pages\search\index.cshtml"
                         Write(p.date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n\t<br><br>\r\n");
#nullable restore
#line 13 "G:\Personal Projects\aspnetcoreapp\Pages\search\index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SearchModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SearchModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SearchModel>)PageContext?.ViewData;
        public SearchModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
