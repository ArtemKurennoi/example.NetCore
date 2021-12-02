using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace FinalTask.Models.Entity
{
    public class Exams
    {
        public int Id { get; set; }
        //Дата сдачи экзамена
        [Required(ErrorMessage = "Не указана дата")]
        [Display(Name = "Дата сдачи экзамена")]
        [DisplayFormat(DataFormatString ="{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DataExam { get; set; }
        //Название дисциплины(история, математика и т.д.)
        [Required(ErrorMessage = "Не указана дисциплина")]
        [Display(Name = "Дисциплина")]
        public string DisciplineName { get; set; }
        //Оценка за экзамен
        [Required(ErrorMessage = "Не указана оценка")]
        [Display(Name = "Оценка")]
        public int Score { get; set; }
        //поля студентов и преподователей
        public int? StudentId { get; set; }
        [Display(Name = "Студент")]
        public virtual Students Student { get; set; }
        public int? TeacherId { get; set; }
        [Display(Name = "Преподаватель")]
        public virtual Teachers Teacher { get; set; }

        //актуальность, для удаления, при инициализации все актуально!
        [Required]
        [Display(Name = "Актуальность")]
        [Compare(nameof(IsTrue), ErrorMessage = "Не выбрана актуальность")]
        public bool Relevance { get; set; } = true;

        //для проверки выбраной актуальности
        public bool IsTrue => true;
    }//Exams
}
