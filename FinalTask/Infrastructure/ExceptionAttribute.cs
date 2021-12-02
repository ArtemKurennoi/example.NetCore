using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace FinalTask.ViewModel
{
    /*Вычисляет для каждого экзамена размер налога (Налог=Размер оплаты*13%) и 
     зарплаты экзаменатора (Зарплата=Размер оплаты - Налог). Сортировка по полю Дата сдачи экзамена*/
    public class ExceptionAttribute : ExceptionFilterAttribute
    {
        public override void OnException(ExceptionContext context)
        {
            // возврат другого представления в случае ошибки
            context.Result = new ViewResult
            {
                ViewName = "Error"
            };
        }
    }
}
