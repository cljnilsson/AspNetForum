#pragma checksum "G:\Personal Projects\aspnetcoreapp\Pages\section\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a71af9686df5fdedf5fbb20b3d1c0366c46495f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(aspnetcoreapp.Pages.section.Pages_section_index), @"mvc.1.0.razor-page", @"/Pages/section/index.cshtml")]
namespace aspnetcoreapp.Pages.section
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
#nullable restore
#line 3 "G:\Personal Projects\aspnetcoreapp\Pages\section\index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/section/{sec}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a71af9686df5fdedf5fbb20b3d1c0366c46495f7", @"/Pages/section/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e70cdf4260bd324b075540e3ddbd00028c5e8dfc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_section_index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"row\">\r\n\t<table class=\"table\">\r\n\t\t<thead>\r\n\t\t\t<tr>\r\n\t\t\t\t<th><h3>");
#nullable restore
#line 9 "G:\Personal Projects\aspnetcoreapp\Pages\section\index.cshtml"
                   Write(RouteData.Values["sec"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3></th>\r\n\t\t\t\t<th class=\"text-center\">Comments</th>\r\n\t\t\t\t<th class=\"text-center\">Views</th>\r\n\t\t\t\t<th></th>\r\n\t\t\t</tr>\r\n\t\t</thead>\r\n\t\t<tbody>\r\n");
#nullable restore
#line 16 "G:\Personal Projects\aspnetcoreapp\Pages\section\index.cshtml"
             foreach(var t in Model.threads)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<tr class=\"thread\">\r\n\t\t\t\t\t<th class=\"align-middle\"><a");
            BeginWriteAttribute("href", " href=\"", 423, "\"", 469, 4);
            WriteAttributeValue("", 430, "/section/", 430, 9, true);
#nullable restore
#line 19 "G:\Personal Projects\aspnetcoreapp\Pages\section\index.cshtml"
WriteAttributeValue("", 439, RouteData.Values["sec"], 439, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 463, "/", 463, 1, true);
#nullable restore
#line 19 "G:\Personal Projects\aspnetcoreapp\Pages\section\index.cshtml"
WriteAttributeValue("", 464, t.id, 464, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 19 "G:\Personal Projects\aspnetcoreapp\Pages\section\index.cshtml"
                                                                                          Write(t.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></th>\r\n\t\t\t\t\t<td class=\"text-center align-middle\">");
#nullable restore
#line 20 "G:\Personal Projects\aspnetcoreapp\Pages\section\index.cshtml"
                                                    Write(Model.comments[t]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t<td class=\"text-center align-middle\">");
#nullable restore
#line 21 "G:\Personal Projects\aspnetcoreapp\Pages\section\index.cshtml"
                                                    Write(t.views);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t<td class=\"text-right\">\r\n\t\t\t\t\t\t<small class=\"user\">");
#nullable restore
#line 23 "G:\Personal Projects\aspnetcoreapp\Pages\section\index.cshtml"
                                       Write(t.latestSource);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small><br>\r\n\t\t\t\t\t\t<small>");
#nullable restore
#line 24 "G:\Personal Projects\aspnetcoreapp\Pages\section\index.cshtml"
                          Write(t.latest);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n\t\t\t\t\t</td>\r\n\t\t\t\t</tr>\r\n");
#nullable restore
#line 27 "G:\Personal Projects\aspnetcoreapp\Pages\section\index.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</tbody>\r\n\t</table>\r\n");
#nullable restore
#line 30 "G:\Personal Projects\aspnetcoreapp\Pages\section\index.cshtml"
      
		var user = new Byte[20];
		var exists = HttpContext.Session.TryGetValue("username", out user);
		if(exists) {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 907, "\"", 957, 3);
            WriteAttributeValue("", 914, "/section/", 914, 9, true);
#nullable restore
#line 34 "G:\Personal Projects\aspnetcoreapp\Pages\section\index.cshtml"
WriteAttributeValue("", 923, RouteData.Values["sec"], 923, 24, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 947, "/newthread", 947, 10, true);
            EndWriteAttribute();
            WriteLiteral("><button class=\"btn btn-outline-primary ml-3\">Create New Thread</button></a>\r\n");
#nullable restore
#line 35 "G:\Personal Projects\aspnetcoreapp\Pages\section\index.cshtml"
		}
	

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SectionModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SectionModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<SectionModel>)PageContext?.ViewData;
        public SectionModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
