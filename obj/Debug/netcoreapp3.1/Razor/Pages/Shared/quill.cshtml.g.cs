#pragma checksum "G:\Personal Projects\aspnetcoreapp\Pages\Shared\quill.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdc0bcd8fb650a4f53ebbe557fb62debf339b066"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(aspnetcoreapp.Pages.Shared.Pages_Shared_quill), @"mvc.1.0.view", @"/Pages/Shared/quill.cshtml")]
namespace aspnetcoreapp.Pages.Shared
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdc0bcd8fb650a4f53ebbe557fb62debf339b066", @"/Pages/Shared/quill.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e70cdf4260bd324b075540e3ddbd00028c5e8dfc", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_quill : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<script src=""https://unpkg.com/quill-image-uploader@1.2.1/dist/quill.imageUploader.min.js""></script>
<script>
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
						});
					});
				}
			}
		},
		theme:");
            WriteLiteral(" \'snow\'  // or \'bubble\'\r\n\t};\r\n\r\n\tvar quill = new Quill(\'#editor-container\', options);\r\n\r\n\t$(\"#postform\").on(\"submit\", function(){\r\n\t\t$(\"#hiddenArea\").val($(\"#editor-container > .ql-editor\").html());\r\n\t});\r\n</script>");
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
