#pragma checksum "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Exam\Questions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "727b55f584592921e8cac635428c682ae2a703cc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Exam_Questions), @"mvc.1.0.view", @"/Areas/Admin/Views/Exam/Questions.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Exam/Questions.cshtml", typeof(AspNetCore.Areas_Admin_Views_Exam_Questions))]
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
#line 1 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\_ViewImports.cshtml"
using ExamTesting_FrontEnd;

#line default
#line hidden
#line 3 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\_ViewImports.cshtml"
using DevExtreme.AspNet.Mvc;

#line default
#line hidden
#line 1 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Exam\Questions.cshtml"
using ExamTesting.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"727b55f584592921e8cac635428c682ae2a703cc", @"/Areas/Admin/Views/Exam/Questions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff0bbdc15d68186c6ba41cb7fb4752922ee8bab0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Exam_Questions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExamTesting.Models.Exam>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ExamHeader", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ListQuestions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(59, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Exam\Questions.cshtml"
  
    ViewData["Title"] = "Exam";

#line default
#line hidden
            BeginContext(101, 82, true);
            WriteLiteral("\r\n\r\n\r\n\r\n<div id=\"form-container\" class=\"row\">\r\n\r\n    <div class=\"col\">\r\n\r\n        ");
            EndContext();
            BeginContext(183, 30, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "727b55f584592921e8cac635428c682ae2a703cc4630", async() => {
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
            BeginContext(213, 48, true);
            WriteLiteral("\r\n\r\n\r\n        <div class=\"p-4 col bg-light\">\r\n\r\n");
            EndContext();
            BeginContext(921, 12, true);
            WriteLiteral("\r\n\r\n        ");
            EndContext();
            BeginContext(933, 31, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "727b55f584592921e8cac635428c682ae2a703cc6057", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(964, 109, true);
            WriteLiteral("\r\n\r\n\r\n            <div class=\"row mt-4\">\r\n\r\n                <div class=\"text-left col\">\r\n                    ");
            EndContext();
            BeginContext(1075, 165, false);
#line 45 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Exam\Questions.cshtml"
                Write(Html.DevExtreme().Button()
                     .Icon("back")
                     .Text("Exams List")
                     .OnClick("Back")
                    );

#line default
#line hidden
            EndContext();
            BeginContext(1241, 76, true);
            WriteLiteral("\r\n                </div>\r\n\r\n                <div class=\"text-right col\">\r\n\r\n");
            EndContext();
            BeginContext(1428, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1452, 234, false);
#line 56 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Exam\Questions.cshtml"
                Write(Html.DevExtreme().Button()
                      .Type(ButtonType.Default)
                      .Icon("plus")
                      .Text("Assign Questions")
                      .OnClick("AssignQuestions")
                    );

#line default
#line hidden
            EndContext();
            BeginContext(1687, 175, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n              \r\n    </div>\r\n\r\n\r\n</div>\r\n\r\n\r\n\r\n<script>\r\n    function Back() {\r\n        window.location.href = \"");
            EndContext();
            BeginContext(1863, 27, false);
#line 76 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Exam\Questions.cshtml"
                           Write(Url.Action("Index","Exams"));

#line default
#line hidden
            EndContext();
            BeginContext(1890, 82, true);
            WriteLiteral("\";\r\n    }\r\n\r\n    function AssignQuestions(e) {\r\n\r\n        window.location.href = \"");
            EndContext();
            BeginContext(1973, 29, false);
#line 81 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Exam\Questions.cshtml"
                           Write(Url.Action("AssignQuestions"));

#line default
#line hidden
            EndContext();
            BeginContext(2002, 92, true);
            WriteLiteral("\";\r\n\r\n        //var myJs = JSON.stringify(e.data);\r\n        //alert(myJs);\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExamTesting.Models.Exam> Html { get; private set; }
    }
}
#pragma warning restore 1591
