using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ToyApp.Models;

namespace ToyApp.Controllers
{
    public class MicroPostsController : Controller
    {
        private readonly ToyContext _context;

        public MicroPostsController(ToyContext context)
        {
            _context = context;
        }

        // GET: MicroPosts
        public async Task<IActionResult> Index()
        {
            return View(await _context.MicroPost.ToListAsync());
        }

        // GET: MicroPosts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var microPost = await _context.MicroPost
                .FirstOrDefaultAsync(m => m.ID == id);
            if (microPost == null)
            {
                return NotFound();
            }

            return View(microPost);
        }

        // GET: MicroPosts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: MicroPosts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Content,UserID")] MicroPost microPost)
        {
            if (ModelState.IsValid)
            {
                _context.Add(microPost);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(microPost);
        }

        // GET: MicroPosts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var microPost = await _context.MicroPost.FindAsync(id);
            if (microPost == null)
            {
                return NotFound();
            }
            return View(microPost);
        }

        // POST: MicroPosts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Content,UserID")] MicroPost microPost)
        {
            if (id != microPost.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(microPost);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MicroPostExists(microPost.ID))
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
            return View(microPost);
        }

        // GET: MicroPosts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var microPost = await _context.MicroPost
                .FirstOrDefaultAsync(m => m.ID == id);
            if (microPost == null)
            {
                return NotFound();
            }

            return View(microPost);
        }

        // POST: MicroPosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var microPost = await _context.MicroPost.FindAsync(id);
            _context.MicroPost.Remove(microPost);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MicroPostExists(int id)
        {
            return _context.MicroPost.Any(e => e.ID == id);
        }
    }
}
