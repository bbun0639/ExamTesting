#pragma checksum "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\User\Views\Exam\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4e66fdb2d53d41d7c268c728340fbe5db8bc11a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_User_Views_Exam_Details), @"mvc.1.0.view", @"/Areas/User/Views/Exam/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/User/Views/Exam/Details.cshtml", typeof(AspNetCore.Areas_User_Views_Exam_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4e66fdb2d53d41d7c268c728340fbe5db8bc11a", @"/Areas/User/Views/Exam/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff0bbdc15d68186c6ba41cb7fb4752922ee8bab0", @"/Areas/User/Views/_ViewImports.cshtml")]
    public class Areas_User_Views_Exam_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExamTesting.Models.UserExam>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 136, true);
            WriteLiteral("\r\n\r\n<div id=\"form-container\" class=\"row\">\r\n\r\n    <div class=\"col\">\r\n\r\n        <div class=\"col mb-4 h3 font-weight-normal\">\r\n            ");
            EndContext();
            BeginContext(174, 19, false);
#line 9 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\User\Views\Exam\Details.cshtml"
       Write(Model.Exam.ExamCode);

#line default
#line hidden
            EndContext();
            BeginContext(193, 3, true);
            WriteLiteral(" : ");
            EndContext();
            BeginContext(197, 19, false);
#line 9 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\User\Views\Exam\Details.cshtml"
                              Write(Model.Exam.ExamName);

#line default
#line hidden
            EndContext();
            BeginContext(216, 82, true);
            WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"p-4 bg-light rounded col\">\r\n\r\n            ");
            EndContext();
            BeginContext(300, 2328, false);
#line 14 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\User\Views\Exam\Details.cshtml"
        Write(Html.DevExtreme().Form<ExamTesting.Models.Exam>()
            .ID("form")
            .ColCount(1)
            .Items(items =>
            {
                items.AddGroup()
                    .Caption("Exam Info")
                    .Template(item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
    PushWriter(__razor_template_writer);
    BeginContext(560, 98, true);
    WriteLiteral("\r\n                        <div class=\"h6 font-weight-normal\">\r\n                            Code : ");
    EndContext();
    BeginContext(659, 19, false);
#line 23 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\User\Views\Exam\Details.cshtml"
                              Write(Model.Exam.ExamCode);

#line default
#line hidden
    EndContext();
    BeginContext(678, 135, true);
    WriteLiteral("\r\n                        </div>\r\n\r\n                        <div class=\"h6 font-weight-normal\">\r\n                            Subject : ");
    EndContext();
    BeginContext(814, 30, false);
#line 27 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\User\Views\Exam\Details.cshtml"
                                 Write(Model.Exam.Subject.SubjectName);

#line default
#line hidden
    EndContext();
    BeginContext(844, 135, true);
    WriteLiteral("\r\n                        </div>\r\n\r\n                        <div class=\"h6 font-weight-normal\">\r\n                            Version : ");
    EndContext();
    BeginContext(980, 22, false);
#line 31 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\User\Views\Exam\Details.cshtml"
                                 Write(Model.Exam.ExamVersion);

#line default
#line hidden
    EndContext();
    BeginContext(1002, 138, true);
    WriteLiteral("\r\n                        </div>\r\n\r\n                        <div class=\"h6 font-weight-normal\">\r\n                            Strat Date : ");
    EndContext();
    BeginContext(1141, 55, false);
#line 35 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\User\Views\Exam\Details.cshtml"
                                    Write(String.Format("{0:d MMMM yyyy}", @Model.Exam.StartDate));

#line default
#line hidden
    EndContext();
    BeginContext(1196, 135, true);
    WriteLiteral("\r\n                        </div>\r\n\r\n                        <div class=\"h6 font-weight-normal\">\r\n                            End Date: ");
    EndContext();
    BeginContext(1332, 53, false);
#line 39 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\User\Views\Exam\Details.cshtml"
                                 Write(String.Format("{0:d MMMM yyyy}", @Model.Exam.EndDate));

#line default
#line hidden
    EndContext();
    BeginContext(1385, 153, true);
    WriteLiteral("\r\n                        </div>\r\n\r\n                        <div class=\"h6 font-weight-normal text-success\">\r\n                            Passing Rate : ");
    EndContext();
    BeginContext(1539, 22, false);
#line 43 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\User\Views\Exam\Details.cshtml"
                                      Write(Model.Exam.PercentPass);

#line default
#line hidden
    EndContext();
    BeginContext(1561, 189, true);
    WriteLiteral(" %\r\n                        </div>\r\n\r\n                        <br />\r\n\r\n                        <div class=\"h6 font-weight-normal text-danger\">\r\n                            Remaining Day : ");
    EndContext();
    BeginContext(1751, 23, false);
#line 49 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\User\Views\Exam\Details.cshtml"
                                       Write(Model.Exam.RemainingDay);

#line default
#line hidden
    EndContext();
    BeginContext(1774, 143, true);
    WriteLiteral("\r\n                        </div>\r\n\r\n\r\n                        <div class=\"row pt-4\">\r\n                            <div class=\"text-left col\">\r\n");
    EndContext();
    BeginContext(1917, 195, false);
#line 55 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\User\Views\Exam\Details.cshtml"
Write(Html.DevExtreme().Button()
                                   .Icon("back")
                                   .OnClick("Back")
                                );

#line default
#line hidden
    EndContext();
    BeginContext(2115, 100, true);
    WriteLiteral("\r\n                            </div>\r\n\r\n                            <div class=\"text-right col\">\r\n\r\n");
    EndContext();
    BeginContext(2215, 272, false);
#line 63 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\User\Views\Exam\Details.cshtml"
Write(Html.DevExtreme().Button()
                                    .Type(ButtonType.Default)
                                    .Text("Start Exam")
                                    .OnClick("StartExam")
                                );

#line default
#line hidden
    EndContext();
    BeginContext(2490, 122, true);
    WriteLiteral("\r\n                            </div>\r\n                            \r\n                        </div>\r\n\r\n                    ");
    EndContext();
    PopWriter();
}
));

            })

            );

#line default
#line hidden
            EndContext();
            BeginContext(2656, 436, true);
            WriteLiteral(@"


        </div>

    </div>


    <div class=""col-3 row"">

        <div class=""card w-100 h-25 bg-light"">

        </div>

        <div class=""card w-100 h-25 bg-light"">

        </div>

        <div class=""card w-100 h-25 bg-light"">

        </div>

        <div class=""card w-100 h-25 bg-light"">

        </div>
    </div>

</div>




<script>
    function Back() {
        window.location.href = """);
            EndContext();
            BeginContext(3093, 27, false);
#line 110 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\User\Views\Exam\Details.cshtml"
                           Write(Url.Action("Index","Exams"));

#line default
#line hidden
            EndContext();
            BeginContext(3120, 73, true);
            WriteLiteral("\";\r\n    }\r\n\r\n    function StartExam() {\r\n        window.location.href = \"");
            EndContext();
            BeginContext(3194, 19, false);
#line 114 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\User\Views\Exam\Details.cshtml"
                           Write(Url.Action("Start"));

#line default
#line hidden
            EndContext();
            BeginContext(3213, 1, true);
            WriteLiteral("/");
            EndContext();
            BeginContext(3215, 12, false);
#line 114 "D:\TraineePROJ\Proj 5 ExamTesting\ExamTesting\DXApplication1\ExamTesting.FrontEnd\Areas\User\Views\Exam\Details.cshtml"
                                                Write(Model.ExamId);

#line default
#line hidden
            EndContext();
            BeginContext(3227, 24, true);
            WriteLiteral("\";\r\n    }\r\n\r\n</script>\r\n");
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
