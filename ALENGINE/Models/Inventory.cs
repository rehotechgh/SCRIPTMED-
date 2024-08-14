using System;
namespace ALENGINE.Models
{
	public class Inventory
	{
		public int Id { get; set; }
		public string? ItemName { get; set; }
		public string? ManufacturingDate { get; set; }
		public string? ExpiryDate { get; set; }
		public string? Manufacturer { get; set; }
		public int Quantity { get; set; }
		public double  CostPrice { get; set; }
		public double SalesPrice { get; set; }
		public double ExpectedSales { get; set; }
		public double ProfitMargin { get; set; }
		public int SalesQuantity { get; set; }
        public double SalesAmount { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now.Date;







	}
}

