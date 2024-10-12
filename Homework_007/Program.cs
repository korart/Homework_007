using Homework_007.Builder;
using Homework_007.Decorator;
using Homework_007.Domain;
using Homework_007.FactoryMethod;
using System.Text;

namespace Homework_007
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int userChoice = -1;
			bool repeat = true;
			Pizza pizza;

			Console.OutputEncoding = Encoding.UTF8;

			#region FactoryMethod
			while (repeat)
			{
				try
				{
					Console.WriteLine("ЗАКАЗ ПИЦЦЫ");
					Console.WriteLine("----------------------------");
					Console.WriteLine("1. Итальянская пицца");
					Console.WriteLine("2. Болгарская пицца");
					Console.WriteLine("0. Выход");
					Console.WriteLine("----------------------------");
					Console.Write("Выберите вариант из меню: ");
					userChoice = Convert.ToInt32(Console.ReadLine());
					if (userChoice < 0 || userChoice > 2)
					{
						throw new ArgumentException("Введенное значение должно быть равно 0, 1 или 2");
					}
					repeat = false;
				}
				catch (FormatException)
				{
					Console.WriteLine("Введенное значение должно быть равно 0, 1 или 2");
					Console.WriteLine();
				}
				catch (ArgumentException)
				{
					Console.WriteLine("Введенное значение должно быть равно 0, 1 или 2");
					Console.WriteLine();
				}
			}

			switch (userChoice)
			{
				case 1:
					pizza = new ItalianPizzaCreator().Create();
					repeat = true;
					userChoice = -1;
					PizzaInfo(pizza);
					break;
				case 2:
					pizza = new BulgerianPizzaCreator().Create();
					repeat = true;
					userChoice = -1;
					PizzaInfo(pizza);
					break;
				default: return;
			}
			#endregion

			#region Builder
			while (repeat)
			{
				try
				{
					Console.WriteLine();
					Console.WriteLine("ОСНОВА:");
					Console.WriteLine("----------------------------");
					Console.WriteLine("1. Тонкое тесто");
					Console.WriteLine("2. Обычное тесто");
					Console.WriteLine("----------------------------");
					Console.Write("Выберите вариант: ");
					userChoice = Convert.ToInt32(Console.ReadLine());
					if (userChoice < 1 || userChoice > 2)
					{
						throw new ArgumentException("Введенное значение должно быть равно 1 или 2");
					}
				}
				catch (FormatException)
				{
					Console.WriteLine("Введенное значение должно быть равно 1 или 2");
					Console.WriteLine();
				}
				catch (ArgumentException)
				{
					Console.WriteLine("Введенное значение должно быть равно 1 или 2");
					Console.WriteLine();
				}

				PizzaBuilder builder = new PizzaBuilder(pizza);

				switch (userChoice)
				{
					case 1:
						builder.SetThinBase();
						pizza = builder.Create();
						userChoice = -1;
						repeat = false;
						PizzaInfo(pizza);
						break;
					case 2:
						builder.SetUsualBase();
						pizza = builder.Create();
						userChoice = -1;
						repeat = false;
						PizzaInfo(pizza);
						break;
				}
			}
			repeat = true;
			#endregion

			#region Decorator
			while (repeat)
			{
				try
				{
					Console.WriteLine();
					Console.WriteLine("ДОБАВКИ:");
					Console.WriteLine("----------------------------");
					Console.WriteLine("1. Сыр");
					Console.WriteLine("2. Томаты");
					Console.WriteLine("0. Выход");
					Console.WriteLine("----------------------------");
					Console.Write("Выберите вариант: ");
					userChoice = Convert.ToInt32(Console.ReadLine());
					if (userChoice < 0 || userChoice > 2)
					{
						throw new ArgumentException("Введенное значение должно быть равно 0, 1 или 2");
					}
				}
				catch (FormatException)
				{
					Console.WriteLine("Введенное значение должно быть равно 0, 1 или 2");
					Console.WriteLine();
				}
				catch (ArgumentException)
				{
					Console.WriteLine("Введенное значение должно быть равно 0, 1 или 2");
					Console.WriteLine();
				}

				switch (userChoice)
				{
					case 1:
						pizza = new CheesePizza(pizza);
						PizzaInfo(pizza);
						break;
					case 2:
						pizza = new TomatoPizza(pizza);
						PizzaInfo(pizza);
						break;
					case 0:
						repeat = false; break;
				}
			}
			#endregion

			PizzaInfo(pizza);
		}

		static void PizzaInfo(Pizza pizza)
		{
			Console.WriteLine();
			Console.WriteLine("{0} (основа: {1}). Стоимость - {2:C}", pizza.Name, pizza.Base, pizza.GetCost());
		}
	}
}
