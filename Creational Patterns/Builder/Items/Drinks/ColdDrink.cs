using builder.Interfaces;
using builder.Packs;

namespace builder.Items
{
    public abstract class ColdDrink : Item
    {
        public override Packing Packing()
        {
            return new Bottle();
        }

        public override abstract float Price();
    }
}