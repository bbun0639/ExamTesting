#pragma checksum "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Views\Shared\_HeadNavbar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7227bf5d704dd8af93054a6a2ee82a4c8ba1247"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__HeadNavbar), @"mvc.1.0.view", @"/Views/Shared/_HeadNavbar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_HeadNavbar.cshtml", typeof(AspNetCore.Views_Shared__HeadNavbar))]
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
#line 1 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Views\_ViewImports.cshtml"
using ExamTesting_FrontEnd;

#line default
#line hidden
#line 3 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Views\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7227bf5d704dd8af93054a6a2ee82a4c8ba1247", @"/Views/Shared/_HeadNavbar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff0bbdc15d68186c6ba41cb7fb4752922ee8bab0", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__HeadNavbar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_AuthenticatedUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 128, true);
            WriteLiteral("\r\n\r\n<div class=\"p-2 mb-3\">\r\n    <div class=\"row bg-light p-2\">\r\n        <div class=\"col-2\">\r\n            <a class=\"navbar-brand\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 128, "\"", 167, 1);
#line 6 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Views\Shared\_HeadNavbar.cshtml"
WriteAttributeValue("", 135, Url.Action("Index","Dashboard"), 135, 32, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(168, 145, true);
            WriteLiteral(">TEST EVALUATION</a>\r\n        </div>\r\n\r\n        <div id=\"emptyNav\" class=\"col\">\r\n\r\n        </div>\r\n\r\n        <div id=\"\" class=\"nav-link col-3\">\r\n");
            EndContext();
#line 14 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Views\Shared\_HeadNavbar.cshtml"
             if (User.Identity.IsAuthenticated)
            {

#line default
#line hidden
            BeginContext(377, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(393, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c7227bf5d704dd8af93054a6a2ee82a4c8ba12474723", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(430, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 17 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Views\Shared\_HeadNavbar.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(480, 138, true);
            WriteLiteral("                <div class=\"text-right\">\r\n                    <a href=\"/Authen/SignIn\">Login</a>\r\n                </div>                \r\n");
            EndContext();
#line 23 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Views\Shared\_HeadNavbar.cshtml"
            }

#line default
#line hidden
            BeginContext(633, 40, true);
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n");
            EndContext();
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
