using builder.Interfaces;
using builder.Packs;

namespace builder.Items
{
    public abstract class Burguer : Item
    {
        public override Packing Packing()
        {
            return new Wrapper();
        }

        public abstract override float Price();
    }
}