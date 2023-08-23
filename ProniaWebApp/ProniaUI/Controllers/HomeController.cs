using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pronia.DataAcces.Contexts;
using ProniaUI.ViewModels;

namespace ProniaUI.Controllers
{
    public class HomeController : Controller
    {
        public readonly AppDBContext _context;

        public HomeController(AppDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            HomeViewModel vm = new() {
                sliders = await _context.Sliders.ToListAsync(),
                services = await _context.Services.ToListAsync()
            };
            return View(vm);
        }
    }
}
