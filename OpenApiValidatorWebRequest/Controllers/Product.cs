using System.Collections.Generic;

namespace OpenApiValidatorWebRequest.Controllers
{
	public class Dimensions
	{
		public double Length { get; set; }
		public double Width { get; set; }
		public double Height { get; set; }
	}

	public class Product
	{
		public int productId { get; set; }
		public string productName { get; set; }
		public double price { get; set; }
		public List<string> tags { get; set; }
		public Dimensions dimensions { get; set; }
	}
}
