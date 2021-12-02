using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FinalTask.ViewModel
{
    /*Выполняет группировку по полю Год рождения в таблице АБИТУРИЕНТЫ. 
     * Для каждой группы определяет количество абитуриентов */
    public class VmQuery_7
    {
        [Display(Name = "Год рождения")]
        public int Year { get; set; }
        [Display(Name = "Количество абитуриентов")]
        public int CountStudents { get; set; }
    }
}
