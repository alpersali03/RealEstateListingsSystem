using Microsoft.AspNetCore.Mvc;
using RealEstateListingsSystem.Data;

namespace RealEstateListingsSystem.Controllers
{
	public class AgentsController : Controller
	{
		private readonly RealEstateDbContext _context;
		public AgentsController(RealEstateDbContext context)
		{
			_context = context;
		}
		public IActionResult Index()
		{
			var agents = _context.Agents.ToList();

			return View(agents);
		}
		public IActionResult Details(int id)
		{
			var agent = _context.Agents.FirstOrDefault(a => a.Id == id);
			if (agent == null)
			{
				return NotFound();
			}
			return View(agent);
		}
	}
}
