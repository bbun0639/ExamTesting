#pragma checksum "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Questions\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d172a76fae2105f0708ec25e86e6102443b194bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Questions_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Questions/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Questions/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Questions_Index))]
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
#line 1 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Questions\Index.cshtml"
using ExamTesting.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d172a76fae2105f0708ec25e86e6102443b194bf", @"/Areas/Admin/Views/Questions/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff0bbdc15d68186c6ba41cb7fb4752922ee8bab0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Questions_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExamTesting.Models.Question>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Questions\Index.cshtml"
  
    ViewData["Title"] = "Questions";

#line default
#line hidden
            BeginContext(111, 43, true);
            WriteLiteral("\r\n\r\n\r\n<div id=\"questions-grid\">\r\n    \r\n    ");
            EndContext();
            BeginContext(156, 5624, false);
#line 12 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Questions\Index.cshtml"
Write(Html.DevExtreme().DataGrid<ExamTesting.Models.Question>()
    .DataSource( d => d.Mvc()
        .Controller("Questions")
        .LoadAction("Get")
        .UpdateAction("Put")
        .InsertAction("Post")
        .DeleteAction("Delete")
        .Area("Admin")
        .Key("QuestionId")
        )

    .ID("gridContainer")
    .Editing(editing => editing

        .Mode(GridEditMode.Form)
        .AllowAdding(true)
        .AllowDeleting(true)
        .AllowUpdating(true)
    //.UseIcons(true)
    )

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
        columns.Add().DataField("QuestionStr").Caption("Question")
                .FormItem(i => i
                    .Editor(e => e
                    .TextArea()
                    .Height(75))
            )
            .Width(400)
            .CellTemplate(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    BeginContext(1317, 118, true);
    WriteLiteral("\r\n                    <a href=\"/Admin/Question/Index/<%= data.QuestionId %>\"><%= data.QuestionStr %></a>\r\n            ");
    EndContext();
    PopWriter();
}
)
            );

                columns.Add().DataField("Hint").Caption("Hint").Visible(false)
                    .FormItem(i => i
                        .Editor(e => e
                        .TextArea()
                        .Height(75))
                    );

                columns.Add().DataField("QuestionType").Caption("Question Type").Visible(true)
                    .Lookup(lookup => lookup.DataSource(Html.GetEnumSelectList<QuestionType>()
                                .Select(l => new { Value = int.Parse(l.Value), Text = l.Text }))
                                .ValueExpr("Value")
                                .DisplayExpr("Text")
                            )
                            .FormItem(i => i
                                .Editor(e => e.SelectBox()
                                    .ID("QuestionType")
                                    .DataSource(Html.GetEnumSelectList<QuestionType>()
                                        .Select(l => new { Value = int.Parse(l.Value), Text = l.Text }))
                                    .ValueExpr("Value")
                                    .DisplayExpr("Text")

                                    )

                                )
                            .Alignment(HorizontalAlignment.Center);


                columns.Add().DataField("QuestionLevel").Caption("Question Level").Visible(false)
                    .Lookup(lookup => lookup
                        .DataSource(Html.GetEnumSelectList<EnumLevel>()
                                .Select(l => new { Value = int.Parse(l.Value), Text = l.Text }))
                                .ValueExpr("Value")
                                .DisplayExpr("Text")
                            )
                            .FormItem(i => i
                                .Editor(e => e.SelectBox()
                                    .ID("QuestionLevel")
                                    .DataSource(Html.GetEnumSelectList<EnumLevel>()
                                        .Select(l => new { Value = int.Parse(l.Value), Text = l.Text }))
                                    .ValueExpr("Value")
                                    .DisplayExpr("Text")
                                    )

                                )
                            .Alignment(HorizontalAlignment.Center);


                columns.Add().DataField("TopicId").Caption("Topic").Visible(true)
                .Lookup(lookup => lookup
                        .DataSource(d => d.Mvc().Controller("Questions").LoadAction("GetTopicDropdown").Key("TopicId"))
                                .ValueExpr("TopicId")
                                .DisplayExpr("TopicName")
                            )
                            .FormItem(i => i
                               .Editor(e => e.DropDownBox()
                               .ID("TopicId")
                               .DropDownOptions(o => o.Height(250))
                               .DataSource(d => d.Mvc().Controller("Questions").LoadAction("GetTopicDropdown").Key("TopicId"))
                               .DisplayExpr("TopicName")
                               .ValueExpr("TopicId")
                                    .Placeholder("Select a value...")
                                    .ShowClearButton(true)
                                    .OnValueChanged("treeBox_valueChanged")
                                    .ContentTemplate(new TemplateName("EmbeddedTreeViewMultiple"))
                                    )

                                )
                            .Alignment(HorizontalAlignment.Center);


                columns.AddFor(m => m.QuestionPoint).Caption("Point").Visible(true)
                    .FormItem(i => i
                        .Editor(e => e
                            .NumberBox()
                            .Min(0)
                            .Max(100)
                            .ShowSpinButtons(true)
                            .Placeholder("0-100")
                            )
                        )
                    .Alignment(HorizontalAlignment.Center);

            })
            .ShowBorders(true)
            .OnCellClick("QuestionDetails")
            .HoverStateEnabled(true)

);

#line default
#line hidden
            EndContext();
            BeginContext(5795, 16, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n");
            EndContext();
#line 151 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Questions\Index.cshtml"
 using (Html.DevExtreme().NamedTemplate("EmbeddedTreeViewMultiple"))
{
        

#line default
#line hidden
            BeginContext(5894, 1082, false);
#line 153 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Questions\Index.cshtml"
    Write(Html.DevExtreme().TreeView()
        .DataSource(d => d.Mvc().Controller("Questions").LoadAction("GetTopicDropdown").Key("TopicId"))
        .KeyExpr("TopicId")
        .DisplayExpr("TopicName")
        //.ItemsExpr("Items")
        //.ExpandedExpr("true")
        .ParentIdExpr("ParentId")
        .DataStructure(TreeViewDataStructure.Plain)
        .SelectionMode(NavSelectionMode.Multiple)
        .ShowCheckBoxesMode(TreeViewCheckBoxMode.Normal)
        .SelectNodesRecursive(false)
        .SelectByClick(true)
        .Height(235)
        .OnItemSelectionChanged(
            item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    BeginContext(6497, 266, true);
    WriteLiteral(@"
                    function(args) {
                        var nodes = args.component.getNodes(),
                            value = getSelectedItemsKeys(nodes);

                        component.option(""value"", value);
                    }
            ");
    EndContext();
    PopWriter();
}
))

        .OnContentReady(
            item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    BeginContext(6820, 166, true);
    WriteLiteral("\r\n                    function(args) {\r\n                        syncTreeViewSelection(args.component, component.option(\"value\"));\r\n                    }\r\n            ");
    EndContext();
    PopWriter();
}
))
        );

#line default
#line hidden
            EndContext();
#line 182 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Questions\Index.cshtml"
         
    }

#line default
#line hidden
            BeginContext(7014, 585, true);
            WriteLiteral(@"
<script>

    function QuestionDetails(e) {



        if (e.data.SubjectId != null) {
            window.location.href = ""/Admin/Question/Index/""+ e.data.QuestionId;
        }

        //var myJs = JSON.stringify(e.data.QuestionId);
        //console.log(myJs)
    }


//Ezy dropdown
    function innerList_selectionChanged(e) {
        var dropDownBox = $(""#dropDownBox"").dxDropDownBox(""instance"");
        dropDownBox.option(""value"", e.addedItems[0]);
        dropDownBox.close();
    }

//Button Back
    function Back() {
        window.location.href = """);
            EndContext();
            BeginContext(7600, 26, false);
#line 209 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Questions\Index.cshtml"
                           Write(Url.Action("GetQuestions"));

#line default
#line hidden
            EndContext();
            BeginContext(7626, 1177, true);
            WriteLiteral(@""";
    }

    
//Func tree view box
    function syncTreeViewSelection(treeView, value) {
        if (!value) {
            treeView.unselectAll();
            return;
        }

        value.forEach(function (key) {
            treeView.selectItem(key);
        });
    }

    function getSelectedItemsKeys(items) {
        var result = [];
        items.forEach(function (item) {
            if (item.selected) {
                result.push(item.key);
            }
            if (item.items.length) {
                result = result.concat(getSelectedItemsKeys(item.items));
            }
        });
        return result;
    }

    function treeBox_valueChanged(e) {
        var $treeView = e.component.content().find("".dx-treeview"");
        if($treeView.length) {
            syncTreeViewSelection($treeView.dxTreeView(""instance""), e.value);
        }
    }

    function gridBox_valueChanged(e) {
        var $dataGrid = $(""#embedded-datagrid"");

        if ($dataGrid.lengt");
            WriteLiteral("h) {\r\n            var dataGrid = $dataGrid.dxDataGrid(\"instance\");\r\n            dataGrid.selectRows(e.value, false);\r\n        }\r\n    }\r\n\r\n</script>\r\n\r\n\r\n");
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
