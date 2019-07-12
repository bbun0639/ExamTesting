#pragma checksum "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Question\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f83781341949a837a1e9cea297cca909b3029a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Question_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Question/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Question/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Question_Index))]
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
#line 1 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Question\Index.cshtml"
using ExamTesting.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f83781341949a837a1e9cea297cca909b3029a5", @"/Areas/Admin/Views/Question/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff0bbdc15d68186c6ba41cb7fb4752922ee8bab0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Question_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExamTesting.Models.Question>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(64, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Question\Index.cshtml"
  
    ViewData["Title"] = "Question Choices";

#line default
#line hidden
            BeginContext(118, 205, true);
            WriteLiteral("\r\n<h2 class=\"pb-4 text-center font-weight-light\">Question Choices</h2>\r\n\r\n<div id=\"form-container\" class=\"row\">\r\n\r\n    <div class=\"card p-5 shadow mb-3 bg-white rounded col\" style=\"width:550px;\">\r\n        ");
            EndContext();
            BeginContext(325, 3121, false);
#line 13 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Question\Index.cshtml"
    Write(Html.DevExtreme().Form<ExamTesting.Models.Question>()
            .ID("form")
            .ColCount(1)
                       

            .Items(items => {
                items.AddGroup()
                    .Caption("Question Info")

                    .Items(groupItems =>
                    {

                        groupItems.AddSimpleFor(m => m.QuestionStr)
                        .Editor(e => e
                            .TextArea()
                            .Height(75)
                        )
                        .ValidationRules(r => r
                            .AddRequired()
                            .Message("Question is required")
                        );


                        groupItems.AddSimpleFor(m => m.Hint)
                        .Editor(e => e
                            .TextArea()
                            .Height(75)
                        );

                        groupItems.AddSimpleFor(m => m.QuestionType)
                        .Editor(e => e
                            .SelectBox()
                            .DataSource(Html.GetEnumSelectList<QuestionType>()
                                        .Select(l => new { Value = int.Parse(l.Value), Text = l.Text }))
                                        .ValueExpr("Value")
                                        .DisplayExpr("Text")
                            );


                        groupItems.AddSimpleFor(m => m.QuestionLevel)
                        .Editor(e => e
                            .SelectBox()
                            .DataSource(Html.GetEnumSelectList<EnumLevel>()
                                        .Select(l => new { Value = int.Parse(l.Value), Text = l.Text }))
                                        .ValueExpr("Value")
                                        .DisplayExpr("Text")
                            );

                        groupItems.AddSimpleFor(m => m.TopicId)
                        .Editor(e => e
                            .DropDownBox()
                            .DropDownOptions(o => o.Height(250))
                            .DataSource(d => d.Mvc().Controller("Question").LoadAction("GetTopicDropdown").Key("TopicId"))
                            .DisplayExpr("TopicName").ValueExpr("TopicId")
                            .Placeholder("Select a value...")
                            .ShowClearButton(true)
                            .OnValueChanged("treeBox_valueChanged")
                            .ContentTemplate(new TemplateName("EmbeddedTreeViewMultiple"))
                        );


                        groupItems.AddSimpleFor(m => m.QuestionPoint)
                            .Editor(e => e
                            .NumberBox()
                            .Min(0)
                            .Max(100)
                            .ShowSpinButtons(true)
                            .Placeholder("0-100")
                        );
                            
                    });
            })

            .FormData(Model)
        );

#line default
#line hidden
            EndContext();
            BeginContext(3447, 155, true);
            WriteLiteral("\r\n\r\n    </div>\r\n    \r\n    \r\n    <div class=\"col-1\"></div>\r\n\r\n\r\n    <div class=\"card p-5 shadow mb-3 bg-white rounded col\" style=\"width:550px;\">\r\n\r\n        ");
            EndContext();
            BeginContext(3604, 740, false);
#line 97 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Question\Index.cshtml"
    Write(Html.DevExtreme().Form<ExamTesting.Models.Question>()
            .ID("form-point")
            .ColCount(1)
            .Items(items =>
            {
                items.AddGroup()
                    .Caption("Select Choices")
                    .Items(groupItems =>
                    {
                        groupItems.AddSimpleFor(m => m.QuestionPoint)
                        .Editor(e => e
                            .TagBox()
                            .DataSource(d => d.Mvc().Controller("Question").LoadAction("GetTopicDropdown").Key("TopicId"))
                            .DisplayExpr("TopicName").ValueExpr("TopicId")
                        );


                    });


            })

        );

#line default
#line hidden
            EndContext();
            BeginContext(4345, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
            BeginContext(4849, 24, true);
            WriteLiteral("    </div>\r\n\r\n</div>\r\n\r\n");
            EndContext();
#line 134 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Question\Index.cshtml"
         using (Html.DevExtreme().NamedTemplate("EmbeddedTreeViewMultiple"))
        {
                

#line default
#line hidden
            BeginContext(4980, 1259, false);
#line 136 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Question\Index.cshtml"
            Write(Html.DevExtreme().TreeView()
                .DataSource(new JS(@"component.option(""dataSource"")"))
                .KeyExpr("TopicId")
                .DisplayExpr("TopicName")
                .ItemsExpr("Items")
                .ExpandedExpr("Expanded")
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
    BeginContext(5656, 314, true);
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
    BeginContext(6043, 198, true);
    WriteLiteral("\r\n                            function(args) {\r\n                                syncTreeViewSelection(args.component, component.option(\"value\"));\r\n                            }\r\n                    ");
    EndContext();
    PopWriter();
}
))
                );

#line default
#line hidden
            EndContext();
#line 165 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Question\Index.cshtml"
                 
            }

#line default
#line hidden
            BeginContext(6285, 95, true);
            WriteLiteral("\r\n            \r\n\r\n    \r\n\r\n\r\n\r\n<div class=\"row pb-5\">\r\n    <div class=\"text-left col\">\r\n        ");
            EndContext();
            BeginContext(6382, 101, false);
#line 176 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Question\Index.cshtml"
    Write(Html.DevExtreme().Button()
            .Type(ButtonType.Back).Icon("back").OnClick("Back")
        );

#line default
#line hidden
            EndContext();
            BeginContext(6484, 58, true);
            WriteLiteral("\r\n    </div>\r\n\r\n    <div class=\"text-right col\">\r\n        ");
            EndContext();
            BeginContext(6544, 122, false);
#line 182 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Question\Index.cshtml"
    Write(Html.DevExtreme().Button()
            .Type(ButtonType.Default).Icon("check").Text("Submit").OnClick("Submit")
        );

#line default
#line hidden
            EndContext();
            BeginContext(6667, 336, true);
            WriteLiteral(@"
    </div>
</div>



<script>
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
            BeginContext(7004, 31, false);
#line 200 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Question\Index.cshtml"
                           Write(Url.Action("Index","Questions"));

#line default
#line hidden
            EndContext();
            BeginContext(7035, 70, true);
            WriteLiteral("\";\r\n    }\r\n\r\n    function Submit() {\r\n        window.location.href = \"");
            EndContext();
            BeginContext(7106, 17, false);
#line 204 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Question\Index.cshtml"
                           Write(Url.Action("Put"));

#line default
#line hidden
            EndContext();
            BeginContext(7123, 1180, true);
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

        if ($dataGrid.le");
            WriteLiteral("ngth) {\r\n            var dataGrid = $dataGrid.dxDataGrid(\"instance\");\r\n            dataGrid.selectRows(e.value, false);\r\n        }\r\n    }\r\n\r\n</script>\r\n\r\n\r\n");
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