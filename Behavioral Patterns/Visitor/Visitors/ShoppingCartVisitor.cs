namespace Visitor
{
    public abstract class ShoppingCartVisitor
    {
        public abstract int Visit(Book book);
        public abstract int Visit(Fruit fruit);
    }
}