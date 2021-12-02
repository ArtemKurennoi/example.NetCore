using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace FinalTask.Models.Entity
{
    public class Teachers
    {
        public Teachers()
        {
            this.Exams = new HashSet<Exams>();
        }
        public int Id { get; set; }
        //Фамилия экзаменатора(преподавателя)
        [Required(ErrorMessage = "Не указана фамилия")]
        [Display(Name = "Фамилия")]
        public string SurName { get; set; }
        //Имя экзаменатора(преподавателя)
        [Required(ErrorMessage = "Не указано имя")]
        [Display(Name = "Имя")]
        public string Name { get; set; }
        //Отчество экзаменатора(преподавателя)
        [Required(ErrorMessage = "Не указано отчество")]
        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }
        //Размер оплаты за прием экзамена у одного абитуриента
        //(может различаться для разных преподавателей)
        [Required(ErrorMessage = "Не указана стоимость экзамена")]
        [Display(Name = "Стоимость экзамена")]
        public double ExamFee { get; set; }
        //Фотография экзаменатора(преподавателя)
        [Display(Name = "Фотография")]
        public string Photo { get; set; }
        //актуальность, для удаления, при инициализации все актуально!
        [Required]
        [Display(Name = "Актуальность")]
        [Compare(nameof(IsTrue), ErrorMessage = "Не выбрана актуальность")]
        public bool Relevance { get; set; } = true;
        //связь
        public virtual ICollection<Exams> Exams { get; set; }

        //для выпадающего списка
        public string ToSelectList => $"{SurName} {Name} {Patronymic}";

        //для проверки выбраной актуальности
        public bool IsTrue => true;
    }//Teachers
}
