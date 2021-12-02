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
    public class TeachersController : Controller
    {
        private readonly ExamsContext _context;
        private readonly IWebHostEnvironment _appEnvironment;

        public TeachersController(ExamsContext context, IWebHostEnvironment appEnvironment)
        {
            _context = context;
            _appEnvironment = appEnvironment;
        }

        // GET: Teachers
        public async Task<IActionResult> Index() => View(await _context.Teachers.Where(x=>x.Relevance).ToListAsync());

        // GET: Teachers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teachers = await _context.Teachers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (teachers == null)
            {
                return NotFound();
            }

            return View(teachers);
        }

        // GET: Teachers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Teachers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SurName,Name,Patronymic,ExamFee,Photo,Relevance")] Teachers teachers, IFormFile uploadedFile)
        {
            //если не валидно, ничего не делать
            if (!ModelState.IsValid) return View(teachers);
            // путь к папке с фотографиями
            string path = _appEnvironment.WebRootPath + "\\img\\teachers";
            //количество файлов в папке
            var countfile = Directory.GetFiles(path).Length;
            //имя файла
            string filename = $"teacher{++countfile}.jpg";
            //полный путь
            string fullpath = $"{path}\\{filename}";
            // сохраняем файл в папку Files в каталоге wwwroot
            using (var fileStream = new FileStream(fullpath, FileMode.Create))
            {
                await uploadedFile.CopyToAsync(fileStream);
            }
            //записываем это файл в объект
            teachers.Photo = filename;
            //добавление
            _context.Add(teachers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        // GET: Teachers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var teachers = await _context.Teachers.FindAsync(id);
            if (teachers == null)
            {
                return NotFound();
            }
            return View(teachers);
        }

        // POST: Teachers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,SurName,Name,Patronymic,ExamFee,Photo,Relevance")] Teachers teachers)
        {
            if (id != teachers.Id)
            {
                return NotFound();
            }

            if (!ModelState.IsValid) return View(teachers);
            try
            {
                _context.Update(teachers);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TeachersExists(teachers.Id))
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

        private bool TeachersExists(int id)
        {
            return _context.Teachers.Any(e => e.Id == id);
        }
    }
}
