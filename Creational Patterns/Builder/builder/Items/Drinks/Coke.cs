namespace builder.Items
{
    public class Coke : ColdDrink
    {
        public override float Price()
        {
            return 30.0f;
        }

        public override string Name()
        {
            return "Coke";
        }
    }
}