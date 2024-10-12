using Homework_007.Domain;

namespace Homework_007.Decorator
{
    public class TomatoPizza : PizzaDecorator
	{
		public TomatoPizza(Pizza p)
			: base(p.Name + ", с томатами", p)
		{ }

		public override int GetCost()
		{
			return pizza.GetCost() + 55;
		}
	}
}
