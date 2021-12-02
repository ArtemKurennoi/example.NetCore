using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace FinalTask.Models.Entity
{
    public class Students
    {
        public Students()
        {
            this.Exams = new HashSet<Exams>();
        }
        public int Id { get; set; }
        //Фамилия абитуриента
        [Required(ErrorMessage = "Не указана фамилия")]
        [Display(Name = "Фамилия")]
        public string SurName { get; set; }
        //Имя абитуриента
        [Required(ErrorMessage = "Не указано имя")]
        [Display(Name = "Имя")]
        public string Name { get; set; }
        //Отчество абитуриента
        [Required(ErrorMessage = "Не указано отчество")]
        [Display(Name = "Отчество")]
        public string Patronymic { get; set; }
        //Адрес абитуриента
        [Required(ErrorMessage = "Не указан адрес")]
        [Display(Name = "Адрес")]
        public string Address { get; set; }
        //Год рождения абитуриента
        [Required(ErrorMessage = "Не указан год рождения")]
        [Display(Name = "Год")]
        public int Year { get; set; }
        //Серия-номер паспорта абитуриента
        [Required(ErrorMessage = "Не указан паспорт")]
        [Display(Name = "Паспорт")]
        public string Passport { get; set; }
        //Фотография студента
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
    }//Students
}
