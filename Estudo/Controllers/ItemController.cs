using System.Threading.Tasks;
using Estudo.Data;
using Estudo.Models;
using Microsoft.AspNetCore.Mvc;

namespace Estudo.Controllers
{
    public class ItemController : Controller
    {
        private readonly BaseContext _context;

        public ItemController(BaseContext context) {
            this._context = context;
        }

        public async Task<IActionResult> Index() {
            return View(await _context.Itens.FindAsync());
        }

        public IActionResult Create() {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Item item) {
            if (ModelState.IsValid) {
                this._context.Add(item);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return BadRequest(item);
        }

        public async Task<IActionResult> Details(int? id) {
            if (id == null) {
                return BadRequest();
            }

            return NotFound();
            // Item item = await this._context.Itens

        }
    }
}