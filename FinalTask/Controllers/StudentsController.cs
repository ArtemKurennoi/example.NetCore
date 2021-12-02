using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalTask.Models.Context;
using FinalTask.Models.Entity;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace FinalTask.Controllers
{
    public class StudentsController : Controller
    {
        private readonly ExamsContext _context;
        private readonly IWebHostEnvironment _appEnvironment;

        public StudentsController(ExamsContext context, IWebHostEnvironment appEnvironment)
        {
            _context = context;
            _appEnvironment = appEnvironment;
        }

        // GET: Students
        public async Task<IActionResult> Index() => View(await _context.Students.Where(x => x.Relevance).ToListAsync());

        // GET: Students/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var students = await _context.Students
                .FirstOrDefaultAsync(m => m.Id == id);
            if (students == null)
            {
                return NotFound();
            }

            return View(students);
        }

        // GET: Students/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Students/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SurName,Name,Patronymic,Address,Year,Passport,Photo,Relevance")] Students students, IFormFile uploadedFile)
        {
            //если не валидно, ничего не делать
            if (!ModelState.IsValid) return View(students);
            // путь к папке с фотографиями
            string path = _appEnvironment.WebRootPath + "\\img\\students";
            //количество файлов в папке
            var countfile =Directory.GetFiles(path).Length;
            //имя файла
            string filename = $"student{++countfile}.jpg";
            //полный путь
            string fullpath = $"{path}\\{filename}";
            // сохраняем файл в папку Files в каталоге wwwroot
            using (var fileStream = new FileStream(fullpath, FileMode.Create))
            {
                await uploadedFile.CopyToAsync(fileStream);
            }
            //записываем это файл в объект
            students.Photo = filename;
            //добавление
            _context.Add(students);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Students/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var students = await _context.Students.FindAsync(id);
            if (students == null)
            {
                return NotFound();
            }
            return View(students);
        }

        // POST: Students/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SurName,Name,Patronymic,Address,Year,Passport,Photo,Relevance")] Students students)
        {
            if (id != students.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid) return View(students);
            try
            {
                _context.Update(students);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentsExists(students.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction(nameof(Index));
        }

        private bool StudentsExists(int id)
        {
            return _context.Students.Any(e => e.Id == id);
        }
    }
}
