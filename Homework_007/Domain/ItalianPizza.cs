namespace Homework_007.Domain
{
	public class ItalianPizza : Pizza
	{
		public ItalianPizza() : base("Итальянская пицца")
		{ 
		}

		public override int GetCost()
		{
			return 555;
		}
	}
}
