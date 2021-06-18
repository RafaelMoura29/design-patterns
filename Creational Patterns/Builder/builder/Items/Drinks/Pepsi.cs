namespace builder.Items
{
    public class Pepsi : ColdDrink
    {
        public override float Price()
        {
            return 35.0f;
        }

        public override string Name()
        {
            return "Pepsi";
        }
    }
}