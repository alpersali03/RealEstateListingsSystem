using RealEstateListingsSystem.Common;
using System.ComponentModel.DataAnnotations;

namespace RealEstateListingsSystem.Models
{
	public class Agent
	{
		[Key]
		public int Id { get; set; }
		[Required]
		[StringLength(ValidationConstants.Agent.FullNameMaxLength, MinimumLength = ValidationConstants.Agent.FullNameMinLength)]
		public string FullName { get; set; }
		[Required]
		[StringLength(ValidationConstants.Agent.PhoneNumberMaxLength, MinimumLength = ValidationConstants.Agent.PhoneNumberMinLength)]
		public string PhoneNumber { get; set; }
		[Required]
		[StringLength(ValidationConstants.Agent.EmailMaxLength, MinimumLength = ValidationConstants.Agent.EmailMinLength)]
		public string Email { get; set; }
		public ICollection<Property> Properties { get; set; }
	}
}
