#pragma checksum "C:\Users\Tima\Desktop\ТГУ 2021-2022\ВЕБ\лаба 4\Backend4\Views\Mockups\Reset2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2162639d9731a188d5b56397ae0f7a56275d2721"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Mockups_Reset2), @"mvc.1.0.view", @"/Views/Mockups/Reset2.cshtml")]
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
#line 1 "C:\Users\Tima\Desktop\ТГУ 2021-2022\ВЕБ\лаба 4\Backend4\Views\_ViewImports.cshtml"
using Backend4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Tima\Desktop\ТГУ 2021-2022\ВЕБ\лаба 4\Backend4\Views\_ViewImports.cshtml"
using Backend4.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2162639d9731a188d5b56397ae0f7a56275d2721", @"/Views/Mockups/Reset2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96619c4a8d13af5dee7982e58002d641c54e06c6", @"/Views/_ViewImports.cshtml")]
    public class Views_Mockups_Reset2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Auth>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Tima\Desktop\ТГУ 2021-2022\ВЕБ\лаба 4\Backend4\Views\Mockups\Reset2.cshtml"
  
    ViewData["Title"] = "Reset your password";


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-left\">\n    <h1>");
#nullable restore
#line 7 "C:\Users\Tima\Desktop\ТГУ 2021-2022\ВЕБ\лаба 4\Backend4\Views\Mockups\Reset2.cshtml"
   Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n</div>\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2162639d9731a188d5b56397ae0f7a56275d27214011", async() => {
                WriteLiteral("\n    <div><b>Code</b></div>\n    ");
#nullable restore
#line 11 "C:\Users\Tima\Desktop\ТГУ 2021-2022\ВЕБ\лаба 4\Backend4\Views\Mockups\Reset2.cshtml"
Write(Html.TextBox("myTextbox", ""));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n    <input type=\"submit\"  value=\"Verify\"class=\"btn btn-outline-dark ml-3\">\n    <h2>");
#nullable restore
#line 13 "C:\Users\Tima\Desktop\ТГУ 2021-2022\ВЕБ\лаба 4\Backend4\Views\Mockups\Reset2.cshtml"
   Write(ViewBag.Check);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Auth> Html { get; private set; }
    }
}
#pragma warning restore 1591
