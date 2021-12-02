using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FinalTask.Models.Context;
using FinalTask.Models.Entity;
using FinalTask.ViewModel;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FinalTask.Controllers
{
    public class DbRequestsController : Controller
    {
        private readonly ExamsContext _context;
        public DbRequestsController(ExamsContext context)
        {
            _context = context;
        }

        #region Выбирает из таблицы АБИТУРИЕНТЫ информацию об абитуриентах, фамилия которых начинается с заданной буквы
        //первая загрузка страницы
        public async Task<IActionResult> Query_1() => View(await _context.Students.Where(x => x.Relevance).ToListAsync());

        //выборка данных
        [HttpPost]
        public IActionResult QueryJson_1(char letter)
        {
            List<Students> temp = null;
            if (ModelState.IsValid)
            {
                temp = _context.Students
                    .Where(x => x.Relevance)
                    .Select(x => new
                    {
                        x.Id,
                        x.SurName,
                        x.Name,
                        x.Patronymic,
                        x.Address,
                        x.Year,
                        x.Passport,
                        x.Photo
                    }).AsEnumerable()
                    .Where(x => x.SurName.FirstOrDefault() == letter)
                    .Select(x => new Students
                    {
                        SurName = x.SurName,
                        Name = x.Name,
                        Patronymic = x.Patronymic,
                        Address = x.Address,
                        Year = x.Year,
                        Passport = x.Passport,
                        Photo = x.Photo
                    }).ToList();
            }
            return Json(temp);
        }//QueryJson_1

        //запрос Все абитуриенты
        public async Task<IActionResult> QueryJson_1() => Json(await _context.Students.Where(x => x.Relevance).ToListAsync());
        #endregion


        #region Выбирает из таблицы ЭКЗАМЕНАТОРЫ информацию об экзаменаторах, для которых установлен размер оплаты за прием одного экзамена в заданном интервале
        //первая загрузка страницы
        public async Task<IActionResult> Query_2() => View(await _context.Teachers.Where(x => x.Relevance).ToListAsync());
        
        //выборка данных
        [HttpPost]
        public IActionResult QueryJson_2(double paymentfrom, double paymentto)
        {
            List<Teachers> temp = null;
            if (ModelState.IsValid)
            {
                temp = _context.Teachers
                    .Where(x => (x.ExamFee > paymentfrom && x.ExamFee < paymentto)
                                && x.Relevance)
                    .Select(x => new
                    {
                        x.Id,
                        x.SurName,
                        x.Name,
                        x.Patronymic,
                        x.ExamFee,
                        x.Photo
                    }).AsEnumerable().Select(x => new Teachers
                    {
                        SurName = x.SurName,
                        Name = x.Name,
                        Patronymic = x.Patronymic,
                        ExamFee = x.ExamFee,
                        Photo = x.Photo
                    }).ToList();
            }
            return Json(temp);
        }//QueryJson_2

        //запрос Все ЭКЗАМЕНАТОРЫ 
        public async Task<IActionResult> QueryJson_2() => Json(await _context.Teachers.Where(x => x.Relevance).ToListAsync());
        #endregion


        #region Выбирает из таблицы ЭКЗАМЕНЫ информацию об экзаменах, принятых заданным преподавателем
        //первая загрузка страницы
        public async Task<IActionResult> Query_3()
        {
            ViewBag.Teacher = new SelectList(_context.Teachers.Where(x => x.Relevance), "Id", "ToSelectList");

            return View(await _context.Exams.Include(e => e.Student).Include(e => e.Teacher).Where(x => x.Relevance).ToListAsync());
        }//Query_3

        //выборка данных
        [Exception] // перехват исключения фильтром 
        [HttpPost]
        public IActionResult QueryJson_3(int id)
        {
            ViewBag.Teacher = new SelectList(_context.Teachers.Where(x => x.Relevance), "Id", "ToSelectList");
            List<Exams> temp = null;
            if (ModelState.IsValid)
            {
                temp = _context.Exams
                    .Where(x => x.TeacherId == id
                                && x.Relevance)
                    .Select(x => new
                    {
                        x.Id,
                        x.DataExam,
                        x.DisciplineName,
                        x.Score,
                        x.Teacher,
                        x.Student
                    }).AsEnumerable().Select(x => new Exams
                    {
                        DataExam = x.DataExam,
                        DisciplineName = x.DisciplineName,
                        Score = x.Score,
                        Teacher = x.Teacher,
                        Student = x.Student
                    }).ToList();
            }
            return Json(temp);
        }//QueryJson_3

        //запрос Все ЭКЗАМЕНЫ  
        public async Task<IActionResult> QueryJson_3()
        {
            ViewBag.Teacher = new SelectList(_context.Teachers.Where(x => x.Relevance), "Id", "ToSelectList");
            var temp = await _context.Exams.Include(e => e.Student).Include(e => e.Teacher).Where(x => x.Relevance).ToListAsync();
            return Json(temp);
        }//QueryJson_3
        #endregion

        #region Выбирает из таблицы ЭКЗАМЕНАТОРЫ информацию об экзаменаторе с заданными фамилией, именем, отчеством.Конкретные фамилия, имя и отчество вводятся при выполнении запроса
        //первая загрузка страницы
        public async Task<IActionResult> Query_4() => View(await _context.Teachers.Where(x => x.Relevance).ToListAsync());

        //выборка данных
        [HttpPost]
        public IActionResult QueryJson_4(string surname, string name, string patronymic)
        {
            List<Teachers> temp = null;
            if (ModelState.IsValid)
            {
                temp = _context.Teachers
                    .Where(x => x.SurName == surname &&
                                x.Name == name
                                && x.Patronymic == patronymic
                                && x.Relevance)
                    .Select(x => new
                    {
                        x.Id,
                        x.SurName,
                        x.Name,
                        x.Patronymic,
                        x.ExamFee,
                        x.Photo
                    }).AsEnumerable().Select(x => new Teachers
                    {
                        SurName = x.SurName,
                        Name = x.Name,
                        Patronymic = x.Patronymic,
                        ExamFee = x.ExamFee,
                        Photo = x.Photo
                    }).ToList();
            }
            return Json(temp);
        }//QueryJson_4

        //запрос Все ЭКЗАМЕНАТОРЫ 
        public async Task<IActionResult> QueryJson_4() => Json(await _context.Teachers.Where(x => x.Relevance).ToListAsync());

        #endregion

        #region Выбирает из таблиц АБИТУРИЕНТЫ, ЭКЗАМЕНАТОРЫ и ЭКЗАМЕНЫ информацию обо всех экзаменах(ФИО абитуриента, ФИО экзаменатора, Наименование дисциплины, Дата сдачи экзамена, Оценка) в некоторый заданный интервал времени.Нижняя и верхняя границы интервала задаются при выполнении запроса
        //первая загрузка страницы
        public async Task<IActionResult> Query_5() => 
            View(await _context.Exams.Include(e => e.Student).Include(e => e.Teacher).Where(x => x.Relevance).ToListAsync());
        
        //выборка данных
        [Exception] // перехват исключения фильтром 
        [HttpPost]
        public IActionResult QueryJson_5(DateTime from, DateTime to)
        {
            List<Exams> temp = null;
            if (ModelState.IsValid)
            {
                temp = _context.Exams
                    .Where(x => (x.DataExam > from && x.DataExam < to)
                                && x.Relevance)
                    .Select(x => new
                    {
                        x.Id,
                        x.DataExam,
                        x.DisciplineName,
                        x.Score,
                        x.Teacher,
                        x.Student
                    }).AsEnumerable().Select(x => new Exams
                    {
                        DataExam = x.DataExam,
                        DisciplineName = x.DisciplineName,
                        Score = x.Score,
                        Teacher = x.Teacher,
                        Student = x.Student
                    }).ToList();
            }
            return Json(temp);
        }//QueryJson_5

        //запрос Все ЭКЗАМЕНЫ  
        public async Task<IActionResult> QueryJson_5() =>
            Json(await _context.Exams.Include(e => e.Student).Include(e => e.Teacher).Where(x => x.Relevance).ToListAsync());
        #endregion

        //Вычисляет для каждого экзамена размер налога(Налог= Размер оплаты*13%) и зарплаты экзаменатора(Зарплата= Размер оплаты - Налог). Сортировка по полю Дата сдачи экзамена
        public IActionResult Query_6()
        {
             List<VmQuery_6> temp = _context.Exams
                    .Where(x => x.Relevance)
                    .Select(x => new
                    {
                        x.Id,
                        x.DisciplineName,
                        x.Teacher.SurName,
                        x.Teacher.Name,
                        x.Teacher.Patronymic,
                        x.DataExam,
                        x.Teacher.ExamFee,
                        Tax=(x.Teacher.ExamFee*13)/100,
                        Salary=x.Teacher.ExamFee- ((x.Teacher.ExamFee * 13) / 100)
                    }).Distinct().AsEnumerable().Select(x => new VmQuery_6
                    {
                        DataExam = x.DataExam,
                        DisciplineName = x.DisciplineName,
                        SurNameNP = $"{x.SurName} {x.Name[0]}.{x.Patronymic[0]}.",
                        ExamFee = x.ExamFee,
                        Tax = x.Tax,
                        Salary = x.Salary
                        
                    }).OrderBy(x=>x.DataExam).ToList();
            return View(temp);
        }//Query_6

        //Выполняет группировку по полю Год рождения в таблице АБИТУРИЕНТЫ.Для каждой группы определяет количество абитуриентов
        public IActionResult Query_7()
        {
            List<VmQuery_7> temp = _context.Students
                .Where(x => x.Relevance)
                .GroupBy(x => x.Year, (key, group) => new
                {
                    Year = key,
                    Count = group.Count()
                }).AsEnumerable().Select(x => new VmQuery_7
                {
                   Year = x.Year,
                   CountStudents = x.Count
                }).ToList();
            return View(temp);
        }//Query_7

        //Выполняет группировку по полю Наименование дисциплины в таблице ЭКЗАМЕНЫ.Для каждой дисциплины вычисляет среднее значения по полю Оценка
        public IActionResult Query_8()
        {
            List<VmQuery_8> temp = _context.Exams
                .Where(x => x.Relevance)
                .GroupBy(x => x.DisciplineName, (key, group) => new
                {
                    DisciplineName = key,
                    AvgScore = group.Average(x=>x.Score)
                }).AsEnumerable().Select(x => new VmQuery_8
                {
                    DisciplineName = x.DisciplineName,
                    AvgScore = x.AvgScore
                }).ToList();
            return View(temp);
        }//Query_8
    }
}
