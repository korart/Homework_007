namespace Homework_007.Domain
{
	public class BulgerianPizza : Pizza
	{
		public BulgerianPizza()
			: base("Болгарская пицца")
		{
		}

		public override int GetCost()
		{
			return 490;
		}
	}
}
