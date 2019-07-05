#pragma checksum "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Subject\GetSubjects.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d13c0c58eb0c6210e9e00b6e625d09c5f1aa7b6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Subject_GetSubjects), @"mvc.1.0.view", @"/Areas/Admin/Views/Subject/GetSubjects.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Subject/GetSubjects.cshtml", typeof(AspNetCore.Areas_Admin_Views_Subject_GetSubjects))]
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
#line 1 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Subject\GetSubjects.cshtml"
using ExamTesting.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d13c0c58eb0c6210e9e00b6e625d09c5f1aa7b6", @"/Areas/Admin/Views/Subject/GetSubjects.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff0bbdc15d68186c6ba41cb7fb4752922ee8bab0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Subject_GetSubjects : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(28, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Subject\GetSubjects.cshtml"
  
    ViewData["Title"] = "Subject";

#line default
#line hidden
            BeginContext(73, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(79, 1598, false);
#line 8 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Subject\GetSubjects.cshtml"
Write(Html.DevExtreme().DataGrid().DataSource(d => d.Mvc()
        .Controller("Subject")
        .LoadAction("Get")
        .UpdateAction("Put")
        .InsertAction("Post")
        .DeleteAction("Delete")
        .Area("Admin")
        .Key("SubjectId"))

    .ID("gridContainer")
     .Editing(editing =>
     {
         editing.Mode(GridEditMode.Form);
         editing.AllowAdding(true);
         editing.AllowDeleting(true);
         editing.AllowUpdating(true);
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
        columns.Add().DataField("SubjectName").Caption("Subject Name");


         columns.Add().DataField("SubjectLevel").Caption("Subject Level")
        .Lookup(lookup => lookup.DataSource(Html.GetEnumSelectList<EnumLevel>()
                    .Select(l => new { Value = int.Parse(l.Value), Text = l.Text }))
                .ValueExpr("Value")
                .DisplayExpr("Text"))
        .FormItem(i => i
            .Editor(e => e.SelectBox()
                .ID("SubjectLevel")
                .DataSource(Html.GetEnumSelectList<EnumLevel>()
                    .Select(l => new { Value = int.Parse(l.Value), Text = l.Text }))
                .ValueExpr("Value")
                .DisplayExpr("Text")));


    })


.ShowBorders(true)
);

#line default
#line hidden
            EndContext();
            BeginContext(1678, 8, true);
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
