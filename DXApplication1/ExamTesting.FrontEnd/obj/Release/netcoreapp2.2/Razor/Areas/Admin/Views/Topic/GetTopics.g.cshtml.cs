#pragma checksum "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Topic\GetTopics.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a4597cf68c7d915bfd3a054f06f2fd13b9f08e2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Topic_GetTopics), @"mvc.1.0.view", @"/Areas/Admin/Views/Topic/GetTopics.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Topic/GetTopics.cshtml", typeof(AspNetCore.Areas_Admin_Views_Topic_GetTopics))]
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
#line 1 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Topic\GetTopics.cshtml"
using ExamTesting.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4597cf68c7d915bfd3a054f06f2fd13b9f08e2d", @"/Areas/Admin/Views/Topic/GetTopics.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff0bbdc15d68186c6ba41cb7fb4752922ee8bab0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Topic_GetTopics : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Topic\GetTopics.cshtml"
  
    ViewData["Title"] = "Topics";

#line default
#line hidden
            BeginContext(71, 146, true);
            WriteLiteral("\r\n<h2 class=\"pb-4 text-center font-weight-light\">Topics</h2>\r\n\r\n<div class=\"card p-5 shadow p-3 mb-5 bg-white rounded\" id=\"tree-list-topic\">\r\n    ");
            EndContext();
            BeginContext(219, 1908, false);
#line 10 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Topic\GetTopics.cshtml"
Write(Html.DevExtreme().TreeList<ExamTesting.Models.Topic>()
            .DataSource(d => d.Mvc()
            .Controller("Topic")
            .LoadAction("Get")
            .UpdateAction("Put")
            .InsertAction("Post")
            .DeleteAction("Delete")
            .Area("Admin")
            .Key("TopicId")
        )

        .KeyExpr("TopicId")
        .ParentIdExpr("ParentId")
        .ColumnAutoWidth(true)
        .WordWrapEnabled(true)
        .ShowBorders(true)


        .Editing(editing =>
        {
            editing.Mode(GridEditMode.Row);
            editing.AllowAdding(true);
            editing.AllowUpdating(true);
            editing.AllowDeleting(true);
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
            columns.AddFor(m => m.TopicName).Caption("Topic Name");


            columns.AddFor(m => m.ParentId).Caption("Head")

                .Lookup(lookup => lookup
                .DataSource(d => d.Mvc().Controller("Topic").LoadAction("Get").Key("TopicId"))
                .DisplayExpr("TopicName")
                .ValueExpr("TopicId"))

                .FormItem(i => i
                .Editor(e => e.SelectBox()
                .DataSource(d => d.Mvc().Controller("Topic").LoadAction("Get").Key("TopicId"))
                .DisplayExpr("TopicName")
                .ValueExpr("TopicId"))
                );

        })
        .ShowBorders(true)
        .AutoExpandAll(true)
        .OnInitNewRow("treeList_onInitNewRow")
        
        
    );

#line default
#line hidden
            EndContext();
            BeginContext(2128, 183, true);
            WriteLiteral("\r\n\r\n\r\n\r\n</div>\r\n\r\n\r\n<script>\r\n    function treeList_onInitNewRow(x) {\r\n        if (x.data.ParentId == \"\") {\r\n            x.data.ParentId = null;\r\n        }\r\n        \r\n    }\r\n</script>");
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
