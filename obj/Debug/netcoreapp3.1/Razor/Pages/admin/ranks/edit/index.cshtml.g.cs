#pragma checksum "G:\Personal Projects\aspnetcoreapp\Pages\admin\ranks\edit\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "829f69d7790e35c84faf8b2b8f2dc91592fd2b0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(aspnetcoreapp.Pages.admin.ranks.edit.Pages_admin_ranks_edit_index), @"mvc.1.0.razor-page", @"/Pages/admin/ranks/edit/index.cshtml")]
namespace aspnetcoreapp.Pages.admin.ranks.edit
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/admin/ranks/{r}/edit")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"829f69d7790e35c84faf8b2b8f2dc91592fd2b0f", @"/Pages/admin/ranks/edit/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e70cdf4260bd324b075540e3ddbd00028c5e8dfc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_admin_ranks_edit_index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mt-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\Personal Projects\aspnetcoreapp\Pages\admin\ranks\edit\index.cshtml"
  
    Layout = "admin";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "829f69d7790e35c84faf8b2b8f2dc91592fd2b0f4043", async() => {
                WriteLiteral("\r\n\t<div class=\"row\">\r\n\t\t<div class=\"col\">\r\n\t\t\t<div class=\"input-group\">\r\n\t\t\t\t<div class=\"input-group-prepend\">\r\n\t\t\t\t\t<div class=\"input-group-text\">Name</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t<input type=\"text\" class=\"form-control\" placeholder=\"Name\" name=\"name\"");
                BeginWriteAttribute("value", " value=\"", 363, "\"", 387, 1);
#nullable restore
#line 14 "G:\Personal Projects\aspnetcoreapp\Pages\admin\ranks\edit\index.cshtml"
WriteAttributeValue("", 371, Model.rank.name, 371, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<div class=\"col\">\r\n\t\t\t\t\t\t<div class=\"input-group\">\r\n\t\t\t\t<div class=\"input-group-prepend\">\r\n\t\t\t\t\t<div class=\"input-group-text\">Color</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t<input type=\"text\" class=\"form-control\" placeholder=\"Name\" name=\"color\"");
                BeginWriteAttribute("value", " value=\"", 640, "\"", 665, 1);
#nullable restore
#line 22 "G:\Personal Projects\aspnetcoreapp\Pages\admin\ranks\edit\index.cshtml"
WriteAttributeValue("", 648, Model.rank.color, 648, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n  <div class=\"row mt-2\">\r\n\t\t<div class=\"col-auto my-1\">\r\n\t\t\t<div class=\"form-check\">\r\n\t\t\t\t<input class=\"form-check-input\" type=\"checkbox\" name=\"post\"");
                BeginWriteAttribute("checked", " checked=\"", 848, "\"", 874, 1);
#nullable restore
#line 29 "G:\Personal Projects\aspnetcoreapp\Pages\admin\ranks\edit\index.cshtml"
WriteAttributeValue("", 858, Model.rank.post, 858, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t<label class=\"form-check-label\">\r\n\t\t\t\t\tCan post\r\n\t\t\t\t</label>\r\n\t\t\t</div>\r\n\t\t</div>\r\n  </div>\r\n    <div class=\"row mt-2\">\r\n\t\t<div class=\"col-auto my-1\">\r\n\t\t\t<div class=\"form-check\">\r\n\t\t\t\t<input class=\"form-check-input\" type=\"checkbox\" name=\"edit\"");
                BeginWriteAttribute("checked", " checked=\"", 1127, "\"", 1153, 1);
#nullable restore
#line 39 "G:\Personal Projects\aspnetcoreapp\Pages\admin\ranks\edit\index.cshtml"
WriteAttributeValue("", 1137, Model.rank.edit, 1137, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t<label class=\"form-check-label\">\r\n\t\t\t\t\tCan edit\r\n\t\t\t\t</label>\r\n\t\t\t</div>\r\n\t\t</div>\r\n  </div>\r\n    <div class=\"row mt-2\">\r\n\t\t<div class=\"col-auto my-1\">\r\n\t\t\t<div class=\"form-check\">\r\n\t\t\t\t<input class=\"form-check-input\" type=\"checkbox\" name=\"delete\"");
                BeginWriteAttribute("checked", " checked=\"", 1408, "\"", 1436, 1);
#nullable restore
#line 49 "G:\Personal Projects\aspnetcoreapp\Pages\admin\ranks\edit\index.cshtml"
WriteAttributeValue("", 1418, Model.rank.delete, 1418, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
				<label class=""form-check-label"">
					Can delete
				</label>
			</div>
		</div>
  </div>
    <div class=""row mt-2"">
		<div class=""col-auto my-1"">
			<div class=""form-check"">
				<input class=""form-check-input"" type=""checkbox"" name=""controlPanel""");
                BeginWriteAttribute("checked", " checked=\"", 1699, "\"", 1733, 1);
#nullable restore
#line 59 "G:\Personal Projects\aspnetcoreapp\Pages\admin\ranks\edit\index.cshtml"
WriteAttributeValue("", 1709, Model.rank.controlPanel, 1709, 24, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(")>\r\n\t\t\t\t<label class=\"form-check-label\">\r\n\t\t\t\t\tControl Panel Access\r\n\t\t\t\t</label>\r\n\t\t\t</div>\r\n\t\t</div>\r\n  </div>\r\n\r\n  <button type=\"submit\" class=\"btn btn-outline-primary\">Save</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RankEditModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RankEditModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RankEditModel>)PageContext?.ViewData;
        public RankEditModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
