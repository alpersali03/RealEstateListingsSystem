using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RealEstateListingsSystem.Models;

namespace RealEstateListingsSystem.Data.Configuration
{
	public class PropertyTypeConfiguration : IEntityTypeConfiguration<PropertyType>
	{
		private readonly IEnumerable<PropertyType> propertyTypes = new List<PropertyType>
		{
			new PropertyType
			{
				Id = 1,
				Name = "Apartment"
			},
			new PropertyType
			{
				Id = 2,
				Name = "House"
			},
			new PropertyType
			{
				Id = 3,
				Name = "Studio"
			}
		};

		public void Configure(EntityTypeBuilder<PropertyType> builder)
		{
			builder.HasData(propertyTypes);
		}
	}
}
