using System;

namespace ConsoleAppState.States
{
    public class ContemplatingState : AbstractCatState
    {
        public ContemplatingState(CatContext Handle) : base(Handle)
        {

        }
        public override void GetsFed(int amount, int HappyWith)
        {
            Console.WriteLine("I am gonno dominate the after my nap");
            this.Handle.CurrentState = new SleepingState(this.Handle);
        }
    }
}
