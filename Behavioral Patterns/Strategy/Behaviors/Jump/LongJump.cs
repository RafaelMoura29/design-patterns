using System;

namespace Strategy.Behaviors.Jump
{
    public class LongJump : JumpBehavior
    {
        public void Jump()
        {
            Console.WriteLine("Long Jump");
        }
    }
}