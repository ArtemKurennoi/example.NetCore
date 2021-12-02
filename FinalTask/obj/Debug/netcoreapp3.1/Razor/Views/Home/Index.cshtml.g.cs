#pragma checksum "F:\Артема\Devel\Программирование\C#\ASP Net\Куренной ASP Итоговое\Куренной ASP Итоговое\Куренной Артем\FinalTask\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d255c6f298f90f8a47a52a18ee5c68ddd97363c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d255c6f298f90f8a47a52a18ee5c68ddd97363c4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"327cd49f57d69454c33ada102b329fb09983db5d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "F:\Артема\Devel\Программирование\C#\ASP Net\Куренной ASP Итоговое\Куренной ASP Итоговое\Куренной Артем\FinalTask\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Итоговое задание";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""row"">
    <div class=""col-md-12 "">
        <h2 class=""text-center"">Итоговое задание</h2>
        <h4>Задача 2 (12 баллов). </h4>
        <p>
            Разработайте ASP.NET Core MVC приложение. База данных должна быть размещена в <strong>LocalDb,</strong> для работы с базой данных примените Entity Framework Core.
        </p>
        <p>
            Дизайн страниц приложения произволен, но все-таки требуется выводить данные о разработчике и задание на разработку по отдельным командам.
        </p>
        <p>
            Реализуйте фильтры исключений, компоненты, вспомогательные дескрипторные классы, замещающие теги.
        </p>
        <p>
            Используйте AJAX jQuery для получения и отправки данных (по возможности).
        </p>
        <table class=""table table-bordered table-sm table-responsive-md"">
            <tbody>
                <tr>
                    <td>База данных <strong>«Учет результатов сдачи вступительных экзаменов»</strong></td>
                ");
            WriteLiteral(@"</tr>
                <tr>
                    <td>
                        <p><strong>Описание предметной области</strong></p>
                        <p>
                            База данных должна содержать информацию об абитуриентах, экзаменаторах и результатах сдачи вступительных экзаменов. При занесении информации о конкретном экзамене указывается: дата сдачи экзамена, название экзамена, кто сдавал экзамен, кто принимал экзамен, каков результат сдачи экзамена.
                        </p>
                        <p>
                            Экзаменатор получает за прием экзамена установленную оплату, которая назначается индивидуально. С этой суммы удерживается подоходный налог в размере 13%. Учебное заведение отчисляет в бюджет социальный налог в размере 20% от начисленной преподавателю оплаты за прием экзамена.
                        </p>
                    </td>
                </tr>
                <tr>
                    <td>
                        <strong>База данных должна ");
            WriteLiteral(@"включать таблицы АБИТУРИЕНТЫ, ЭКЗАМЕНАТОРЫ и ЭКЗАМЕНЫ, содержащие следующую информацию:</strong>
                    </td>
                </tr>
                <tr>
                    <td>
                        <ul>
                            <li>Фамилия абитуриента</li>
                            <li>Имя абитуриента                                      </li>
                            <li>Отчество абитуриента                                 </li>
                            <li>Адрес абитуриента                                    </li>
                            <li>Год рождения абитуриента                             </li>
                            <li>Серия-номер паспорта абитуриента                     </li>
                            <li>Фотография студента                                  </li>
                            <li>Фамилия экзаменатора (преподавателя)                 </li>
                            <li>Имя экзаменатора (преподавателя)                     </li>
    ");
            WriteLiteral(@"                        <li>Отчество экзаменатора (преподавателя)                </li>
                            <li>
                                Размер оплаты за прием экзамена у одного абитуриента
                                (может различаться для разных преподавателей)
                            </li>
                            <li>Фотография экзаменатора (преподавателя)              </li>
                            <li>Дата сдачи экзамена                                  </li>
                            <li>Название дисциплины (история, математика и т.д.)     </li>
                            <li>Оценка за экзамен                                    </li>
                        </ul>
                    </td>
                </tr>
                <tr>
                    <td>
                        <p class=""text-center""><strong>ЗАДАНИЕ НА ВЫПОЛНЕНИЕ</strong></p>
                        <ol>
                            <li>Определить состав полей базовых таблиц.</li>
      ");
            WriteLiteral(@"                      <li>Определить <strong>свойства</strong> каждого поля в таблице.</li>
                            <li>В каждой таблице определить <strong>ключевое поле.</strong></li>
                            <li>Определить <strong>тип связей между таблицами</strong> базы данных.</li>
                            <li><strong>Установить связи</strong> между таблицами.</li>
                            <li>
                                Заполнить таблицы данными. Каждая таблица должна содержать <strong>не менее 10 записей.</strong>
                                Начальное заполнение – классом инициализатором при каждом запуске приложения.
                            </li>
                        </ol>
                    </td>
                </tr>
            </tbody>
        </table>
        <p>Вывести таблицы базы данных в отдельные вкладки. Реализовать запросы:</p>

        <table class=""table table-bordered table-sm table-responsive-md"">
            <thead>
                <tr>
 ");
            WriteLiteral(@"                   <th class=""text-center"" colspan=""3"">ЗАПРОСЫ</th>
                </tr>
                <tr>
                    <th>Номер запроса</th>
                    <th>Тип запроса</th>
                    <th class=""text-center"">Какую задачу решает запрос</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>1</td>
                    <td>Запрос на выборку</td>
                    <td>Выбирает из таблицы <strong>АБИТУРИЕНТЫ</strong> информацию об абитуриентах, фамилия которых начинается с заданной буквы</td>
                </tr>
                <tr>
                    <td>2</td>
                    <td>Запрос на выборку</td>
                    <td>Выбирает из таблицы <strong>ЭКЗАМЕНАТОРЫ</strong> информацию об экзаменаторах, для которых установлен размер оплаты за прием одного экзамена в заданном интервале</td>
                </tr>
                <tr>
                    <td>3</td>
                    <td>Запрос на ");
            WriteLiteral(@"выборку</td>
                    <td>Выбирает из таблицы <strong>ЭКЗАМЕНЫ</strong> информацию об экзаменах, принятых заданным преподавателем</td>
                </tr>
                <tr>
                    <td>4</td>
                    <td>Запрос с параметром</td>
                    <td>Выбирает из таблицы <strong>ЭКЗАМЕНАТОРЫ</strong> информацию об экзаменаторе с заданными фамилией, именем, отчеством. Конкретные фамилия, имя и отчество вводятся при выполнении запроса</td>
                </tr>
                <tr>
                    <td>5</td>
                    <td>Запрос с параметром</td>
                    <td>Выбирает из таблиц <strong>АБИТУРИЕНТЫ</strong>, <strong>ЭКЗАМЕНАТОРЫ</strong> и <strong>ЭКЗАМЕНЫ</strong> информацию обо всех экзаменах (ФИО абитуриента, ФИО экзаменатора, Наименование дисциплины, Дата сдачи экзамена, Оценка) в некоторый заданный интервал времени. Нижняя и верхняя границы интервала задаются при выполнении запроса</td>
                </tr>
                <tr>
            WriteLiteral(@"
                    <td>6</td>
                    <td>Запрос с вычисляемыми полями</td>
                    <td>Вычисляет для каждого экзамена размер налога (Налог=Размер оплаты*13%) и зарплаты экзаменатора (Зарплата=Размер оплаты - Налог). Сортировка по полю Дата сдачи экзамена</td>
                </tr>
                <tr>
                    <td>7</td>
                    <td>Итоговый запрос</td>
                    <td>Выполняет группировку по полю Год рождения в таблице <strong>АБИТУРИЕНТЫ.</strong> Для каждой группы определяет количество абитуриентов </td>
                </tr>
            <tr>
                <td>8</td>
                <td>Итоговый запрос</td>
                <td>Выполняет группировку по полю Наименование дисциплины в таблице <strong>ЭКЗАМЕНЫ.</strong> Для каждой дисциплины вычисляет среднее значения по полю Оценка</td>
            </tr>
            <tr>
                <td>9</td>
                <td>Запрос на удаление</td>
                <td>Удалить данные об абит");
            WriteLiteral(@"уриенте, удаление безопасное</td>
            </tr>
            <tr>
                <td>10</td>
                <td>Запрос на удаление</td>
                <td>Удалить данные об экзаменаторе, удаление безопасное</td>
            </tr>
            <tr>
                <td>11</td>
                <td>Запрос на удаление</td>
                <td>Удалить данные о сданном абитуриентом экзамене, удаление безопасное</td>
            </tr>
            <tr>
                <td>12</td>
                <td>Запрос на обновление</td>
                <td>Изменить данные об абитуриенте</td>
            </tr>
            <tr>
                <td>13</td>
                <td>Запрос на обновление</td>
                <td>Изменить данные об экзаменаторе</td>
            </tr>
            <tr>
                <td>14</td>
                <td>Запрос на обновление</td>
                <td>Изменить данные о сданном абитуриентом экзамене</td>
            </tr>
            <tr>
                <td>15</td>
 ");
            WriteLiteral(@"               <td>Запрос на добавление</td>
                <td>Добавить абитуриента</td>
            </tr>
            <tr>
                <td>16</td>
                <td>Запрос на добавление</td>
                <td>Добавить преподавателя</td>
            </tr>
            <tr>
                <td>17</td>
                <td>Запрос на добавление</td>
                <td>Добавить запись о сданном экзамене</td>
            </tr>
            </tbody>
        </table>
        <p><strong>Срок выполнения задания – 2 недели, до 14.11.2021.</strong></p>
        <p>
            <h4>Дополнительно</h4>
            Запись занятия можно скачать по <a href=""https://cloud.mail.ru/public/3rWd/MfZpH4rpW"">этой ссылке.</a>
            Материалы занятия в этом же архиве.
        </p>
    </div>
</div>
");
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