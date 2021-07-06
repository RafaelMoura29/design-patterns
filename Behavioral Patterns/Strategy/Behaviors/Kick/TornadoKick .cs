using System;

namespace Strategy.Behaviors.Kick
{
    public class TornadoKick : KickBehavior
    {
        public void Kick()
        {
            Console.WriteLine("Tornado Kick");
        }
    }
}