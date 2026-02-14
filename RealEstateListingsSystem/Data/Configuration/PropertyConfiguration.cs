using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateListingsSystem.Models;

namespace RealEstateListingsSystem.Data.Configuration
{
	public class PropertyConfiguration : IEntityTypeConfiguration<Property>
	{
		private readonly IEnumerable<Property> properties = new List<Property>
		{
			new Property
			{
				Id = 1,
				Title = "Modern Two-Bedroom Apartment",
				Description = "A beautiful modern apartment located in the city center with excellent infrastructure nearby.",
				Price = 125000,
				Size = 85,
				Address = "15 Vitosha Blvd, Sofia",
				PropertyTypeId = 1,
				AgentId = 1
			},
			new Property
			{
				Id = 2,
				Title = "Luxury Family House with Garden",
				Description = "Spacious family house with private garden and garage, located in a quiet residential area.",
				Price = 350000,
				Size = 240,
				Address = "22 Rose Street, Plovdiv",
				PropertyTypeId = 2,
				AgentId = 2
			},
			new Property
			{
				Id = 3,
				Title = "Cozy Studio Near University",
				Description = "Compact and practical studio apartment suitable for students or investment purposes.",
				Price = 75000,
				Size = 40,
				Address = "8 Studentski Grad, Sofia",
				PropertyTypeId = 1,
				AgentId = 1
			}
		};

		public void Configure(EntityTypeBuilder<Property> builder)
		{
			builder.HasData(properties);
		}
	}
}
