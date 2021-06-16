namespace prototype.Prototypes
{
    public class Elephant : Enemy
    {
        private Enemy ShallowCopy()
        {
            return this.MemberwiseClone() as Enemy;
        }

        private Enemy DeepCopy()
        {
            Enemy cloned = this.MemberwiseClone() as Enemy;
            cloned.EnemeyTrait = new EnemeyTrait();
            cloned.EnemeyTrait.BoostDamage = this.EnemeyTrait.BoostDamage;
            cloned.EnemeyTrait.BoostTime = this.EnemeyTrait.BoostTime;

            return cloned;
        }

        public override Enemy Clone()
        {
            //return ShallowCopy();
            return DeepCopy();
        }
    }
}