using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	class Faberlic : Supermarket
	{
		private int _NumberOfProduct;

		public Faberlic() { }
		public Faberlic(string ST, string SA, string M, string CR, int NP)
			: base(ST, SA, M, CR)
		{
			_NumberOfProduct = NP;
		}

		override public void SetProducts()
		{
			ProductName = new string[_NumberOfProduct];
			ProductCount = new int[_NumberOfProduct];
			for (int i = 0; i < _NumberOfProduct; i++)
			{
				ProductName[i] = Convert.ToString(Console.ReadLine());
				ProductCount[i] = Convert.ToInt32(Console.ReadLine());
			}
		}

		public override string ToString()
		{
			return "Название супермаркета:" + SupermarketTitle + "\n" +
				"Адрес супермаркета:" + SupermarketAddress + "\n" +
				"Менеджер:" + Manager + "\n" +
				"Кассир:" + Cashier + "\n";
		}

		override public void BuyProduct()
		{
			int checkOffer = 1;
			int col;
			int id;

			while (checkOffer == 1)
			{
				Console.WriteLine("Здравствуйте! Сейчас мы представим список продукции..");
				for (int i = 0; i < _NumberOfProduct; i++)
				{
					Console.WriteLine("id {0}: {1} {2} штук", i + 1, ProductName[i], ProductCount[i]);
				}

				Console.WriteLine("Для совершения покупки введите id продукта:");
				id = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Введите количество:");
				col = Convert.ToInt32(Console.ReadLine());

				if (id > _NumberOfProduct || id < 1)
				{
					throw new Exception("К сожалению, товара с таким id нет.");
				}

				if (ProductCount[id - 1] >= col)
				{
					ProductCount[id - 1] -= col;
					Console.WriteLine("Спасибо за покупку! Ждём вас снова.");
				}
				else
				{
					throw new Exception("К сожалению, у нас нет такого количества товара.");
				}

				AddProduct();

				Console.WriteLine("Введите '1' для продолжения покупок, в противном случае введите 0 для выхода из супермаркета {0}:", SupermarketTitle);
				checkOffer = Convert.ToInt32(Console.ReadLine());

				if (checkOffer != 1 && checkOffer != 0)
				{
					throw new Exception("Ошибка! Введено некорректное значение.");
				}

			}
		}

		override public void AddProduct()
		{
			int MAX = 30;
			int MIN = MAX / 3;
			int add;
			int a = -1;
			bool flag = false;

			for (int i = 0; i < _NumberOfProduct && flag == false; i++)
			{
				if (ProductCount[i] <= MIN)
				{
					a = i;
					flag = true;
				}
			}

			if (a != -1)
			{
				add = MAX - ProductCount[a];
				ProductCount[a] += add;
				Console.WriteLine("Менеджер пополнил запасы товара:{0} на {1} штук.", ProductName[a], add);
			}
		}
	}
}
