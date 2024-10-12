using Homework_007.Domain;

namespace Homework_007.Decorator
{
    public abstract class PizzaDecorator : Pizza
	{
		protected Pizza pizza;
		public PizzaDecorator(string n, Pizza pizza) : base(n)
		{
			this.pizza = pizza;
			this.Base = pizza.Base;
		}
	}
}
