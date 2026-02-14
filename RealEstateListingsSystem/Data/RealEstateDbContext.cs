using Microsoft.EntityFrameworkCore;
using RealEstateListingsSystem.Data.Configuration;
using RealEstateListingsSystem.Models;

namespace RealEstateListingsSystem.Data
{
	public class RealEstateDbContext : DbContext
	{
		public RealEstateDbContext(DbContextOptions<RealEstateDbContext> options)
			: base(options)
		{
		}

		public DbSet<Property> Properties { get; set; }
		public DbSet<Agent> Agents { get; set; }
		public DbSet<PropertyType> PropertyTypes { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new AgentConfiguration());
			modelBuilder.ApplyConfiguration(new PropertyTypeConfiguration());
			modelBuilder.ApplyConfiguration(new PropertyConfiguration());

			base.OnModelCreating(modelBuilder);
		}
	}
}
