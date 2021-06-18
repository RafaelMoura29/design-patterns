namespace builder.Items
{
    public class VegBurger : Burguer
    {
        public override float Price()
        {
            return 25.0f;
        }

        public override string Name()
        {
            return "Veg Burger";
        }
    }
}