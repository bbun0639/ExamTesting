#pragma checksum "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Question\_QuestionChoices.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8701d591be94ded28864633494f06e0f531ba7ad"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Question__QuestionChoices), @"mvc.1.0.view", @"/Areas/Admin/Views/Question/_QuestionChoices.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Question/_QuestionChoices.cshtml", typeof(AspNetCore.Areas_Admin_Views_Question__QuestionChoices))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8701d591be94ded28864633494f06e0f531ba7ad", @"/Areas/Admin/Views/Question/_QuestionChoices.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff0bbdc15d68186c6ba41cb7fb4752922ee8bab0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Question__QuestionChoices : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExamTesting.Models.Question>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(40, 966, false);
#line 3 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Question\_QuestionChoices.cshtml"
Write(Html.DevExtreme().DataGrid<ExamTesting.Models.Choice>()
    .ID("gridContainer")
    .ShowBorders(true)

    .Paging(paging => paging.Enabled(true).PageSize(5))
    .Editing(editing =>
    {
        editing.Mode(GridEditMode.Cell);
        editing.AllowAdding(true);
        editing.AllowDeleting(true);
        editing.AllowUpdating(true);
    })
    .Columns(columns =>
    {

        columns.AddFor(m => m.IsCorrect)
            .Width(120)
            .Caption("Check Correct")
            .FormItem(i => i
                .Editor(e => e.RadioGroup())
                )
            .AllowEditing(true);

        columns.AddFor(m => m.ChoiceStr)
            .Caption("Choices");
    })
    .DataSource(d => d.Mvc()
    .LoadAction("Get")
    .UpdateAction("Put")
    .InsertAction("Post")
    .DeleteAction("Delete")
    .Key("ChoiceId")
    .LoadParams(new { id = Model.QuestionId })
    )



.OnInitNewRow("getQuestionId")
);

#line default
#line hidden
            EndContext();
            BeginContext(1007, 80, true);
            WriteLiteral("\r\n\r\n<script>\r\n    function getQuestionId(e) {\r\n            e.data.QuestionId = \'");
            EndContext();
            BeginContext(1088, 27, false);
#line 45 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Question\_QuestionChoices.cshtml"
                            Write(Model.QuestionId.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1115, 31, true);
            WriteLiteral("\' ;\r\n    }        \r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExamTesting.Models.Question> Html { get; private set; }
    }
}
#pragma warning restore 1591
