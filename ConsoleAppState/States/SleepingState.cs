using System;

namespace ConsoleAppState.States
{
    public class SleepingState : AbstractCatState
    {
        public SleepingState(CatContext Handle) : base(Handle)
        {}

        public override void GetsFed(int amount, int HappyWith)
        {
            Console.WriteLine("Hmm lekker!");
            this.Handle.CurrentState = new EatingState(this.Handle, amount, HappyWith);
        }
    }
}
