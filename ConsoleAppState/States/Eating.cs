using System;

namespace ConsoleAppState.States
{
    public class Eating : CatState
    {
        private int Amount;
        private int HappyWith;

        public Eating(CatContext Handle, int amount, int happyWith):base(Handle)
        {
            Amount = amount;
            HappyWith = happyWith;
        }

        public override void BowlEmpty()
        {
            if (Amount >= HappyWith)
                Console.WriteLine("Thats was great");
            this.Handle.CurrentState = new Sleeping(this.Handle);
        }

        public override void GetsFed(int amount, int HappyWith)
        {
            throw new NotImplementedException();
        }
    }
}
