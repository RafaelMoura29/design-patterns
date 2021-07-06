using System;
using Strategy.Behaviors.Jump;
using Strategy.Behaviors.Kick;

namespace Strategy.Fighters
{
    public abstract class Fighter
    {
        KickBehavior _kickBehavior;
        JumpBehavior _jumpBehavior;

        public Fighter(KickBehavior kickBehavior, JumpBehavior jumpBehavior)
        {
            _kickBehavior = kickBehavior;
            _jumpBehavior = jumpBehavior;
        }

        public void punch()
        {
            Console.WriteLine("Default punch");
        }

        public void kick()
        {
            // delegate to kick behavior
            _kickBehavior.Kick();
        }
        public void jump()
        {

            // delegate to jump behavior
            _jumpBehavior.Jump();
        }
        public void roll()
        {
            Console.WriteLine("Default Roll");
        }
        public void setKickBehavior(KickBehavior kickBehavior)
        {
            _kickBehavior = kickBehavior;
        }
        public void setJumpBehavior(JumpBehavior jumpBehavior)
        {
            _jumpBehavior = jumpBehavior;
        }
        public abstract void display();
    }
}