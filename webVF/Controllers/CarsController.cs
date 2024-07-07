using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webVF.DataBase;


public class CarsController : Controller
{
    /*
    private readonly VinFastDbContext _context;

    public CarsController(VinFastDbContext context)
    {
        _context = context;
    }
    */
    public IActionResult Cars()
    {
        return View();
    }


    // GET: Cars
    /*
    public async Task<IActionResult> Cars()
    {
        return View(await _context.Cars.ToListAsync());
    }

    // GET: Cars/Details/5
    public async Task<IActionResult> Details(int? id)
    {
        if (id == null)
        {
            return NotFound();
        }

        var car = await _context.Cars
            .FirstOrDefaultAsync(m => m.CarID == id);
        if (car == null)
        {
            return NotFound();
        }

        return View(car);
    }

    // GET: Cars/Create
    public IActionResult Create()
    {
        return View();
    }

    // POST: Cars/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("CarID,CarName,Price,Description,ImageUrl")] Car car)
    {
        if (ModelState.IsValid)
        {
            _context.Add(car);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(car);
    }
    */
}
