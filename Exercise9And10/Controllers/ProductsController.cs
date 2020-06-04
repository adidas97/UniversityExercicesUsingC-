using System.Threading.Tasks;
using Lab9.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace Lab9.Controllers
{
    public class ProductsController : Controller
    {
        private readonly DatabaseContext _context;

        public ProductsController(DatabaseContext context)
        {
            _context = context;
        }
        // GET: Products
        public async Task<IActionResult> Index()
        {
            ViewBag.Title = "Beauty Shop";
            var products = await _context.Products
            .Include(p => p.CategoryDB)
            .ToListAsync();
            return View(products.OrderByDescending(x => x.CategoryID));
        }

        // GET: Products/Details/5
        public async Task<IActionResult> Details(int? productID)
        {
            ViewBag.Title = "Details";
            if (productID == null)
            {
                return NotFound();
            }
            var product = await _context.Products
            .Include(p => p.CategoryDB)
            .AsNoTracking()
            .FirstOrDefaultAsync(m => m.ProductID == productID);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }

        // GET: Products/Create
        public IActionResult Create()
        {
            ViewBag.Title = "Create Product";
            ViewData["CategoryID"] = new SelectList(_context.Categories,
            "CategoryID", "CategoryName");
            return View();
        }
        // POST: Products/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> Create([Bind(
 "ProductID,ProductName,Description,ImagePath,UnitPrice,CategoryID")]
 ProductDB product)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Add(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateException)
                {
                    ModelState.AddModelError("",
                    "Unable to save changes. Duplicated key. Try again.");
                    ViewData["CategoryID"] = new SelectList(
                    _context.Categories,
                    "CategoryID", "CategoryName", product.CategoryID);
                    return View(product);
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryID"] = new SelectList(_context.Categories,
            "CategoryID", "CategoryName", product.CategoryID);
            return View(product);
        }

    }
}
