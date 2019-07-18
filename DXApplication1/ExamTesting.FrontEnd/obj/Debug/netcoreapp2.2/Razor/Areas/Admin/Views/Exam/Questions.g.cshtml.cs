#pragma checksum "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Exam\Questions.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51524a966626e022a09764e690dcfadf96f4262a"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51524a966626e022a09764e690dcfadf96f4262a", @"/Areas/Admin/Views/Exam/Questions.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff0bbdc15d68186c6ba41cb7fb4752922ee8bab0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Exam_Questions : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExamTesting.Models.Exam>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddQuestions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(60, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(64, 2154, false);
#line 4 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Exam\Questions.cshtml"
Write(Html.DevExtreme().DataGrid<ExamTesting.Models.Question>()
.ID("gridContainer")
.DataSource(d => d.Mvc()
    .Controller("Questions")
    .LoadAction("Get")
    .Key("QuestionId")
)

.FilterRow(filterRow => filterRow
.Visible(false)
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
    //columns.AddFor(m => m.QuestionId)
    //    .Width(120)
    //    .Caption("Select")
    //    .FormItem(i => i
    //        .Editor(e => e.CheckBox())
    //        )
    //    .AllowEditing(true)
    //    .Alignment(HorizontalAlignment.Center);

    columns.AddFor(m => m.QuestionStr).Caption("Question")
        .CellTemplate
            (item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    BeginContext(906, 122, true);
    WriteLiteral("\r\n                        <a href=\"/Admin/Question/Index/<%= data.QuestionId %>\"><%= data.QuestionStr %></a>\r\n            ");
    EndContext();
    PopWriter();
}
));

columns.AddFor(m => m.QuestionType).Caption("Question Type").Visible(false)
 .Lookup(lookup => lookup.DataSource(Html.GetEnumSelectList<QuestionType>()
             .Select(l => new { Value = int.Parse(l.Value), Text = l.Text }))
             .ValueExpr("Value")
             .DisplayExpr("Text")
         );

columns.AddFor(m => m.QuestionLevel).Caption("Question Level").Visible(false)
 .Lookup(lookup => lookup
     .DataSource(Html.GetEnumSelectList<EnumLevel>()
             .Select(l => new { Value = int.Parse(l.Value), Text = l.Text }))
             .ValueExpr("Value")
             .DisplayExpr("Text")
         );

columns.AddFor(m => m.TopicId).Caption("Topic")
.Lookup(lookup => lookup
     .DataSource(d => d.Mvc().Controller("Questions").LoadAction("GetTopicDropdown").Key("TopicId"))
             .ValueExpr("TopicId")
             .DisplayExpr("TopicName")
         )
.Width(150)
.Alignment(HorizontalAlignment.Center);


columns.AddFor(m => m.QuestionPoint).Caption("Point")
.Width(100)
.Alignment(HorizontalAlignment.Center);

})
.ShowBorders(true)
.Selection(s => s.Mode(SelectionMode.Multiple))
.OnSelectionChanged("selection_changed")

);

#line default
#line hidden
            EndContext();
            BeginContext(2233, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(2237, 421, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "51524a966626e022a09764e690dcfadf96f4262a6834", async() => {
                BeginContext(2302, 349, true);
                WriteLiteral(@"
    <input type=""submit"" />
    <textarea type=""text"" id=""questionsString"" rows=""10"" cols=""100""></textarea>
    <script>
        function selection_changed(selectedItems) {
            var data = selectedItems.selectedRowsData;
            document.getElementById(""questionsString"").value = JSON.stringify(data);

        }
    </script>
");
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
#line 78 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\Admin\Views\Exam\Questions.cshtml"
                                  WriteLiteral(Model.ExamCodeId);

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
