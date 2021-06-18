namespace builder.Items
{
    public class ChickenBurger : Burguer
    {
        public override float Price()
        {
            return 50.5f;
        }

        public override string Name()
        {
            return "Chicken Burger";
        }
    }
}