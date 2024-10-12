using Homework_007.Domain;

namespace Homework_007.FactoryMethod
{
	public class ItalianPizzaCreator : PizzaCreator
	{
		public override Pizza Create()
		{
			return new ItalianPizza();
		}
	}
}
