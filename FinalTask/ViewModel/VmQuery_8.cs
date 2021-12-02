using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FinalTask.ViewModel
{
    /*Выполняет группировку по полю Наименование дисциплины в таблице ЭКЗАМЕНЫ. 
     Для каждой дисциплины вычисляет среднее значения по полю Оценка*/
    public class VmQuery_8
    {
        [Display(Name = "Наименование дисциплины")]
        public string DisciplineName { get; set; }
        [Display(Name = "Средняя оценка")]
        [DisplayFormat(DataFormatString = "{0:0.00}", ApplyFormatInEditMode = true)]
        public double AvgScore { get; set; }
    }//VmQuery_8
}
