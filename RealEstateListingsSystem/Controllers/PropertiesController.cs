using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RealEstateListingsSystem.Data;

namespace RealEstateListingsSystem.Controllers
{
	public class PropertiesController : Controller
	{
		private readonly RealEstateDbContext _context;
		public PropertiesController(RealEstateDbContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			var properties = _context.Properties.Include(p=>p.Agent).Include(p=>p.PropertyType).ToList();
			return View(properties);
		}

		public IActionResult Details(int id)
		{
			var property = _context.Properties.Include(p => p.Agent).Include(p => p.PropertyType).FirstOrDefault(p => p.Id == id);
			if (property == null)
			{
				return NotFound();
			}
			return View(property);
		}
	}
}
