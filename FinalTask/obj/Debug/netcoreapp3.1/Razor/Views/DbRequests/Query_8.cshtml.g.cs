#pragma checksum "F:\Артема\Devel\Программирование\C#\ASP Net\Куренной ASP Итоговое\Куренной ASP Итоговое\Куренной Артем\FinalTask\Views\DbRequests\Query_8.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52bb42f68eb45997d08bde2d6e15d12d00ebff49"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DbRequests_Query_8), @"mvc.1.0.view", @"/Views/DbRequests/Query_8.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52bb42f68eb45997d08bde2d6e15d12d00ebff49", @"/Views/DbRequests/Query_8.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"327cd49f57d69454c33ada102b329fb09983db5d", @"/Views/_ViewImports.cshtml")]
    public class Views_DbRequests_Query_8 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<FinalTask.ViewModel.VmQuery_8>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Артема\Devel\Программирование\C#\ASP Net\Куренной ASP Итоговое\Куренной ASP Итоговое\Куренной Артем\FinalTask\Views\DbRequests\Query_8.cshtml"
  
    ViewData["Title"] = "Запросы";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Запрос 8</h2>


<div class=""row"">
    <div class=""col-md-12 "">
        <h5 class=""m-3 text-center"">
            Выполняет группировку по полю Наименование дисциплины в таблице ЭКЗАМЕНЫ. Для каждой дисциплины вычисляет среднее значения по полю Оценка
        </h5>
        <table class=""table table-hover table-striped table-sm table-responsive-md"">
            <thead>
                <tr>
                    <th>
                        ");
#nullable restore
#line 19 "F:\Артема\Devel\Программирование\C#\ASP Net\Куренной ASP Итоговое\Куренной ASP Итоговое\Куренной Артем\FinalTask\Views\DbRequests\Query_8.cshtml"
                   Write(Html.DisplayNameFor(model => model.DisciplineName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 22 "F:\Артема\Devel\Программирование\C#\ASP Net\Куренной ASP Итоговое\Куренной ASP Итоговое\Куренной Артем\FinalTask\Views\DbRequests\Query_8.cshtml"
                   Write(Html.DisplayNameFor(model => model.AvgScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 27 "F:\Артема\Devel\Программирование\C#\ASP Net\Куренной ASP Итоговое\Куренной ASP Итоговое\Куренной Артем\FinalTask\Views\DbRequests\Query_8.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 31 "F:\Артема\Devel\Программирование\C#\ASP Net\Куренной ASP Итоговое\Куренной ASP Итоговое\Куренной Артем\FinalTask\Views\DbRequests\Query_8.cshtml"
                       Write(Html.DisplayFor(modelItem => item.DisciplineName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 34 "F:\Артема\Devel\Программирование\C#\ASP Net\Куренной ASP Итоговое\Куренной ASP Итоговое\Куренной Артем\FinalTask\Views\DbRequests\Query_8.cshtml"
                       Write(Html.DisplayFor(modelItem => item.AvgScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 37 "F:\Артема\Devel\Программирование\C#\ASP Net\Куренной ASP Итоговое\Куренной ASP Итоговое\Куренной Артем\FinalTask\Views\DbRequests\Query_8.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<FinalTask.ViewModel.VmQuery_8>> Html { get; private set; }
    }
}
#pragma warning restore 1591
