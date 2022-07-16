using eTikects.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace eTikects.Controllers
{
    public class CinamasController : Controller
    {

        private readonly AppDbContext _context;

        public CinamasController(AppDbContext context)
        {
            _context = context;
        }
     
        public async Task<IActionResult> Index()
        {
            var allCinema = await _context.Cinemas.ToListAsync();

            return View();
        }
    }
}
