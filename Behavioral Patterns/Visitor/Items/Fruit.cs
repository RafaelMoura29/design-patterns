namespace Visitor
{
    public class Fruit : ItemElement
    {
        public int PricePerKg { get; private set; }
        public int Weight { get; private set; }
        public string Name { get; private set; }
        public Fruit(int priceKg, int wt, string nm)
        {
            this.PricePerKg = priceKg;
            this.Weight = wt;
            this.Name = nm;
        }
        public override int Accept(ShoppingCartVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}