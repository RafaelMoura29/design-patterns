namespace builder.Interfaces
{
    public abstract class Item
    {
        public abstract string Name();
        public abstract Packing Packing();
        public abstract float Price();
    }
}