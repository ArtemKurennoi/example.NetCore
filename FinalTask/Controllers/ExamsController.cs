using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FinalTask.Models.Context;
using FinalTask.Models.Entity;

namespace FinalTask.Controllers
{
    public class ExamsController : Controller
    {
        private readonly ExamsContext _context;

        public ExamsController(ExamsContext context)
        {
            _context = context;
        }

        // GET: Exams
        public async Task<IActionResult> Index()
        {
            var examsContext = _context.Exams.Include(e => e.Student).Include(e => e.Teacher);
            return View(await examsContext.Where(x => x.Relevance).ToListAsync());
        }

        // GET: Exams/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exams = await _context.Exams
                .Include(e => e.Student)
                .Include(e => e.Teacher)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (exams == null)
            {
                return NotFound();
            }

            return View(exams);
        }

        // GET: Exams/Create
        public IActionResult Create()
        {
            ViewData["StudentId"] = new SelectList(_context.Students.Where(x=>x.Relevance), "Id", "ToSelectList");
            ViewData["TeacherId"] = new SelectList(_context.Teachers.Where(x => x.Relevance), "Id", "ToSelectList");
            return View();
        }

        // POST: Exams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,DataExam,DisciplineName,Score,StudentId,TeacherId,Relevance")] Exams exams)
        {
            if (ModelState.IsValid)
            {
                _context.Add(exams);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["StudentId"] = new SelectList(_context.Students.Where(x=>x.Relevance), "Id", "ToSelectList", exams.StudentId);
            ViewData["TeacherId"] = new SelectList(_context.Teachers.Where(x => x.Relevance), "Id", "ToSelectList", exams.TeacherId);
            return View(exams);
        }

        // GET: Exams/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var exams = await _context.Exams.FindAsync(id);
            if (exams == null)
            {
                return NotFound();
            }
            ViewData["StudentId"] = new SelectList(_context.Students.Where(x=>x.Relevance), "Id", "ToSelectList", exams.StudentId);
            ViewData["TeacherId"] = new SelectList(_context.Teachers.Where(x => x.Relevance), "Id", "ToSelectList", exams.TeacherId);
            return View(exams);
        }

        // POST: Exams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,DataExam,DisciplineName,Score,StudentId,TeacherId,Relevance")] Exams exams)
        {
            if (id != exams.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(exams);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ExamsExists(exams.Id))
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
            ViewData["StudentId"] = new SelectList(_context.Students.Where(x=>x.Relevance), "Id", "ToSelectList", exams.StudentId);
            ViewData["TeacherId"] = new SelectList(_context.Teachers.Where(x => x.Relevance), "Id", "ToSelectList", exams.TeacherId);
            return View(exams);
        }

        private bool ExamsExists(int id)
        {
            return _context.Exams.Any(e => e.Id == id);
        }
    }
}
