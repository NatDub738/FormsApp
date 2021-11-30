using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
	class Lenta : Supermarket
	{
		private int _NumberOfProduct;

		public Lenta() { }
		public Lenta(string ST, string SA, string M, string CR, int NP)
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
			int quantity;
			string nameOfProduct;
			bool flag = false;
			int checkOffer = 1;

			while (checkOffer == 1)
			{
				Console.WriteLine("Здравствуйте! Сейчас мы представим список товаров.");
				for (int i = 0; i < _NumberOfProduct; i++)
				{
					Console.WriteLine("{0} - {1} штук", ProductName[i], ProductCount[i]);
				}

				Console.WriteLine("Для совершения покупки введите наименование продукта:");
				nameOfProduct = Convert.ToString(Console.ReadLine());
				Console.WriteLine("Введите количество:");
				quantity = Convert.ToInt32(Console.ReadLine());

				for (int i = 0; i < _NumberOfProduct && flag != true; i++)
				{
					if (nameOfProduct == ProductName[i])
					{
						if (ProductCount[i] - quantity < 0)
						{
							throw new Exception("К сожалению, у нас нет такого количества товара.");
						}
						else
						{
							ProductCount[i] -= quantity;
							flag = true;
							Console.WriteLine("Спасибо за покупку! Ждём вас снова");
						}
					}
				}

				if (flag == false)
				{
					throw new Exception("Товара с таким наименованием нет.");
				}

				AddProduct();

				flag = false;

				Console.WriteLine("Введите '1' для продолжения покупок, в противном случае введите 0 для выхода из супермаркета {0}:",
					SupermarketTitle);
				checkOffer = Convert.ToInt32(Console.ReadLine());

				if (checkOffer != 1 && checkOffer != 0)
				{
					throw new Exception("Ошибка! Введено некорректное значение.");
				}
			}
		}

		override public void AddProduct()
		{
			int MAX = 50;
			int MIN = MAX / 2;
			int add;

			for (int i = 0; i < _NumberOfProduct; i++)
			{
				if (ProductCount[i] <= MIN)
				{
					add = MAX - ProductCount[i];
					ProductCount[i] += add;
					Console.WriteLine("Менеджер пополнил запасы товара {0} на {1} штук", ProductName[i], add);
				}
			}
		}
	}
}
