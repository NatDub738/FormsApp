using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	public class DatabaseOfSupermarket
	{
		private int _supermarketCount;
		private Supermarket[] spmk;

		public DatabaseOfSupermarket(int supermarketCount)
		{
			_supermarketCount = supermarketCount;
			spmk = new Supermarket[_supermarketCount];
			string sTitle, sAddress, mgr, cr;
			int numProduct;

			sTitle = Convert.ToString(Console.ReadLine());
			sAddress = Convert.ToString(Console.ReadLine());
			mgr = Convert.ToString(Console.ReadLine());
			cr = Convert.ToString(Console.ReadLine());
			numProduct = Convert.ToInt32(Console.ReadLine());
			spmk[0] = new Lenta(sTitle, sAddress, mgr, cr, numProduct);

			try
			{
				spmk[0].SetProducts();
				Console.WriteLine(spmk[0]);
				spmk[0].BuyProduct();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}

			sTitle = Convert.ToString(Console.ReadLine());
			sAddress = Convert.ToString(Console.ReadLine());
			mgr = Convert.ToString(Console.ReadLine());
			cr = Convert.ToString(Console.ReadLine());
			numProduct = Convert.ToInt32(Console.ReadLine());
			spmk[1] = new Faberlic(sTitle, sAddress, mgr, cr, numProduct);

			try
			{
				spmk[1].SetProducts();
				Console.WriteLine(spmk[1]);
				spmk[1].BuyProduct();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}
	}
}
