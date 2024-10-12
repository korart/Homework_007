namespace Homework_007.Domain
{
    public abstract class Pizza
    {
        public Pizza(string n)
        {
            Name = n;
        }
        public string Name { get; protected set; }

        public string Base { get; set; } = "не выбрано";
        public abstract int GetCost();
    }
}
