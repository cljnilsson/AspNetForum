#pragma checksum "G:\Personal Projects\aspnetcoreapp\Pages\section\thread.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "48a44518171655a9667b6dd5694237b2f341bec6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(aspnetcoreapp.Pages.section.Pages_section_thread), @"mvc.1.0.razor-page", @"/Pages/section/thread.cshtml")]
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
#line 3 "G:\Personal Projects\aspnetcoreapp\Pages\section\thread.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/section/{sec}/{id:int}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"48a44518171655a9667b6dd5694237b2f341bec6", @"/Pages/section/thread.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e70cdf4260bd324b075540e3ddbd00028c5e8dfc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_section_thread : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("avatar mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("postform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"threadHeader row\">\r\n\t<div class=\"col\">\r\n\t\t<h3 class=\"m-2 ser\">");
#nullable restore
#line 7 "G:\Personal Projects\aspnetcoreapp\Pages\section\thread.cshtml"
                       Write(Model.thread.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\t</div>\r\n\t<div class=\"col text-right text-muted align-self-center\">\r\n\t\t<p class=\"mb-0\">");
#nullable restore
#line 10 "G:\Personal Projects\aspnetcoreapp\Pages\section\thread.cshtml"
                   Write(Model.thread.date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t</div>\r\n</div>\r\n<div class=\"row\">\r\n\t<div class=\"col-sm-2 text-center\">\r\n\t\t<a");
            BeginWriteAttribute("href", " href=\"", 378, "\"", 423, 2);
            WriteAttributeValue("", 385, "/profile/", 385, 9, true);
#nullable restore
#line 15 "G:\Personal Projects\aspnetcoreapp\Pages\section\thread.cshtml"
WriteAttributeValue("", 394, Model.thread.author.Username, 394, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><h5 class=\"mt-2\"");
            BeginWriteAttribute("style", " style=\"", 441, "\"", 487, 3);
            WriteAttributeValue("", 449, "color:", 449, 6, true);
#nullable restore
#line 15 "G:\Personal Projects\aspnetcoreapp\Pages\section\thread.cshtml"
WriteAttributeValue("", 455, Model.thread.author.Rank.color, 455, 31, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 486, ";", 486, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 15 "G:\Personal Projects\aspnetcoreapp\Pages\section\thread.cshtml"
                                                                                                                    Write(Model.thread.author.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5></a>\r\n\t\t<small>");
#nullable restore
#line 16 "G:\Personal Projects\aspnetcoreapp\Pages\section\thread.cshtml"
          Write(Model.thread.author.Rank.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small><br>\r\n\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "48a44518171655a9667b6dd5694237b2f341bec66775", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 614, "~/images/avatars/", 614, 17, true);
#nullable restore
#line 17 "G:\Personal Projects\aspnetcoreapp\Pages\section\thread.cshtml"
AddHtmlAttributeValue("", 631, Model.thread.author.avatar, 631, 27, false);

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
            WriteLiteral("\r\n\t\t<p>Posts: ");
#nullable restore
#line 18 "G:\Personal Projects\aspnetcoreapp\Pages\section\thread.cshtml"
             Write(Model.thread.author.posts);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t</div>\r\n\t<div class=\"col pl-0\">\r\n\t\t<p class=\"mt-2\">");
#nullable restore
#line 21 "G:\Personal Projects\aspnetcoreapp\Pages\section\thread.cshtml"
                   Write(Html.Raw(Model.thread.post));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t</div>\r\n</div>\r\n");
#nullable restore
#line 24 "G:\Personal Projects\aspnetcoreapp\Pages\section\thread.cshtml"
 foreach(var p in Model.posts)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t<div class=\"post row\">\r\n\t\t<div class=\"col-sm-2 text-center\">\r\n\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 912, "\"", 946, 2);
            WriteAttributeValue("", 919, "/profile/", 919, 9, true);
#nullable restore
#line 28 "G:\Personal Projects\aspnetcoreapp\Pages\section\thread.cshtml"
WriteAttributeValue("", 928, p.author.Username, 928, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><h5 class=\"mt-2\"");
            BeginWriteAttribute("style", " style=\"", 964, "\"", 999, 3);
            WriteAttributeValue("", 972, "color:", 972, 6, true);
#nullable restore
#line 28 "G:\Personal Projects\aspnetcoreapp\Pages\section\thread.cshtml"
WriteAttributeValue("", 978, p.author.Rank.color, 978, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 998, ";", 998, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "G:\Personal Projects\aspnetcoreapp\Pages\section\thread.cshtml"
                                                                                                  Write(p.author.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5></a>\r\n\t\t\t<small>");
#nullable restore
#line 29 "G:\Personal Projects\aspnetcoreapp\Pages\section\thread.cshtml"
              Write(p.author.Rank.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small><br>\r\n\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "48a44518171655a9667b6dd5694237b2f341bec610688", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1106, "~/images/avatars/", 1106, 17, true);
#nullable restore
#line 30 "G:\Personal Projects\aspnetcoreapp\Pages\section\thread.cshtml"
AddHtmlAttributeValue("", 1123, p.author.avatar, 1123, 16, false);

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
            WriteLiteral("\r\n\t\t\t<p>Posts: ");
#nullable restore
#line 31 "G:\Personal Projects\aspnetcoreapp\Pages\section\thread.cshtml"
                 Write(p.author.posts);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t</div>\r\n\t\t<div class=\"col\">\r\n\t\t\t<div class=\"row\">\r\n\t\t\t\t<div class=\"col postfield\">\r\n\t\t\t\t\t<p class=\"mt-2\">");
#nullable restore
#line 36 "G:\Personal Projects\aspnetcoreapp\Pages\section\thread.cshtml"
                               Write(Html.Raw(p.post));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\t\t\t\t</div>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n\t<div class=\"row\">\r\n\t\t<div class=\"col-sm-2\">\r\n\t\t</div>\r\n\t\t<div class=\"col text-muted\">\r\n\t\t\t<small>");
#nullable restore
#line 45 "G:\Personal Projects\aspnetcoreapp\Pages\section\thread.cshtml"
              Write(p.date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n\t\t</div>\r\n\t</div>\r\n");
#nullable restore
#line 48 "G:\Personal Projects\aspnetcoreapp\Pages\section\thread.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n\t\t<div class=\"col\">\r\n");
#nullable restore
#line 51 "G:\Personal Projects\aspnetcoreapp\Pages\section\thread.cshtml"
              
				var user = new Byte[20];
				var exists = HttpContext.Session.TryGetValue("username", out user);

				if(exists) {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "48a44518171655a9667b6dd5694237b2f341bec613845", async() => {
                WriteLiteral("\r\n\t\t\t\t\t\t<div id=\"editor-container\" style=\"height: 300px\">\r\n\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t<input name=\"author\" style=\"display:none\"");
                BeginWriteAttribute("value", " value=\"", 1824, "\"", 1874, 1);
#nullable restore
#line 60 "G:\Personal Projects\aspnetcoreapp\Pages\section\thread.cshtml"
WriteAttributeValue("", 1832, HttpContext.Session.GetString("username"), 1832, 42, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\t\t\t\t\t\t<textarea name=\"text\" style=\"display:none\" id=\"hiddenArea\"></textarea>\r\n\t\t\t\t\t\t<input name=\"thread\" style=\"display:none\"/");
                BeginWriteAttribute("value", " value=\"", 2004, "\"", 2035, 1);
#nullable restore
#line 62 "G:\Personal Projects\aspnetcoreapp\Pages\section\thread.cshtml"
WriteAttributeValue("", 2012, RouteData.Values["id"], 2012, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n\r\n\t\t\t\t\t\t<button type=\"submit\" class=\"btn btn-outline-light mt-3\">Create Thread</button>\r\n\t\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral(" \t\t\t\t\t<script src=\"https://unpkg.com/quill-image-uploader@1.2.1/dist/quill.imageUploader.min.js\"></script>\r\n");
            WriteLiteral(@"					<script>
						Quill.register(""modules/imageUploader"", ImageUploader);

						let options = {
							modules: {
								toolbar: [
									[{ header: [1, 2, false] }],
									['bold', 'italic', 'underline'],
									['image', 'code-block']
								],
								// Default example, should update with await/async in the future
								imageUploader: {
									upload: file => {
										return new Promise((resolve, reject) => {
											const formData = new FormData();
											formData.append(""image"", file);

											fetch(
												""https://api.imgbb.com/1/upload?key=b98e506bd1b9d97bfdbc67cc99711a6b"",
												{
												method: ""POST"",
												body: formData
												}
											)
											.then(response => response.json())
											.then(result => {
												console.log(result);
												resolve(result.data.url);
											})
											.catch(error => {
												reject(""Upload failed"");
												console.error(""Error:"", error);
");
            WriteLiteral(@"											});
										});
									}
								}
							},
							theme: 'snow'  // or 'bubble'
						};

						var quill = new Quill('#editor-container', options);

						$(""#postform"").on(""submit"", function(){
							$(""#hiddenArea"").val($(""#editor-container > .ql-editor"").html());
						});
					</script>
");
#nullable restore
#line 115 "G:\Personal Projects\aspnetcoreapp\Pages\section\thread.cshtml"
				} else {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<div class=\"text-center\">\r\n\t\t\t\t\t\t<h3>You need you log in to make a post a reply</h3>\r\n\t\t\t\t\t</div>\r\n");
#nullable restore
#line 119 "G:\Personal Projects\aspnetcoreapp\Pages\section\thread.cshtml"
				}
			

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t</div>\r\n\t</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ThreadModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ThreadModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ThreadModel>)PageContext?.ViewData;
        public ThreadModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
