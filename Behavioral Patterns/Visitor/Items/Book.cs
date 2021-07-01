namespace Visitor
{
    public class Book : ItemElement
    {
        public int Price { get; private set; }
        public string IsBnNumber { get; private set; }

        public Book(int cost, string isbn)
        {
            this.Price = cost;
            this.IsBnNumber = isbn;
        }

        public override int Accept(ShoppingCartVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}