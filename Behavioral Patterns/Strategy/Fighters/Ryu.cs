using System;
using Strategy.Behaviors.Jump;
using Strategy.Behaviors.Kick;

namespace Strategy.Fighters
{
    public class Ryu : Fighter
    {
        public Ryu(KickBehavior kickBehavior, JumpBehavior jumpBehavior) : base(kickBehavior, jumpBehavior)
        {
        }

        public override void display()
        {
            Console.WriteLine("Ryu");
        }
    }
}