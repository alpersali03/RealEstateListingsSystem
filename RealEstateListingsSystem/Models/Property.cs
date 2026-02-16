
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using RealEstateListingsSystem.Common;
using System.ComponentModel.DataAnnotations;

namespace RealEstateListingsSystem.Models
{
	public class Property
	{
		[Key]
		public int Id { get; set; }

		[Required]
		[StringLength(
			ValidationConstants.Property.TitleMaxLength,
			MinimumLength = ValidationConstants.Property.TitleMinLength)]
		public string Title { get; set; }

		[Required]
		[StringLength(
			ValidationConstants.Property.DescriptionMaxLength,
			MinimumLength = ValidationConstants.Property.DescriptionMinLength)]
		public string Description { get; set; }

		[Required]
		[Range(ValidationConstants.Property.PriceMinValue,
	   ValidationConstants.Property.PriceMaxValue)]

		public decimal Price { get; set; }

		[Required]
		[StringLength(
			ValidationConstants.Property.AddressMaxLength,
			MinimumLength = ValidationConstants.Property.AddressMinLength)]
		public string Address { get; set; }

		[Required]
		[Range(ValidationConstants.Property.SizeMinValue,
	   ValidationConstants.Property.SizeMaxValue)]
		public int Size { get; set; }

		[Required]
		public int PropertyTypeId { get; set; }
		[ValidateNever]
		public PropertyType PropertyType { get; set; }

		[Required]
		public int AgentId { get; set; }
		[ValidateNever]
		public Agent Agent { get; set; }
	}
}