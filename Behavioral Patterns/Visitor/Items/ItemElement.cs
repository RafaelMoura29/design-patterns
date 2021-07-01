namespace Visitor
{
    public abstract class ItemElement
    {
        public abstract int Accept(ShoppingCartVisitor visitor);
    }
}