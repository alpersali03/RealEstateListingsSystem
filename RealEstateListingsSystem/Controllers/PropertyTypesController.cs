using Microsoft.AspNetCore.Mvc;
using RealEstateListingsSystem.Data;

namespace RealEstateListingsSystem.Controllers
{
	public class PropertyTypesController : Controller
	{
		private readonly RealEstateDbContext _context;
		public PropertyTypesController(RealEstateDbContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			var propertyTypes = _context.PropertyTypes.ToList();	
			return View(propertyTypes);
		}
	}
}
