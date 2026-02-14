using RealEstateListingsSystem.Common;
using System.ComponentModel.DataAnnotations;

namespace RealEstateListingsSystem.Models
{
	public class PropertyType
	{
		[Key]	
		public int Id { get; set; }
		[Required]
		[StringLength(ValidationConstants.PropertyType.NameMaxLength, MinimumLength = ValidationConstants.PropertyType.NameMinLength)]
		public string Name { get; set; }
		public ICollection<Property> Properties { get; set; }
	}
}
