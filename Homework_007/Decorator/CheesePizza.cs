using Homework_007.Domain;

namespace Homework_007.Decorator
{
    public class CheesePizza : PizzaDecorator
	{
		public CheesePizza(Pizza p)
			: base(p.Name + ", с сыром", p)
		{ }

		public override int GetCost()
		{
			return pizza.GetCost() + 70;
		}
	}
}
