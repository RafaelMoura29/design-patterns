using System;
using Strategy.Behaviors.Jump;
using Strategy.Behaviors.Kick;

namespace Strategy.Fighters
{
    public class Ken : Fighter
    {
        public Ken(KickBehavior kickBehavior, JumpBehavior jumpBehavior) : base(kickBehavior, jumpBehavior)
        {
        }

        public override void display()
        {
            Console.WriteLine("Ken");
        }
    }
}