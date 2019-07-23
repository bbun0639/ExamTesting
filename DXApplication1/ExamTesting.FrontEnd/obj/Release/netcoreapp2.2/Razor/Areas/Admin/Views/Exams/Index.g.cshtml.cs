#pragma checksum "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Exams\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f0139b66a271566bf98d4922feb9e9b08c329192"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Exams_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Exams/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Exams/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Exams_Index))]
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
#line 1 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Exams\Index.cshtml"
using ExamTesting.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f0139b66a271566bf98d4922feb9e9b08c329192", @"/Areas/Admin/Views/Exams/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff0bbdc15d68186c6ba41cb7fb4752922ee8bab0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Exams_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Exams\Index.cshtml"
  
    ViewData["Title"] = "Exams";

#line default
#line hidden
            BeginContext(70, 37, true);
            WriteLiteral("\r\n\r\n\r\n\r\n<div id=\"questions-grid\">\r\n\r\n");
            EndContext();
            BeginContext(179, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(187, 3043, false);
#line 14 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Exams\Index.cshtml"
Write(Html.DevExtreme().DataGrid<ExamTesting.Models.Exam>().DataSource(d => d.Mvc()
        .Controller("Exams")
        .LoadAction("Get")
        .UpdateAction("Put")
        .InsertAction("Post")
        .DeleteAction("Delete")
        .Area("Admin")
        .Key("ExamCodeId"))


     .ID("gridContainer")



     .Editing(editing =>
     {
         editing.Mode(GridEditMode.Form);
         editing.AllowAdding(true);
         editing.AllowDeleting(true);
         editing.AllowUpdating(true);
         editing.UseIcons(true);

     })
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
    .Columns(columns =>
    {
        columns.AddFor(m => m.ExamCode).Caption("Exam Code")
            .CellTemplate
                (item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    BeginContext(1204, 123, true);
    WriteLiteral("\r\n                    <a  href =\"/Admin/Exam/<%= data.ExamCodeId %>/Details\"><%= data.ExamCode %></a>\r\n                    ");
    EndContext();
    PopWriter();
}
));

        columns.AddFor(m => m.ExamName).Caption("Exam Name").SortOrder(SortOrder.Asc);


        columns.AddFor(m => m.SubjectId).Caption("Subject Name")
        .Lookup(lookup => lookup.DataSource(d => d.Mvc().Controller("Exams").LoadAction("GetSubjects").Key("SubjectId"))
            .DisplayExpr("SubjectName")
            .ValueExpr("SubjectId"))
            .Alignment(HorizontalAlignment.Center)
                .FormItem(i => i
                    .Editor(e => e.SelectBox()
                        .DataSource(d => d.Mvc().Controller("Exams").LoadAction("GetSubjects").Key("SubjectId"))
                            .DisplayExpr("SubjectName")
                            .ValueExpr("SubjectId")));

        columns.AddFor(m => m.StartDate)
            .Caption("Start Date")
            .Alignment(HorizontalAlignment.Center)
            .FormItem(i => i
                .Editor(e => e
                    .DateBox()
                    .Placeholder("d/MMM/y")
                    .DisplayFormat("dd MMM yyyy")
                        .Type(DateBoxType.Date)
                    )
            );


        columns.AddFor(m => m.ExamDuration)
            .Caption("Duration")
            .Alignment(HorizontalAlignment.Center)
            .FormItem(i => i
                .Editor(e => e
                    .NumberBox()
                    .Placeholder("Amount of Days")
                    .ShowSpinButtons(true)
                    .ShowClearButton(true)
                    )
                );

        columns.AddFor(m => m.ExamVersion)
            .Caption("Version")
            .Alignment(HorizontalAlignment.Center)
            .FormItem(i => i
                .Editor(e => e
                    .TextBox()
                    .Placeholder("Ex. 2019")
                    )
                );

 })

 .ShowBorders(true)
                );

#line default
#line hidden
            EndContext();
            BeginContext(3245, 12, true);
            WriteLiteral("\r\n\r\n\r\n</div>");
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
