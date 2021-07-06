using System;

namespace Strategy.Behaviors.Jump
{
    public class ShortJump : JumpBehavior
    {
        public void Jump()
        {
            Console.WriteLine("Short Jump");
        }
    }
}