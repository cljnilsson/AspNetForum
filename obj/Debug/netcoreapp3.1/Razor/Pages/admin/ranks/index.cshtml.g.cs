#pragma checksum "G:\Personal Projects\aspnetcoreapp\Pages\admin\ranks\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90b5358cd21392af935735d0e1d48d3839f05b04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(aspnetcoreapp.Pages.admin.ranks.Pages_admin_ranks_index), @"mvc.1.0.razor-page", @"/Pages/admin/ranks/index.cshtml")]
namespace aspnetcoreapp.Pages.admin.ranks
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/admin/ranks")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90b5358cd21392af935735d0e1d48d3839f05b04", @"/Pages/admin/ranks/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e70cdf4260bd324b075540e3ddbd00028c5e8dfc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_admin_ranks_index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\Personal Projects\aspnetcoreapp\Pages\admin\ranks\index.cshtml"
  
    Layout = "admin";

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t<th scope=\"col\">#</th>\r\n\t\t\t<th scope=\"col\">Name</th>\r\n\t\t\t<th scope=\"col\">Powers</th>\r\n\t\t</tr>\r\n\t</thead>\r\n\t<tbody>\r\n");
#nullable restore
#line 15 "G:\Personal Projects\aspnetcoreapp\Pages\admin\ranks\index.cshtml"
          int i = 1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "G:\Personal Projects\aspnetcoreapp\Pages\admin\ranks\index.cshtml"
         foreach(var r in Model.ranks)
		{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<th scope=\"row\">");
#nullable restore
#line 19 "G:\Personal Projects\aspnetcoreapp\Pages\admin\ranks\index.cshtml"
                           Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t<td><a");
            BeginWriteAttribute("href", " href=\"", 339, "\"", 366, 2);
            WriteAttributeValue("", 346, "/admin/ranks/", 346, 13, true);
#nullable restore
#line 20 "G:\Personal Projects\aspnetcoreapp\Pages\admin\ranks\index.cshtml"
WriteAttributeValue("", 359, r.name, 359, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("style", " style=\"", 367, "\"", 390, 3);
            WriteAttributeValue("", 375, "color:", 375, 6, true);
#nullable restore
#line 20 "G:\Personal Projects\aspnetcoreapp\Pages\admin\ranks\index.cshtml"
WriteAttributeValue("", 381, r.color, 381, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 389, ";", 389, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 20 "G:\Personal Projects\aspnetcoreapp\Pages\admin\ranks\index.cshtml"
                                                                      Write(r.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></td>\r\n");
#nullable restore
#line 21 "G:\Personal Projects\aspnetcoreapp\Pages\admin\ranks\index.cshtml"
                 if(r.delete == true || r.edit == true || r.controlPanel == true) {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<td>Yes</td>\r\n");
#nullable restore
#line 23 "G:\Personal Projects\aspnetcoreapp\Pages\admin\ranks\index.cshtml"
				} else {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<td>No</td>\r\n");
#nullable restore
#line 25 "G:\Personal Projects\aspnetcoreapp\Pages\admin\ranks\index.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<td class=\"text-right\"><a");
            BeginWriteAttribute("href", " href=\"", 570, "\"", 602, 3);
            WriteAttributeValue("", 577, "/admin/ranks/", 577, 13, true);
#nullable restore
#line 26 "G:\Personal Projects\aspnetcoreapp\Pages\admin\ranks\index.cshtml"
WriteAttributeValue("", 590, r.name, 590, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 597, "/edit", 597, 5, true);
            EndWriteAttribute();
            WriteLiteral(">Edit<a> Copy Delete</td>\r\n\t\t\t</tr>\r\n");
#nullable restore
#line 28 "G:\Personal Projects\aspnetcoreapp\Pages\admin\ranks\index.cshtml"
			i++;
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t</tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AdminRankModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AdminRankModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<AdminRankModel>)PageContext?.ViewData;
        public AdminRankModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
