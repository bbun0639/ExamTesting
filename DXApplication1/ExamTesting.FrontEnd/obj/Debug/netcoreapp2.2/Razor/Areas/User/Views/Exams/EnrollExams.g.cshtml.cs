#pragma checksum "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\User\Views\Exams\EnrollExams.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d32f83a23ffc892a4eb6d4198700e5cd0822762c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Exams_EnrollExams), @"mvc.1.0.view", @"/Areas/User/Views/Exams/EnrollExams.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/User/Views/Exams/EnrollExams.cshtml", typeof(AspNetCore.Areas_User_Views_Exams_EnrollExams))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d32f83a23ffc892a4eb6d4198700e5cd0822762c", @"/Areas/User/Views/Exams/EnrollExams.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff0bbdc15d68186c6ba41cb7fb4752922ee8bab0", @"/Areas/User/Views/_ViewImports.cshtml")]
    public class Areas_User_Views_Exams_EnrollExams : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExamTesting.Models.UserExam>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(36, 45, true);
            WriteLiteral("        \r\n    <div class=\"col\">\r\n\r\n\r\n        ");
            EndContext();
            BeginContext(83, 2095, false);
#line 6 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\User\Views\Exams\EnrollExams.cshtml"
    Write(Html.DevExtreme().DataGrid<ExamTesting.Models.Exam>()
            .DataSource(d => d.Mvc()
            .Controller("Exams")
            .LoadAction("Get")
            .Area("User")
            .Key("ExamCodeId")
        )

            .ID("gridContainer")

            .Paging(paging => paging.Enabled(true).PageSize(10))

            .FilterRow(filterRow => filterRow
                .Visible(true)
                .ApplyFilter(GridApplyFilterMode.Auto)
            )
            .SearchPanel(searchPanel => searchPanel
                .Visible(true)
                .Width(240)
                .Placeholder("Search...")
            )
            .HeaderFilter(headerFilter => headerFilter.Visible(true))
            .HoverStateEnabled(true)
            .Selection(s => s.Mode(SelectionMode.Single))


            .Columns(columns =>
            {
                columns.AddFor(m => m.ExamCode).Caption("Code");

                columns.AddFor(m => m.ExamName).Caption("Exam");

                columns.AddFor(m => m.SubjectId).Caption("Subject")
                    .Lookup(lookup => lookup
                    .DataSource(d => d.Mvc().Controller("Exams").LoadAction("GetSubjects").Key("SubjectId"))
                    .DisplayExpr("SubjectName")
                    .ValueExpr("SubjectId")
                )
                .Alignment(HorizontalAlignment.Center);

                columns.AddFor(m => m.StartDate).Caption("Start Date")
                    .Alignment(HorizontalAlignment.Center);

                columns.AddFor(m => m.ExamDuration).Caption("Duration (Days)")
                .Alignment(HorizontalAlignment.Center)
                .Width(80);

                columns.AddFor(m => m.ExamVersion).Caption("Version")
                .Alignment(HorizontalAlignment.Center)
                .Width(80);
            })

            .ShowBorders(true)
            .Selection(s => s.Mode(SelectionMode.Multiple))
            //.OnSelectionChanged("selection_changed")
            //.OnCellDblClick("selection_changed")
        );

#line default
#line hidden
            EndContext();
            BeginContext(2179, 30, true);
            WriteLiteral("\r\n\r\n        <br />\r\n\r\n        ");
            EndContext();
            BeginContext(2211, 131, false);
#line 66 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\User\Views\Exams\EnrollExams.cshtml"
    Write(Html.DevExtreme().Button()
            .Type(ButtonType.Normal)
            .Icon("back")
            .OnClick("Back")
        );

#line default
#line hidden
            EndContext();
            BeginContext(2343, 274, true);
            WriteLiteral(@"

    </div>      
  


<script>
    function selection_changed(e) {
        if (e.data.ExamCodeId != null) {
            window.location.href = ""/Admin/Exam/"" + e.data.ExamId + ""/Detail"";
        }
    }

    function Back() {
        window.location.href = """);
            EndContext();
            BeginContext(2618, 27, false);
#line 84 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\User\Views\Exams\EnrollExams.cshtml"
                           Write(Url.Action("Index","Exams"));

#line default
#line hidden
            EndContext();
            BeginContext(2645, 20, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExamTesting.Models.UserExam> Html { get; private set; }
    }
}
#pragma warning restore 1591