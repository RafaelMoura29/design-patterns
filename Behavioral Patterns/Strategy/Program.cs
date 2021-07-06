using System;
using Strategy.Behaviors.Jump;
using Strategy.Behaviors.Kick;
using Strategy.Fighters;

namespace Strategy
{
    class Program
    { 
        static void Main(string[] args)
        {
            JumpBehavior shortJump = new ShortJump();
            JumpBehavior LongJump = new LongJump();
            KickBehavior tornadoKick = new TornadoKick();

            Fighter ken = new Ken(tornadoKick, shortJump);
            ken.display();

            ken.punch();
            ken.kick();
            ken.jump();

            ken.setJumpBehavior(LongJump);
            ken.jump();
        }
    }
}
