#pragma checksum "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\User\Views\Exams\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4528bbbb4ff372e54656574974c75bd44a1cedc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Exams_Index), @"mvc.1.0.view", @"/Areas/User/Views/Exams/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/User/Views/Exams/Index.cshtml", typeof(AspNetCore.Areas_User_Views_Exams_Index))]
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
#line 1 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\User\Views\_ViewImports.cshtml"
using ExamTesting_FrontEnd;

#line default
#line hidden
#line 3 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\User\Views\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4528bbbb4ff372e54656574974c75bd44a1cedc", @"/Areas/User/Views/Exams/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff0bbdc15d68186c6ba41cb7fb4752922ee8bab0", @"/Areas/User/Views/_ViewImports.cshtml")]
    public class Areas_User_Views_Exams_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ExamTesting.Models.Exam>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ExamList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(39, 52, true);
            WriteLiteral("\r\n    <div class=\"col\">\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 5 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\User\Views\Exams\Index.cshtml"
              
                var examlists = Model
                    .GroupBy(m => m.ExamCodeId)
                    .Select(g => new { g.Key, examlists = g.ToList() })
                        .ToList();

                

#line default
#line hidden
#line 11 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\User\Views\Exams\Index.cshtml"
                 foreach (var examlist in examlists.OrderBy(c => c.Key))
                {

#line default
#line hidden
            BeginContext(399, 20, true);
            WriteLiteral("                    ");
            EndContext();
            BeginContext(419, 27, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d4528bbbb4ff372e54656574974c75bd44a1cedc4530", async() => {
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
            BeginContext(446, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 14 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\User\Views\Exams\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(500, 46, true);
            WriteLiteral("            \r\n        </div>\r\n\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ExamTesting.Models.Exam>> Html { get; private set; }
    }
}
#pragma warning restore 1591
