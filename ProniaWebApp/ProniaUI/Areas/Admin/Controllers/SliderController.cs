using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pronia.Core.Entities;
using Pronia.DataAcces.Contexts;

namespace ProniaUI.Areas.Admin.Controllers
{
    [Area("Admin")]

    public class SliderController : Controller
    {
        private readonly AppDBContext _context;

        public SliderController(AppDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Sliders.AsNoTracking());
        }
        public async Task<IActionResult> Details(int id)
        {
            Slider? slider = await _context.Sliders.FindAsync(id);
            if (slider == null) return NotFound();
            return View(slider);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SliderPostVM slider)
        {
            if (!ModelState.IsValid) return View(slider);
            // Slider newslider = _mapper.Map<Slider>(slider) 
            //await _context.Sliders.AddAsync(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
