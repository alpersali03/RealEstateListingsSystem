using System.Reflection;

namespace RealEstateListingsSystem.Common
{
	public class ValidationConstants
	{
		public class Property 
		{

			public const int TitleMinLength = 5;
			public const int TitleMaxLength = 100;
			public const int DescriptionMinLength = 10;
			public const int DescriptionMaxLength = 1000;
			public const int PriceMinValue = 1000;
			public const int PriceMaxValue = 10000000;
			public const int SizeMinValue = 10;
			public const int SizeMaxValue = 10000;
			public const int AddressMinLength = 10;
			public const int AddressMaxLength = 200;

		}
		public class Agent 
		{ 
			public const int FullNameMinLength = 5;
			public const int FullNameMaxLength = 100;
			public const int PhoneNumberMinLength = 10;
			public const int PhoneNumberMaxLength = 15;
			public const int EmailMinLength = 5;
			public const int EmailMaxLength = 100;
		}
		public class PropertyType 
		{ 
			public const int NameMinLength = 3;
			public const int NameMaxLength = 50;
		}


	}
}
