#pragma checksum "F:\Артема\Devel\Программирование\C#\ASP Net\Куренной ASP Итоговое\Куренной ASP Итоговое\Куренной Артем\FinalTask\Views\Exams\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8618e551a0cf83a7bcccf340533885356f157c56"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Exams_Details), @"mvc.1.0.view", @"/Views/Exams/Details.cshtml")]
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
#nullable restore
#line 1 "F:\Артема\Devel\Программирование\C#\ASP Net\Куренной ASP Итоговое\Куренной ASP Итоговое\Куренной Артем\FinalTask\Views\_ViewImports.cshtml"
using FinalTask;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Артема\Devel\Программирование\C#\ASP Net\Куренной ASP Итоговое\Куренной ASP Итоговое\Куренной Артем\FinalTask\Views\_ViewImports.cshtml"
using FinalTask.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8618e551a0cf83a7bcccf340533885356f157c56", @"/Views/Exams/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"327cd49f57d69454c33ada102b329fb09983db5d", @"/Views/_ViewImports.cshtml")]
    public class Views_Exams_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FinalTask.Models.Entity.Exams>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Артема\Devel\Программирование\C#\ASP Net\Куренной ASP Итоговое\Куренной ASP Итоговое\Куренной Артем\FinalTask\Views\Exams\Details.cshtml"
  
    ViewData["Title"] = "Подробно";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div>\r\n    <h4>Подробно об экзамене</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "F:\Артема\Devel\Программирование\C#\ASP Net\Куренной ASP Итоговое\Куренной ASP Итоговое\Куренной Артем\FinalTask\Views\Exams\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DataExam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "F:\Артема\Devel\Программирование\C#\ASP Net\Куренной ASP Итоговое\Куренной ASP Итоговое\Куренной Артем\FinalTask\Views\Exams\Details.cshtml"
       Write(Html.DisplayFor(model => model.DataExam));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "F:\Артема\Devel\Программирование\C#\ASP Net\Куренной ASP Итоговое\Куренной ASP Итоговое\Куренной Артем\FinalTask\Views\Exams\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DisciplineName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "F:\Артема\Devel\Программирование\C#\ASP Net\Куренной ASP Итоговое\Куренной ASP Итоговое\Куренной Артем\FinalTask\Views\Exams\Details.cshtml"
       Write(Html.DisplayFor(model => model.DisciplineName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "F:\Артема\Devel\Программирование\C#\ASP Net\Куренной ASP Итоговое\Куренной ASP Итоговое\Куренной Артем\FinalTask\Views\Exams\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Score));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "F:\Артема\Devel\Программирование\C#\ASP Net\Куренной ASP Итоговое\Куренной ASP Итоговое\Куренной Артем\FinalTask\Views\Exams\Details.cshtml"
       Write(Html.DisplayFor(model => model.Score));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "F:\Артема\Devel\Программирование\C#\ASP Net\Куренной ASP Итоговое\Куренной ASP Итоговое\Куренной Артем\FinalTask\Views\Exams\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Student));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "F:\Артема\Devel\Программирование\C#\ASP Net\Куренной ASP Итоговое\Куренной ASP Итоговое\Куренной Артем\FinalTask\Views\Exams\Details.cshtml"
       Write(Html.DisplayFor(model => model.Student.SurName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 36 "F:\Артема\Devel\Программирование\C#\ASP Net\Куренной ASP Итоговое\Куренной ASP Итоговое\Куренной Артем\FinalTask\Views\Exams\Details.cshtml"
       Write(Html.DisplayFor(model => model.Student.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 37 "F:\Артема\Devel\Программирование\C#\ASP Net\Куренной ASP Итоговое\Куренной ASP Итоговое\Куренной Артем\FinalTask\Views\Exams\Details.cshtml"
       Write(Html.DisplayFor(model => model.Student.Patronymic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "F:\Артема\Devel\Программирование\C#\ASP Net\Куренной ASP Итоговое\Куренной ASP Итоговое\Куренной Артем\FinalTask\Views\Exams\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Teacher));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "F:\Артема\Devel\Программирование\C#\ASP Net\Куренной ASP Итоговое\Куренной ASP Итоговое\Куренной Артем\FinalTask\Views\Exams\Details.cshtml"
       Write(Html.DisplayFor(model => model.Teacher.SurName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 44 "F:\Артема\Devel\Программирование\C#\ASP Net\Куренной ASP Итоговое\Куренной ASP Итоговое\Куренной Артем\FinalTask\Views\Exams\Details.cshtml"
       Write(Html.DisplayFor(model => model.Teacher.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 45 "F:\Артема\Devel\Программирование\C#\ASP Net\Куренной ASP Итоговое\Куренной ASP Итоговое\Куренной Артем\FinalTask\Views\Exams\Details.cshtml"
       Write(Html.DisplayFor(model => model.Teacher.Patronymic));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 48 "F:\Артема\Devel\Программирование\C#\ASP Net\Куренной ASP Итоговое\Куренной ASP Итоговое\Куренной Артем\FinalTask\Views\Exams\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Relevance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 51 "F:\Артема\Devel\Программирование\C#\ASP Net\Куренной ASP Итоговое\Куренной ASP Итоговое\Куренной Артем\FinalTask\Views\Exams\Details.cshtml"
       Write(Html.DisplayFor(model => model.Relevance));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8618e551a0cf83a7bcccf340533885356f157c5610243", async() => {
                WriteLiteral("Редактировать");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 56 "F:\Артема\Devel\Программирование\C#\ASP Net\Куренной ASP Итоговое\Куренной ASP Итоговое\Куренной Артем\FinalTask\Views\Exams\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8618e551a0cf83a7bcccf340533885356f157c5612455", async() => {
                WriteLiteral("Вернуться к списку");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinalTask.Models.Entity.Exams> Html { get; private set; }
    }
}
#pragma warning restore 1591
