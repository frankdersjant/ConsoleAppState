using System;

namespace ConsoleAppState.States
{
    public class EatingState : AbstractCatState
    {
        private int Amount;
        private int HappyWith;

        public EatingState(CatContext Handle, int amount, int happyWith):base(Handle)
        {
            Amount = amount;
            HappyWith = happyWith;
        }

        public override void BowlEmpty()
        {
            if (Amount >= HappyWith)
            {
                Console.WriteLine("Thats was great - time for a little nap...");
                this.Handle.CurrentState = new SleepingState(this.Handle);
            }
            else
            {
                Console.WriteLine("Why oh Why");
                this.Handle.CurrentState = new ContemplatingState(this.Handle);
            }
        }
    }
}
