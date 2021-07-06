using System;
using Strategy.Behaviors.Jump;
using Strategy.Behaviors.Kick;

namespace Strategy.Fighters
{
    public class ChunLi : Fighter
    {
        public ChunLi(KickBehavior kickBehavior, JumpBehavior jumpBehavior) : base(kickBehavior, jumpBehavior)
        {
        }

        public override void display()
        {
            Console.WriteLine("ChunLi");
        }
    }
}