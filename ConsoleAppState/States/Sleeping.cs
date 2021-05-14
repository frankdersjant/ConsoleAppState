using System;

namespace ConsoleAppState.States
{
    public class Sleeping : CatState
    {
        public Sleeping(CatContext handle) : base(handle)
        {

        }

        public override void BowlEmpty()
        {
            throw new NotImplementedException();
        }

        public override void Comtemplating()
        {
            throw new NotImplementedException();
        }

        public override void GetsFed(int amount, int HappyWith)
        {
            Console.WriteLine("Hmm lekker!");
            this.Handle.CurrentState = new Eating(this.Handle, amount, HappyWith);

        }

    }
}
