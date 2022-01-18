namespace TTask.Library
{
    public class Cell
    {
        public Cell(double price, double amount = 0)
        {
            Price = price;
            Amount = amount;
        }

        public double Price { get; }

        public double Amount { get; }

        public override string ToString()
        {
            return Amount == 0 ? $"{Price,-10}" : $"{Price,-5}/{Amount,4}";
        }
    }
}
