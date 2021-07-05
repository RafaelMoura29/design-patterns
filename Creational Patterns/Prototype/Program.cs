using System;
using prototype.Prototypes;

namespace prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant elephant = new Elephant();
            elephant.Health = 100;
            elephant.Attack = 10;
            elephant.Damage = 5.0;
            elephant.EnemeyTrait.BoostTime = 7;
            elephant.EnemeyTrait.BoostDamage = 7;

            Elephant playerToSave = elephant.Clone() as Elephant;
            playerToSave.EnemeyTrait.BoostTime = 10;
            playerToSave.EnemeyTrait.BoostDamage = 10;

            Console.WriteLine("Original Enemy stats:");
            Console.WriteLine("BoostTime: {0}, BoostDamage: {1}",
                elephant.EnemeyTrait.BoostTime.ToString(),
                elephant.EnemeyTrait.BoostDamage.ToString());

            Console.WriteLine("Copied Object Value:");
            Console.WriteLine("BoostTime: {0}, BoostDamage: {1}",
                playerToSave.EnemeyTrait.BoostTime.ToString(),
                playerToSave.EnemeyTrait.BoostDamage.ToString());
        }
    }
}
