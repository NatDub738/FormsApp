using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	abstract class Supermarket
	{
		public string SupermarketTitle { get; set; }
		public string SupermarketAddress { get; set; }
		public string Manager { get; set; }
		public string Cashier { get; set; }
		public string[] ProductName { get; set; }
		public int[] ProductCount { get; set; }

		public Supermarket() { }
		public Supermarket(string ST, string SA, string M, string CR)
		{
			SupermarketTitle = ST;
			SupermarketAddress = SA;
			Manager = M;
			Cashier = CR;
		}

		abstract public void SetProducts();
		abstract public void BuyProduct();
		abstract public void AddProduct();
	}
}
