using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FinalTask.ViewModel
{
    /*Вычисляет для каждого экзамена размер налога (Налог=Размер оплаты*13%) и 
     зарплаты экзаменатора (Зарплата=Размер оплаты - Налог). Сортировка по полю Дата сдачи экзамена*/
    public class VmQuery_6
    {
        [Display(Name = "Дата сдачи экзамена")]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataExam { get; set; }
        [Display(Name = "Дисциплина")]
        public string DisciplineName { get; set; }
        [Display(Name = "ФИО экзаменатора")]
        public string SurNameNP { get; set; }
        [Display(Name = "Стоимость экзамена")]
        public double ExamFee { get; set; }

        [Display(Name = "Размер налога")]
        public double Tax { get; set; }

        [Display(Name = "Зарплата экзаменатора")]
        public double Salary { get; set; }
    }
}
