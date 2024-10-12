using Homework_007.Domain;

namespace Homework_007.FactoryMethod
{
	internal class BulgerianPizzaCreator : PizzaCreator
	{
		public override Pizza Create()
		{
			return new BulgerianPizza();
		}
	}
}
