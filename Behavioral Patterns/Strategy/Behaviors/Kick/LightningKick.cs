using System;

namespace Strategy.Behaviors.Kick
{
    public class LightningKick : KickBehavior
    {
        public void Kick()
        {
            Console.WriteLine("Lightning Kick");
        }
    }
}