using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RealEstateListingsSystem.Data;
using RealEstateListingsSystem.Models;

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
		[HttpGet]
		public IActionResult Create()
		{
			ViewBag.PropertyTypes = new SelectList(_context.PropertyTypes, "Id", "Name");
			ViewBag.Agents = new SelectList(_context.Agents, "Id", "FullName");

			return View();
		}

		[HttpPost]
		public IActionResult Create(Property property)
		{
			if (!ModelState.IsValid)
			{
				ViewBag.PropertyTypes = new SelectList(_context.PropertyTypes, "Id", "Name");
				ViewBag.Agents = new SelectList(_context.Agents, "Id", "FullName");

				return View(property);
			}

			_context.Properties.Add(property);
			_context.SaveChanges();

			return RedirectToAction(nameof(Index));
		}

	}
}
