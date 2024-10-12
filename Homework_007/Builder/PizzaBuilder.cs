using Homework_007.Domain;

namespace Homework_007.Builder
{
	public class PizzaBuilder
	{
		private Pizza pizza;

        public PizzaBuilder(Pizza p)
        {
            pizza = p;
        }

        public void SetThinBase()
        {
            pizza.Base = "тонкое тесто";
        }

		public void SetUsualBase()
		{
			pizza.Base = "обычное тесто";
		}

		public Pizza Create()
		{
			return pizza;
		}
	}
}
