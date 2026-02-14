using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateListingsSystem.Models;

namespace RealEstateListingsSystem.Data.Configuration
{
	public class AgentConfiguration : IEntityTypeConfiguration<Agent>
	{
		private readonly IEnumerable<Agent> agents = new List<Agent>
		{
			new Agent
			{
				Id = 1,
				FullName = "Ivan Petrov",
				PhoneNumber = "0888123456",
				Email = "ivan.petrov@realestate.bg"
			},
			new Agent
			{
				Id = 2,
				FullName = "Maria Georgieva",
				PhoneNumber = "0899123456",
				Email = "maria.georgieva@realestate.bg"
			}
		};

		public void Configure(EntityTypeBuilder<Agent> builder)
		{
			builder.HasData(agents);
		}
	}
}
