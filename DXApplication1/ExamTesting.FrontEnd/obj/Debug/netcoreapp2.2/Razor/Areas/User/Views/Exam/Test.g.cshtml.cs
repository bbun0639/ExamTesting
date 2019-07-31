#pragma checksum "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\User\Views\Exam\Test.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f5f95640947e5917620f99b39418e5d7171a95a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Exam_Test), @"mvc.1.0.view", @"/Areas/User/Views/Exam/Test.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/User/Views/Exam/Test.cshtml", typeof(AspNetCore.Areas_User_Views_Exam_Test))]
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
#line 1 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\User\Views\Exam\Test.cshtml"
using ExamTesting.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f5f95640947e5917620f99b39418e5d7171a95a", @"/Areas/User/Views/Exam/Test.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff0bbdc15d68186c6ba41cb7fb4752922ee8bab0", @"/Areas/User/Views/_ViewImports.cshtml")]
    public class Areas_User_Views_Exam_Test : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExamTesting.Models.UserExamQuestion>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Test", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\User\Views\Exam\Test.cshtml"
  
    ViewData["Title"] = "Test";

#line default
#line hidden
            BeginContext(111, 64, true);
            WriteLiteral("\r\n<div class=\"col mb-4 h4 font-weight-normal\">\r\n    Exam Test : ");
            EndContext();
            BeginContext(176, 28, false);
#line 8 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\User\Views\Exam\Test.cshtml"
           Write(Model.UserExam.Exam.ExamName);

#line default
#line hidden
            EndContext();
            BeginContext(204, 39, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n<div class=\"col\">\r\n\r\n    ");
            EndContext();
            BeginContext(245, 1472, false);
#line 14 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\User\Views\Exam\Test.cshtml"
Write(Html.DevExtreme().DataGrid<ExamTesting.Models.UserExamQuestion>()
    .ID("gridContainer")
    .DataSource(d => d.Mvc()
        .Controller("Exam")
        .LoadAction("GetExamQuestion")
        .Area("User")
        .Key("QuestionId")
        .LoadParams(new { id = Model.UserExam.ExamId })
    )
    .Paging(paging => paging.Enabled(true).PageSize(10))


    .Columns(columns =>
    {
            columns.AddFor(m => m.IsComplete).Caption("Completed");

            columns.AddFor(m => m.Question.QuestionStr).Caption("Questions").Width(700)
            .CellTemplate(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    BeginContext(839, 155, true);
    WriteLiteral("\r\n                            <a href=\"/User/Exam/QuestionAnswer/<%= data.UserExamQuestionId %>\"><%= data.Question.QuestionStr %></a>\r\n                    ");
    EndContext();
    PopWriter();
}
)
                );


            columns.AddFor(m => m.Question.QuestionPoint).Visible(true).Caption("Point")
               .Alignment(HorizontalAlignment.Center);

            columns.AddFor(m => m.Question.QuestionLevel).Visible(true).Caption("Question Level").Visible(false)
            .Lookup(lookup => lookup
                .DataSource(Html.GetEnumSelectList<EnumLevel>()
                .Select(l => new { Value = int.Parse(l.Value), Text = l.Text }))
                .ValueExpr("Value")
                .DisplayExpr("Text"))
            .Alignment(HorizontalAlignment.Center);

        })


        .ShowBorders(true)
        .HoverStateEnabled(true)
        .OnCellClick("QuestionAnswer")
        );

#line default
#line hidden
            EndContext();
            BeginContext(1732, 99, true);
            WriteLiteral("\r\n\r\n    \r\n        <div class=\"row pt-4\">\r\n            <div class=\"text-left col\">\r\n                ");
            EndContext();
            BeginContext(1833, 139, false);
#line 59 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\User\Views\Exam\Test.cshtml"
            Write(Html.DevExtreme().Button()
                    .Icon("back")
                    .OnClick("Back")
                    
                );

#line default
#line hidden
            EndContext();
            BeginContext(1973, 34, true);
            WriteLiteral("\r\n            </div>\r\n            ");
            EndContext();
            BeginContext(2007, 250, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8f5f95640947e5917620f99b39418e5d7171a95a7431", async() => {
                BeginContext(2069, 181, true);
                WriteLiteral("\r\n\r\n                <div class=\"text-right col\">\r\n                    <input type=\"submit\" class=\"btn btn-primary\" value=\"Submit the Exam\" />\r\n                </div>\r\n\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 65 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\User\Views\Exam\Test.cshtml"
                                      WriteLiteral(Model.UserExam.ExamId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2257, 486, true);
            WriteLiteral(@"
        </div>
    

</div>


<script>
    function QuestionAnswer(e) {
        if (e.data.QuestionId != null) {
            window.location.href = ""/User/Exam/QuestionAnswer/"" + e.data.UserExamQuestionId;
        }
    }


    function selection_changed(selectedItems) {
        var data = selectedItems.selectedRowsData;
        document.getElementById(""examQuestion"").value = JSON.stringify(data);
    }


    function Back() {
        window.location.href = """);
            EndContext();
            BeginContext(2744, 28, false);
#line 93 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\User\Views\Exam\Test.cshtml"
                           Write(Url.Action("Details","Exam"));

#line default
#line hidden
            EndContext();
            BeginContext(2772, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(2774, 21, false);
#line 93 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\User\Views\Exam\Test.cshtml"
                                                         Write(Model.UserExam.ExamId);

#line default
#line hidden
            EndContext();
            BeginContext(2795, 20, true);
            WriteLiteral("\";\r\n    }\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExamTesting.Models.UserExamQuestion> Html { get; private set; }
    }
}
#pragma warning restore 1591
