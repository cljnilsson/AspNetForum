#pragma checksum "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b0311a9ef7db4e0b241bd5213a49bafe7e1fe4d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(aspnetcoreapp.Pages.profile.Pages_profile_index), @"mvc.1.0.razor-page", @"/Pages/profile/index.cshtml")]
namespace aspnetcoreapp.Pages.profile
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
#line 3 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/profile/{user}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b0311a9ef7db4e0b241bd5213a49bafe7e1fe4d", @"/Pages/profile/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e70cdf4260bd324b075540e3ddbd00028c5e8dfc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_profile_index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("avatarBig"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/default-avatar.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("avatarSmall"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div id=\"profile\" class=\"row mt-3\">\r\n\t");
#nullable restore
#line 6 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t<div class=\"col-sm-3\">\r\n\t\t<div class=\"text-center\">\r\n\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2b0311a9ef7db4e0b241bd5213a49bafe7e1fe4d5177", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t</div>\r\n\t\t<hr>\r\n\t\t<div class=\"row\">\r\n\t\t\t<div class=\"col\">\r\n\t\t\t\tPosts:\r\n\t\t\t</div>\r\n\t\t\t<div class=\"col text-right\">\r\n\t\t\t\t");
#nullable restore
#line 17 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
           Write(Model.owner.posts);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<div class=\"row\">\r\n\t\t\t<div class=\"col\">\r\n\t\t\t\tLast Login:\r\n\t\t\t</div>\r\n\t\t\t<div class=\"col text-right\">\r\n\t\t\t\t");
#nullable restore
#line 25 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
           Write(Model.owner.lastLogin.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 25 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
                                       Write(Model.owner.lastLogin.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 25 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
                                                                    Write(Model.owner.lastLogin.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<div class=\"row\">\r\n\t\t\t<div class=\"col\">\r\n\t\t\t\tJoined:\r\n\t\t\t</div>\r\n\t\t\t<div class=\"col text-right\">\r\n\t\t\t\t");
#nullable restore
#line 33 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
           Write(Model.owner.created.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 33 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
                                     Write(Model.owner.created.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 33 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
                                                                Write(Model.owner.created.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<a");
            BeginWriteAttribute("href", " href=\"", 846, "\"", 889, 3);
            WriteAttributeValue("", 853, "/profile/", 853, 9, true);
#nullable restore
#line 36 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
WriteAttributeValue("", 862, Model.owner.Username, 862, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 883, "/posts", 883, 6, true);
            EndWriteAttribute();
            WriteLiteral(">Recent posts</a>\r\n\t</div>\r\n\t<div class=\"col\">\r\n\t\t<h3 class=\"user\">");
#nullable restore
#line 39 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
                    Write(Model.owner.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\t\t");
#nullable restore
#line 40 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
   Write(Model.owner.Rank);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t<hr>\r\n");
#nullable restore
#line 42 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
          
			var user = new Byte[20];
			var exists = HttpContext.Session.TryGetValue("username", out user);
			if(exists) {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2b0311a9ef7db4e0b241bd5213a49bafe7e1fe4d9881", async() => {
                WriteLiteral("\r\n\t\t\t\t\t<textarea class=\"w-100 form-control\" name=\"profileMessage\" placeholder=\"your message\"></textarea>\r\n\t\t\t\t\t<div class=\"text-right mt-1\">\r\n\t\t\t\t\t\t<button type=\"submit\" class=\"btn btn-outline-primary\">Post</button>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t<br><br>\r\n");
#nullable restore
#line 53 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
			}
		

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t<div>\r\n");
#nullable restore
#line 56 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
             foreach(var p in Model.profilePosts)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t<div class=\"col-sm-1\">\r\n\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2b0311a9ef7db4e0b241bd5213a49bafe7e1fe4d12118", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t<div class=\"col\" data-id=\"");
#nullable restore
#line 62 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
                                         Write(p.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">\r\n\t\t\t\t\t\t<div class=\"row profilemessage\">\r\n\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 1708, "\"", 1742, 2);
            WriteAttributeValue("", 1715, "/profile/", 1715, 9, true);
#nullable restore
#line 64 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
WriteAttributeValue("", 1724, p.author.Username, 1724, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"user\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 65 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
                           Write(p.author.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t<span>&nbsp;");
#nullable restore
#line 67 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
                                   Write(p.post);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 69 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
                          
							user 		= new Byte[20];
							exists 		= HttpContext.Session.TryGetValue("username", out user);
						

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t\t<div class=\"col-sm-auto pl-0 pr-0\">\r\n\t\t\t\t\t\t\t\t<small class=\"text-muted\">");
#nullable restore
#line 75 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
                                                     Write(p.date.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 75 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
                                                                  Write(p.date.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 75 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
                                                                                Write(p.date.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 77 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
                             if(HttpContext.Session.GetString("username") == p.author.Username) {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<div class=\"col-sm-auto pr-0\">\r\n\t\t\t\t\t\t\t\t\t<a class=\"ProfileMessageEdit\"");
            BeginWriteAttribute("href", " href=\"", 2295, "\"", 2302, 0);
            EndWriteAttribute();
            WriteLiteral("><small>Edit</small></a>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"col-sm-auto\">\r\n\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 2391, "\"", 2435, 3);
            WriteAttributeValue("", 2398, "/profile/", 2398, 9, true);
#nullable restore
#line 82 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
WriteAttributeValue("", 2407, Model.owner.Username, 2407, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2428, "/delete", 2428, 7, true);
            EndWriteAttribute();
            WriteLiteral("><small>Delete</small></a>\r\n\t\t\t\t\t\t\t\t</div>\t\r\n");
#nullable restore
#line 84 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
							}

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
                             if(exists) {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<div class=\"col text-right\">\r\n\t\t\t\t\t\t\t\t\t<a class=\"ReplyToProfileMessage\"");
            BeginWriteAttribute("href", " href=\"", 2592, "\"", 2599, 0);
            EndWriteAttribute();
            WriteLiteral(">Reply</a>\r\n\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 89 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
							}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\r\n");
#nullable restore
#line 92 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
                          
							var comments = @Model.hash[p];
							foreach(var c in comments)
							{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t<div class=\"row\"");
            BeginWriteAttribute("comment-id", " comment-id=\"", 2778, "\"", 2796, 1);
#nullable restore
#line 96 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
WriteAttributeValue("", 2791, c.id, 2791, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t\t\t<div class=\"col-sm-auto pl-0\">\r\n\t\t\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "2b0311a9ef7db4e0b241bd5213a49bafe7e1fe4d18673", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"col\">\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"row profileMessageComment\">\r\n\t\t\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 3021, "\"", 3055, 2);
            WriteAttributeValue("", 3028, "/profile/", 3028, 9, true);
#nullable restore
#line 102 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
WriteAttributeValue("", 3037, c.author.Username, 3037, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"user\">\r\n\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 103 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
                                           Write(c.author.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t\t\t\t<span>&nbsp;");
#nullable restore
#line 105 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
                                                   Write(c.post);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t<div class=\"row\">\r\n\t\t\t\t\t\t\t\t\t<div class=\"col-sm-auto pl-0 pr-0\">\r\n\t\t\t\t\t\t\t\t\t\t<small class=\"text-muted\">");
#nullable restore
#line 111 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
                                                             Write(c.date.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 111 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
                                                                          Write(c.date.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 111 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
                                                                                        Write(c.date.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 113 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
                                     if(HttpContext.Session.GetString("username") == c.author.Username) {

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t\t<div class=\"col-sm-auto pr-0\">\r\n\t\t\t\t\t\t\t\t\t\t\t<a class=\"ProfileCommentEdit\"");
            BeginWriteAttribute("href", " href=\"", 3547, "\"", 3554, 0);
            EndWriteAttribute();
            WriteLiteral("><small>Edit</small></a>\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"col-sm-auto\">\r\n\t\t\t\t\t\t\t\t\t\t\t<a");
            BeginWriteAttribute("href", " href=\"", 3649, "\"", 3693, 3);
            WriteAttributeValue("", 3656, "/profile/", 3656, 9, true);
#nullable restore
#line 118 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
WriteAttributeValue("", 3665, Model.owner.Username, 3665, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3686, "/delete", 3686, 7, true);
            EndWriteAttribute();
            WriteLiteral("><small>Delete</small></a>\r\n\t\t\t\t\t\t\t\t\t\t</div>\t\r\n");
#nullable restore
#line 120 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
									}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t</div>\r\n");
#nullable restore
#line 122 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
							}
						

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 126 "G:\Personal Projects\aspnetcoreapp\Pages\profile\index.cshtml"
			}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"		</div>
	</div>
</div>

<script>
	function edit(type) {
		let areaname;

		if(type === ""post"") {
			areaname = ""profileMessageEdit"";
		} else if(type === ""comment"") {
			areaname = ""profileMessageCommentEdit"";
		} else {
			// ????
		}

		let toReplyTo 	= $(this).closest("".row"").prev();
		let id 			= $(toReplyTo).closest(""[comment-id]"").attr(""comment-id"");
		let nextRow 	= $(this).closest("".row"")
		let post 		= $(toReplyTo).find(""span"").text();

		let antiForgery = $('#profile > input[name=""__RequestVerificationToken""]')[0].outerHTML;
		console.log(id);
		console.log($(this).closest("".row""));
		console.log(toReplyTo);

		$(toReplyTo).children().remove();

		$(toReplyTo).append(`
			<div class=""col"">
				<form method=""post"">
					<input type=""text"" name=""profileMessageCommentId"" value=""${id}"" hidden>
					<textarea class=""w-100 form-control p-0"" name=""${areaname}"">${post}</textarea>
					<div class=""text-right mt-1"">
						<button type=""submit"" class=""btn btn-outline-primary""");
            WriteLiteral(@">Confirm</button>
					</div>
					${antiForgery}
				</form>
			</div>
		`);

		$(nextRow).children()[1].remove();
	}

	$("".ProfileMessageEdit"").click(function(e) {
		e.preventDefault();
		var bound = edit.bind(this);
		bound(""post"");
	});

	$("".ProfileCommentEdit"").click(function(e) {
		e.preventDefault();
		var bound = edit.bind(this);
		bound(""comment"");
	});

	$("".ReplyToProfileMessage"").click(function(e) {
		e.preventDefault();

		let toReplyTo = $(this).parent().parent().prev();
		let attacher  = $(toReplyTo).parent();
		let id = $(attacher).attr(""data-id"");
		let antiForgery = $('#profile > input[name=""__RequestVerificationToken""]')[0].outerHTML;
		console.log(attacher);

		$(this).remove();

		$(attacher).append(`
			<div class=""row"">
				<div class=""col"">
					<form method=""post"">
						<div class=""row"">
							<div class=""col-sm-auto p-0"">
								<img class=""avatarSmall"" src=""/images/default-avatar.png"">
							</div>
							<div class=""col"">
								<inpu");
            WriteLiteral(@"t type=""text"" name=""profileMessageCommentId"" value=""${id}"" hidden>
								<textarea class=""w-100 form-control"" name=""profileMessageComment""></textarea>
							</div>
						</div>
						<div class=""row mt-1"">
							<div class=""col text-right"">
								<button type=""submit"" class=""btn btn-outline-primary"">Reply</button>
							</div>
						</div>
						${antiForgery}
					</form>
				</div>
			</div>
		`);
	});
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProfileModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProfileModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ProfileModel>)PageContext?.ViewData;
        public ProfileModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
